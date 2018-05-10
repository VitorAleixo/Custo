using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class Ranking
    {
        public string ProdutoNome { get; set; }
        public int IdProduto { get; set; }
        public double Quantidade { get; set; }
        public int RankingItem { get; set; }

        public string ClienteNome { get; set; }
        public int IdCliente { get; set; }
        public double QtdPedidos { get; set; }
        public int RankingCliente { get; set; }

        public void InserirRanking()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO RankingProduto ");
                sql.AppendLine("WITH TabelaTemporaria(IdProduto, Quantidade) AS ");
                sql.AppendLine("(SELECT IdProduto, SUM(Quantidade) AS Total ");
                sql.AppendLine("FROM PedidoItem GROUP BY IdProduto) ");
                sql.AppendLine("SELECT S.IdProduto, S.Quantidade, 1+COUNT(menor.Quantidade) AS Ranking ");
                sql.AppendLine("FROM TabelaTemporaria as S ");
                sql.AppendLine("LEFT JOIN TabelaTemporaria AS menor ");
                sql.AppendLine("ON S.Quantidade<menor.Quantidade ");
                sql.AppendLine("GROUP BY S.IdProduto, S.Quantidade ");
                sql.AppendLine("ORDER BY S.Quantidade DESC;");

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

        public void SairRanking()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM RankingProduto ");

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

        public static List<Ranking> TabelaPedido()
        {
            var lst = new List<Ranking>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM RankingProduto");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var produto = Produto.BuscarTodos().Where(p => p.Id == dr.GetInt32(0)).FirstOrDefault();

                            if (produto != null)
                            {
                                lst.Add(new Ranking
                                {
                                    IdProduto = dr.GetInt32(0),
                                    Quantidade = dr.GetDouble(1),
                                    RankingItem = dr.GetInt32(2),
                                    ProdutoNome = produto.Descricao.ToString()
                                });
                            }
                        }
                        cmd.Dispose();
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
            return lst;
        }


        public void SairRankingCliente()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM RankingCliente ");

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

        public void InserirRankingCliente()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO RankingCliente ");
                sql.AppendLine(" WITH TabelaTemporaria(IdCliente, QtdPedido) AS ");
                sql.AppendLine(" (SELECT IdCliente, QtdPedido AS Total  ");
                sql.AppendLine(" FROM Pedido GROUP BY QtdPedido) ");
                sql.AppendLine(" SELECT S.IdCliente, S.QtdPedido, 1+COUNT(menor.QtdPedido) AS Ranking ");
                sql.AppendLine(" FROM TabelaTemporaria as S ");
                sql.AppendLine(" LEFT JOIN TabelaTemporaria AS menor ");
                sql.AppendLine(" ON S.QtdPedido<menor.QtdPedido  ");
                sql.AppendLine(" GROUP BY S.IdCliente, S.QtdPedido  ");
                sql.AppendLine(" ORDER BY S.QtdPedido DESC;");

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

        public static List<Ranking> TabelaPedidoCliente()
        {
            var lst = new List<Ranking>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM RankingCliente;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var cliente = Cliente.BuscarTodos().Where(p => p.Id == dr.GetInt32(0)).FirstOrDefault();
                            lst.Add(new Ranking
                            {
                                IdCliente = dr.GetInt32(0),
                                QtdPedidos = dr.GetDouble(1),
                                RankingCliente = dr.GetInt32(2),
                                ClienteNome = cliente.Nome.ToString()
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
