using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class Login
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public string Usuario { get; set; }
        public string User { get; set; }
        public string NomeUser { get; set; }
        public string Senha { get; set; }
        public bool Validar { get; set; } = false;

       
        public Login()
        {

        }
        //BUG
        public void SetStatus()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("UPDATE ContaCliente ");
                sql.AppendLine($"SET Status = '1' ");
                sql.AppendLine($"WHERE Usuario = '{this.Usuario}';");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void SetStatusSair()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("UPDATE ContaCliente ");
                sql.AppendLine($"SET Status = '0' ");
                sql.AppendLine($"WHERE Status = '1';");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void VerStatus()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT Usuario FROM ContaCliente ");
                sql.AppendLine($"WHERE Status = '1' ");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            User = dr.GetString(0);
                        }
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public void VerStatusNome()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT Nome FROM ContaCliente ");
                sql.AppendLine($"WHERE Status = '1' ");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            NomeUser = dr.GetString(0);
                        }
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }

        }

        public void Validacao()
        {
            using (var conn =
              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                Criptografia c = new Criptografia();
                string senhaCriptografada = c.SHA256(this.Senha);
                sql.AppendLine("SELECT Usuario, Senha FROM ContaCliente");
                sql.AppendLine($" WHERE Usuario = '{this.Usuario}' AND Senha = '{senhaCriptografada}' ");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (this.Usuario == dr["Usuario"].ToString() && senhaCriptografada == dr["Senha"].ToString())
                            {
                                Validar = true;
                            }
                            else
                            {
                                Validar = false;
                            }

                        }
                        if (Validar == true)
                        {
                            SetStatus();
                        }
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }
        }
    }
}
