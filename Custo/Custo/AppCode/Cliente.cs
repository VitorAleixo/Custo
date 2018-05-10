using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public bool CheckUser { get; set; }
        public Cliente()
        {

        }

        public void ChecarUsuarioInserir()
        {
            using (var conn =
           new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Clientes WHERE Nome = '" + this.Nome + "';";

                if (cmd.ExecuteScalar() == null)
                {
                    CheckUser = true;
                    cmd.Dispose();
                }
                else
                {
                    CheckUser = false;
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void ChecarUsuarioAtualizar()
        {
            using (var conn =
           new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Clientes WHERE Nome = '" + this.Nome+ "';";

                if (cmd.ExecuteScalar() == null)
                {
                    CheckUser = false;
                    cmd.Dispose();
                }
                else
                {
                    CheckUser = true;
                    cmd.Dispose();
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

                sql.AppendLine("INSERT INTO Clientes ");
                sql.AppendLine("(Nome, CPF, Telefone,Email, Endereco) VALUES ");
                sql.AppendLine($"('{this.Nome}'");
                sql.AppendLine($",'{this.CPF}'");
                sql.AppendLine($",'{this.Telefone}'");
                sql.AppendLine($",'{this.Email}'");
                sql.AppendLine($",'{this.Endereco}')");

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

                sql.AppendLine("UPDATE Clientes ");
                sql.AppendLine($"SET Nome = '{this.Nome}' ");
                sql.AppendLine($"  , CPF = '{this.CPF}' ");
                sql.AppendLine($"  , Telefone = '{this.Telefone}' ");
                sql.AppendLine($"  , Email = '{this.Email}' ");
                sql.AppendLine($"  , Endereco = '{this.Endereco}' ");
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
                
                sql.AppendLine("DELETE FROM Clientes ");
                sql.AppendLine($"WHERE Id = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                sql.AppendLine("DELETE FROM Pedido ");
                sql.AppendLine($"WHERE IdCliente = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                sql.AppendLine("DELETE FROM PedidoItem ");
                sql.AppendLine($"WHERE IdCliente = {this.Id};");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                conn.Close();
            }
        }

        public static List<Cliente> BuscarTodos()
        {
            var lst = new List<Cliente>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Clientes;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new Cliente
                            {
                                Id = dr.GetInt32(0),
                                Nome = dr.GetString(1),
                                CPF = dr.GetString(2),
                                Telefone = dr.GetString(3),
                                Email = dr.GetString(4),
                                Endereco = dr.GetString(5),
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
