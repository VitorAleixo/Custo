using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    public class Composicao
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }        
        public double CustoTotal { get; set; }
        public double CustoVenda { get; set; }
        public double Lucro { get; set; }


        public Composicao()
        {

        }

        public void Inserir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO Composicao ");
                sql.AppendLine("(IdProduto, CustoTotal, CustoVenda) VALUES ");
                sql.AppendLine($"({this.IdProduto}");                
                sql.AppendLine($",{this.CustoTotal.ToString().Replace(",",".")}");
                sql.AppendLine($",{this.CustoVenda})");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void InserirCustoTotal()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE Composicao  ");
                sql.AppendLine($"SET CustoTotal = '{this.CustoTotal.ToString().Replace(", ", ".")}'");
                sql.AppendLine($" WHERE IdProduto = {this.IdProduto};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
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

                sql.AppendLine("UPDATE Composicao ");
                sql.AppendLine($"SET IdProduto = {this.IdProduto} ");                
                sql.AppendLine($"  , CustoTotal = {this.CustoTotal} ");
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

        public void Excluir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("DELETE FROM Composicao ");
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

        public static List<Composicao> BuscarTodos()
        {
            var lst = new List<Composicao>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Composicao;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new Composicao
                            {
                                Id = dr.GetInt32(0),
                                IdProduto = dr.GetInt32(1),
                                CustoTotal = dr.GetDouble(2),
                                CustoVenda = dr.GetDouble(3)
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

        public void GravarVenda()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE Composicao ");
                sql.AppendLine($"SET CustoVenda = '{this.CustoVenda.ToString().Replace(",",".")}' ");
                sql.AppendLine($"WHERE IdProduto = {this.IdProduto};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                sql.AppendLine("UPDATE Produto ");
                sql.AppendLine($"SET PrecoVenda = '{this.CustoVenda.ToString().Replace(",", ".")}' ");
                sql.AppendLine($"WHERE Id = {this.IdProduto};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                conn.Close();
            }
        }

        public void GravarLucro()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE COMPOSICAO ");
                sql.AppendLine($"SET Lucro = '{this.Lucro.ToString().Replace(",", ".")}' ");
                sql.AppendLine($"WHERE IdProduto = {this.IdProduto};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void VerificarVenda()
        {
            using (var conn =
            new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT CustoVenda FROM COMPOSICAO ");
                sql.AppendLine($"WHERE IdProduto = '{this.IdProduto}' ");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CustoVenda = dr.GetDouble(0);
                           
                        }
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void GravarCusto()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE COMPOSICAO ");
                sql.AppendLine($"SET CustoTotal = '{this.CustoTotal.ToString().Replace(",", ".")}' ");
                sql.AppendLine($"WHERE IdProduto = {this.IdProduto};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

    }
}
