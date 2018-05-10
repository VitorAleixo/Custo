using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }

        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double CustoUnitario { get; set; }
        public double CustoTotal { get; set; }
        public string Observacoes { get; set; }

        public PedidoItem()
        {

        }

        public void Inserir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO TabelaPedidoItem");
                //sql.AppendLine("INSERT INTO PedidoItem ");
                sql.AppendLine("(IdPedido, IdProduto, Quantidade,  Observacoes) VALUES ");
                sql.AppendLine($"({0}");
                sql.AppendLine($",{this.IdProduto}");
                sql.AppendLine($",{this.Quantidade.ToString().Replace(",", ".")}");
                sql.AppendLine($",'{this.Observacoes}')");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
        }

        public void Atualizar()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE PedidoItem ");
                sql.AppendLine($"SET IdPedido = {this.IdPedido} ");
                sql.AppendLine($"  , IdProduto = {this.IdProduto} ");
                sql.AppendLine($"  , Quantidade = {this.Quantidade.ToString().Replace(",", ".")} ");
                sql.AppendLine($"  , Observacoes = {this.Observacoes} ");
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
        }

        public void Excluir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM TabelaPedidoItem ");
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                sql.AppendLine("DELETE FROM PedidoItem ");
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
        }

        public static List<PedidoItem> BuscarTodos()
        {
            var lst = new List<PedidoItem>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM PedidoItem;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var produto = Produto.BuscarTodosComVenda().Where(p => p.Id == dr.GetInt32(2)).FirstOrDefault();

                            lst.Add(new PedidoItem
                            {
                                Id = dr.GetInt32(0),
                                IdPedido = dr.GetInt32(1),
                                IdProduto = dr.GetInt32(2),
                                Quantidade = dr.GetDouble(3),
                                CustoUnitario = produto.PrecoVenda,
                                CustoTotal = dr.GetDouble(3) * produto.PrecoVenda,
                                Descricao = produto.Codigo + " - " + produto.Descricao,
                                Observacoes = dr.GetString(4)
                                
                            });
                        }
                        cmd.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            return lst;
        }
        public static List<PedidoItem> TabelaBuscarTodos()
        {
            var lst = new List<PedidoItem>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM TabelaPedidoItem;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var produto = Produto.BuscarTodos().Where(p => p.Id == dr.GetInt32(2)).FirstOrDefault();

                            lst.Add(new PedidoItem
                            {
                                Id = dr.GetInt32(0),
                                IdPedido = dr.GetInt32(1),
                                IdProduto = dr.GetInt32(2),
                                Quantidade = dr.GetDouble(3),
                                CustoUnitario = produto.PrecoCompra,
                                CustoTotal = dr.GetDouble(3) * produto.PrecoCompra,
                                Descricao = produto.Codigo + " - " + produto.Descricao,
                                Observacoes = dr.GetString(4)

                            });
                        }
                        cmd.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            return lst;
        }

    }
}
