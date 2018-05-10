using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    public class ComposicaoItem
    {
        public int Id { get; set; }
        public int IdComposicao { get; set; }
        public int IdProduto { get; set; }        
        public double Quantidade { get; set; }

        public string Descricao { get; set; }
        public string UM { get; set; }
        public double PrecoUnitario { get; set; }
        public double Custo { get; set; }

        public ComposicaoItem()
        {

        }

        public void Inserir()
        {
            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("INSERT INTO ComposicaoItem ");
                sql.AppendLine("(IdComposicao, IdProduto, Quantidade) VALUES ");
                sql.AppendLine($"({this.IdComposicao}");
                sql.AppendLine($",{this.IdProduto}");                
                sql.AppendLine($",{this.Quantidade.ToString().Replace(",", ".")})");

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

                sql.AppendLine("UPDATE ComposicaoItem ");
                sql.AppendLine($"SET IdProduto = {this.IdProduto} ");
                sql.AppendLine($"  , IdComposicao = {this.IdComposicao} ");
                sql.AppendLine($"  , Quantidade = {this.Quantidade.ToString().Replace(",", ".")} ");
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

                sql.AppendLine("DELETE FROM ComposicaoItem ");
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

        public static List<ComposicaoItem> BuscarTodos()
        {
            var lst = new List<ComposicaoItem>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM ComposicaoItem;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var produto = Produto.BuscarTodos().Where(p => p.Id == dr.GetInt32(2)).FirstOrDefault();

                            lst.Add(new ComposicaoItem
                            {
                                Id = dr.GetInt32(0),
                                IdComposicao = dr.GetInt32(1),
                                IdProduto = dr.GetInt32(2),
                                Quantidade = dr.GetDouble(3),
                                PrecoUnitario = produto.PrecoCompra,
                                Descricao = produto.Codigo + " - " + produto.Descricao,
                                UM = produto.UM,
                                Custo = dr.GetDouble(3) * produto.PrecoCompra
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
