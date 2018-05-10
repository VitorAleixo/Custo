using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Data { get; set; }
        public string Cliente2 { get; set; }
        public double ValorTotal { get; set; }
        public string Status{ get; set; }

        public string nomeCliente { get; set; }
        public Pedido()
        {

        }

        public void LimparTabela()
        {
            using (var conn =
               new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM TabelaPedidoItem ");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }
                conn.Close();
            }
        }
     
        public void Inserir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO Pedido ");
                sql.AppendLine("(IdCliente, Data, Status) VALUES ");
                sql.AppendLine($"({this.IdCliente}");
                sql.AppendLine($",'{this.Data}'");
                sql.AppendLine($",'{this.Status}')");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("UPDATE Pedido ");
                sql.AppendLine($"SET DATA = substr(DATA, 7, 4) || '-' || substr(DATA, 4, 2) || '-' || substr(DATA, 1, 2) ");
                sql.AppendLine($"WHERE Id = (SELECT MAX(id) FROM Pedido);");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }



                sql.AppendLine("UPDATE TabelaPedidoItem SET IdPedido = (Select MAX(Id) from Pedido)");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("INSERT into PedidoItem ");
                sql.AppendLine("SELECT Id, IdPedido, IdProduto, Quantidade, Observacoes FROM TabelaPedidoItem");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("DELETE FROM TabelaPedidoItem; ");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }
                conn.Close();
            }
        }

        public void Atualizar()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE Pedido ");
                sql.AppendLine($"SET IdCliente = {this.IdCliente} ");
                sql.AppendLine($", Data = '{this.Data}' ");
                sql.AppendLine($", Status = '{this.Status}' ");
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("UPDATE Pedido ");
                sql.AppendLine($"SET DATA = substr(DATA, 7, 4) || '-' || substr(DATA, 4, 2) || '-' || substr(DATA, 1, 2) ");
                sql.AppendLine($"WHERE Id = {this.Id};");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

               


                sql.AppendLine("UPDATE TabelaPedidoItem ");
                sql.AppendLine($"SET IdPedido = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("INSERT into PedidoItem ");
                sql.AppendLine("SELECT Id, IdPedido, IdProduto, Quantidade, Observacoes FROM TabelaPedidoItem");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }


                sql.AppendLine("DELETE FROM TabelaPedidoItem; ");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }
                conn.Close();
            }
        }

        public void Excluir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM PedidoItem ");
                sql.AppendLine($"WHERE IdPedido = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                sql.AppendLine("DELETE FROM Pedido ");
                sql.AppendLine($"WHERE Id = {this.Id};");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public static List<Pedido> BuscarTodos()
        {
            var lst = new List<Pedido>();
 
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var cliente = Cliente.BuscarTodos().Where(p => p.Id == dr.GetInt32(1)).FirstOrDefault();
                            var valorTotal = PedidoItem.BuscarTodos().Where(p => p.IdPedido == dr.GetInt32(0)).Sum(p => p.CustoTotal);

                            lst.Add(new Pedido
                            {
                                Id = dr.GetInt32(0),
                                IdCliente = dr.GetInt32(1),
                                Data = dr.GetDateTime(2).ToString("dd/MM/yyyy"),
                                Status = dr.GetString(3),
                                Cliente2 = cliente.Nome,
                                ValorTotal = valorTotal

                            });
                        }
                        cmd.Dispose();
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return lst;
        }
    }
}
