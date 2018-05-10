using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custo.AppCode
{
    class CadastroUsuario
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoConta { get; set; }
        public int Status { get; set; }

        public string UsuarioLogin { get; set; }
        public bool Checar { get; set; } = false;
        public bool CheckUser { get; set; } = false;

        public void ChecarUsuarioInserir()
        {
            using (var conn =
           new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ContaCliente WHERE Usuario='" + this.Usuario + "';";

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
                cmd.CommandText = "SELECT * FROM ContaCliente WHERE Usuario='" + this.Usuario + "';";

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


                    sql.AppendLine("INSERT INTO ContaCliente ");
                    sql.AppendLine("(Usuario, Senha, Nome, Cpf, Email, Telefone, Endereco, TipoConta, Status ) VALUES ");
                    sql.AppendLine($"('{this.Usuario}'");
                    sql.AppendLine($",'{this.Senha}'");
                    sql.AppendLine($",'{this.Nome}'");
                    sql.AppendLine($",'{this.Cpf}'");
                    sql.AppendLine($",'{this.Email}'");
                    sql.AppendLine($",'{this.Telefone}'");
                    sql.AppendLine($",'{this.Endereco}'");
                    sql.AppendLine($",'{this.TipoConta}'");
                    sql.AppendLine($",'{0}')");

                   
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

                sql.AppendLine("UPDATE ContaCliente ");
                sql.AppendLine($"SET Usuario = '{this.Usuario}' ");
                sql.AppendLine($"  , Senha = '{this.Senha}' ");
                sql.AppendLine($"  , Nome = '{this.Nome}' ");
                sql.AppendLine($"  , Cpf = '{this.Cpf}' ");
                sql.AppendLine($"  , Email = '{this.Email}' ");
                sql.AppendLine($"  , Telefone = '{this.Telefone}' ");
                sql.AppendLine($"  , Endereco = '{this.Endereco}' ");
                sql.AppendLine($"  , TipoConta = '{this.TipoConta}' ");
                sql.AppendLine($"  , Status = '{this.Status}' ");
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

                sql.AppendLine("DELETE FROM ContaCliente ");
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

        public static List<CadastroUsuario> BuscarTodos()
        {
            var lst = new List<CadastroUsuario>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM ContaCliente;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new CadastroUsuario
                            {
                                Id = dr.GetInt32(0),
                                Usuario = dr.GetString(1),
                                Senha = dr.GetString(2),
                                Nome = dr.GetString(3),
                                Cpf = dr.GetString(4),
                                Email = dr.GetString(5),
                                Telefone = dr.GetString(6),
                                Endereco = dr.GetString(7),
                                TipoConta = dr.GetString(8),
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

        public void CheckAdmin()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("SELECT TipoConta FROM ContaCliente ");
                sql.AppendLine($"WHERE Usuario = '{this.Usuario}'");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteReader();
                    cmd.Dispose();
                }

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if ("ADMIN" == dr["TipoConta"].ToString())
                            {
                                Checar = true;

                            }
                            else
                            {
                                Checar = false;
                            }
                        }
                        cmd.Dispose();
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
        }
    }
}
