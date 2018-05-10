using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Custo.AppCode
{
    class Filtro
    {
        //PEDIDOS
        public static string IdCliente { get; set; }
        public static string dataDe { get; set; }
        public static string dataAte { get; set; }
        public static string nomeCliente { get; set; }
        public static string statusPedido { get; set; }


        //CLIENTE
        public static string Nome { get; set; }


        //PRODUTO
        public static string Cod{ get; set; }
        public static string Desc { get; set; }
        public static string Tipo { get; set; }


        //CLIENTE ADMIN
        public static string Usuario { get; set; }
        public static string TipoConta { get; set; }


        //LUCRO
        public static string dataDia { get; set; }
        public static string dataMes { get; set; }
        public static string dataAno { get; set; }
        public static string dataDeLucro { get; set; }
        public static string dataAteLucro { get; set; }

        //PEDIDO
        public static List<Pedido> pedidoFiltrarPorData()
        {
 
            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {
                
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data BETWEEN  substr('{dataDe.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDe.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDe.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND substr('{dataAte.Replace('/', '-')}', 7, 4) || '-' || substr('{dataAte.Replace('/', '-')}', 4, 2) || '-' || substr('{dataAte.Replace('/', '-')}', 1, 2) ");

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

        public static List<Pedido> pedidoFiltrarPorNome()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE IdCliente = '{IdCliente}'");

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

        public static List<Pedido> pedidoFiltrarPorNomeData()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data BETWEEN  substr('{dataDe.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDe.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDe.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND substr('{dataAte.Replace('/', '-')}', 7, 4) || '-' || substr('{dataAte.Replace('/', '-')}', 4, 2) || '-' || substr('{dataAte.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND IDCliente = '{IdCliente}'");

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

        public static List<Pedido> pedidoFiltrarPorNomeStatus()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE IDCliente = '{IdCliente}' ");
                sql.AppendLine($"AND Status = '{statusPedido}' ");
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

        public static List<Pedido> pedidoFiltrarPorDataStatus()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data BETWEEN  substr('{dataDe.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDe.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDe.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND substr('{dataAte.Replace('/', '-')}', 7, 4) || '-' || substr('{dataAte.Replace('/', '-')}', 4, 2) || '-' || substr('{dataAte.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND Status = '{statusPedido}' ");
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
        public static List<Pedido> pedidoFiltrarPorNomeDataStatus()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data BETWEEN  substr('{dataDe.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDe.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDe.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND substr('{dataAte.Replace('/', '-')}', 7, 4) || '-' || substr('{dataAte.Replace('/', '-')}', 4, 2) || '-' || substr('{dataAte.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND Status = '{statusPedido}' ");
                sql.AppendLine($"AND IDCliente = '{IdCliente}' ");
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

        public static List<Pedido> pedidoFiltrarPorStatus()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Status = '{statusPedido}' ");
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

        //CLIENTE
        public static List<Cliente> clienteBuscarPorNome()
        {
            var lst = new List<Cliente>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Clientes ");
                sql.AppendLine($"WHERE Nome LIKE '%{Nome}%';");

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

        //PRODUTOS
        public static List<Produto> produtoFiltrarPorCodDescTipo()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Codigo = '{Cod}' ");
                sql.AppendLine($"AND Descricao LIKE '%{Desc}%' ");
                sql.AppendLine($"AND Tipo = '{Tipo}';");

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
                                PrecoVenda = dr.GetDouble(6)
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

        public static List<Produto> produtoFiltrarPorCodDesc()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Codigo = '{Cod}' ");
                sql.AppendLine($"AND Descricao LIKE '%{Desc}%';");

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
                                PrecoVenda = dr.GetDouble(6)
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

        public static List<Produto> produtoFiltrarPorCodTipo()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Codigo = '{Cod}' ");
                sql.AppendLine($"AND Tipo = '{Tipo}';");

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
                                PrecoVenda = dr.GetDouble(6)
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

        public static List<Produto> produtoFiltrarPorCod()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Codigo = '{Cod}';");
   
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
                                PrecoVenda = dr.GetDouble(6)
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

        public static List<Produto> produtoFiltrarPorDescTipo()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Descricao LIKE '%{Desc}%' ");
                sql.AppendLine($"AND Tipo = '{Tipo}' ");
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
                                PrecoVenda = dr.GetDouble(6)
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

        public static List<Produto> produtoFiltrarPorDesc()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Descricao LIKE '%{Desc}%'; ");

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
                                PrecoVenda = dr.GetDouble(6)
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


        public static List<Produto> produtoFiltrarPorTipo()
        {
            var lst = new List<Produto>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Produto ");
                sql.AppendLine($"WHERE Tipo = '{Tipo}'; ");

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
                                PrecoVenda = dr.GetDouble(6)
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

        //CONTA ADMIN
        public static List<CadastroUsuario> clienteadminBuscarPorUsuarioTipoConta()
        {
            var lst = new List<CadastroUsuario>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM ContaCliente ");
                sql.AppendLine($"WHERE Usuario = '{Usuario}' ");
                sql.AppendLine($"AND TipoConta = '{TipoConta}'; ");
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

        public static List<CadastroUsuario> clienteadminBuscarPorUsuario()
        {
            var lst = new List<CadastroUsuario>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM ContaCliente ");
                sql.AppendLine($"WHERE Usuario LIKE '%{Usuario}%'; ");
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

        public static List<CadastroUsuario> clienteadminBuscarPorTipoConta()
        {
            var lst = new List<CadastroUsuario>();

            using (var conn =
                new SQLiteConnection("Data Source=DB.sqlite"))
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM ContaCliente ");
                sql.AppendLine($"WHERE TipoConta = '{TipoConta}'; ");
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

        //LUCRO
        public static List<Pedido> lucroFiltrarPorDia()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data = substr('{dataDia.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDia.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDia.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND Status = 'COMPLETO' ");
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

        public static List<Pedido> lucroFiltrarPorMes()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data LIKE '%{dataAno + "-" + dataMes}%'");
                sql.AppendLine($"AND Status = 'COMPLETO' ");
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

        public static List<Pedido> lucroFiltrarPorAno()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data LIKE '%{dataAno}%' ");
                sql.AppendLine($"AND Status = 'COMPLETO' ");
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

        public static List<Pedido> lucroFiltrarPorTudo()
        {

            var lst = new List<Pedido>();
            using (var conn =
                              new SQLiteConnection("Data Source=DB.sqlite"))
            {

                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Pedido ");
                sql.AppendLine($"WHERE Data BETWEEN  substr('{dataDeLucro.Replace('/', '-')}', 7, 4) || '-' || substr('{dataDeLucro.Replace('/', '-')}', 4, 2) || '-' || substr('{dataDeLucro.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND substr('{dataAteLucro.Replace('/', '-')}', 7, 4) || '-' || substr('{dataAteLucro.Replace('/', '-')}', 4, 2) || '-' || substr('{dataAteLucro.Replace('/', '-')}', 1, 2) ");
                sql.AppendLine($"AND Status = 'COMPLETO' ");
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