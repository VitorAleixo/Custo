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
                sql.AppendLine("(IdCliente, Data) VALUES ");
                sql.AppendLine($"({this.IdCliente}");
                sql.AppendLine($",'{this.Data}')");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                sql.AppendLine("UPDATE TabelaPedidoItem SET IdPedido = (Select Count(Id) from Pedido)");

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
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sql.Clear();
                }

                //furo
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
                                Data = dr.GetString(2),
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
