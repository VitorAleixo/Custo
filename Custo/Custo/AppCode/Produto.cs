using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string UM { get; set; }
        public string Tipo { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public Produto()
        {

        }

        public void Inserir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO Produto ");
                sql.AppendLine("(Codigo, Descricao, UM, Tipo, PrecoCompra, PrecoVenda) VALUES ");
                sql.AppendLine($"('{this.Codigo}'");
                sql.AppendLine($",'{this.Descricao}'");
                sql.AppendLine($",'{this.UM}'");
                sql.AppendLine($",'{this.Tipo}'");
                sql.AppendLine($",{this.PrecoCompra.ToString().Replace(",", ".")} ");
                sql.AppendLine($",'0')");

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

                sql.AppendLine("UPDATE Produto ");
                sql.AppendLine($"SET Codigo = '{this.Codigo}' ");
                sql.AppendLine($"  , Descricao = '{this.Descricao}' ");
                sql.AppendLine($"  , UM = '{this.UM}' ");
                sql.AppendLine($"  , Tipo = '{this.Tipo}' ");
                sql.AppendLine($"  , PrecoCompra = {this.PrecoCompra.ToString().Replace(",", ".")} ");
                sql.AppendLine($"  , PrecoVenda = '0' ");
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

                sql.AppendLine("DELETE FROM Produto ");
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

        public static List<Produto> BuscarTodos()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new Produto
                            {
                                Id = dr.GetInt32(0),
                                Codigo = dr.GetString(1),
                                Descricao = dr.GetString(2),
                                UM = dr.GetString(3),
                                Tipo = dr.GetString(4),
                                PrecoCompra = dr.GetDouble(5),
                                
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

        public static List<Produto> BuscarTodosComVenda()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new Produto
                            {
                                Id = dr.GetInt32(0),
                                Codigo = dr.GetString(1),
                                Descricao = dr.GetString(2),
                                UM = dr.GetString(3),
                                Tipo = dr.GetString(4),
                                PrecoCompra = dr.GetDouble(5),
                                PrecoVenda = dr.GetDouble(6),
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
