using Custo.AppCode;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Custo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var _novoBanco = false;

            if (!File.Exists("DB.sqlite"))
            {
                _novoBanco = true;
                SQLiteConnection.CreateFile("DB.sqlite");
            }

            SQLiteConnection conn = new SQLiteConnection("Data Source=DB.sqlite");

            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='Produto' and type='table'";
            if (_novoBanco || cmd.ExecuteScalar() == null)
            { 
                cmd.CommandText = "CREATE TABLE Produto ([Id] INTEGER PRIMARY KEY, [Codigo] VARCHAR(100),[Descricao] VARCHAR(100), [UM] VARCHAR(100), [Tipo] VARCHAR(100), [PrecoCompra] FLOAT,[PrecoVenda] FLOAT);";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='Composicao' and type='table'";
            if (_novoBanco || cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE Composicao ([Id] INTEGER PRIMARY KEY, [IdProduto] INTEGER, [CustoTotal] FLOAT, [CustoVenda] FLOAT, [Lucro]);";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='ComposicaoItem' and type='table'";
            if (_novoBanco || cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE ComposicaoItem ([Id] INTEGER PRIMARY KEY, [IdComposicao] INTEGER, [IdProduto] INT, [Quantidade] FLOAT);";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='Clientes' and type='table'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE Clientes ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100), [CPF] VARCHAR(20), [Telefone] VARCHAR(100),[Email] VARCHAR(100), [Endereco] VARCHAR(1000));";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='Pedido' and type='table'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE Pedido ([Id] INTEGER PRIMARY KEY, [IdCliente] INTEGER , [Data] DATE(15), [Status] VARCHAR(10);";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='PedidoItem' and type='table'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE PedidoItem ([Id] INTEGER PRIMARY KEY, [IdPedido] INTEGER , [IdProduto] INTEGER,  [Quantidade] FLOAT, [Observacoes] VARCHAR(1000));";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='TabelaPedidoItem' and type='table'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE TabelaPedidoItem ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [IdPedido] INTEGER , [IdProduto] INTEGER,  [Quantidade] FLOAT, [Observacoes] VARCHAR(1000));";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT '1' FROM sqlite_master WHERE name ='ContaCliente' and type='table'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "CREATE TABLE ContaCliente ([Id] INTEGER PRIMARY KEY AUTOINCREMENT, [Usuario] VARCHAR(50), [Senha] VARCHAR(50), [Nome] VARCHAR(50),[Cpf] VARCHAR(20), [Email] VARCHAR(50), [Telefone] VARCHAR(100), [Endereco] VARCHAR(1000), [TipoConta] VARCHAR(20), [Status] VARCHAR(10));";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT * FROM ContaCliente WHERE Usuario='ADMIN';";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "INSERT INTO ContaCliente (Usuario, Senha, Nome, CPF, Email, Telefone, Endereco, TipoCOnta, Status) VALUES ('ADMIN', '12qw!@QW', 'Vitor Aleixo', 'ADMIN', 'ADMIN', 'ADMIN', 'ADMIN', 'ADMIN', '0'); ";
                cmd.ExecuteNonQuery();
            }

            cmd.Dispose();

            conn.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin f = new frmLogin();

            f.ShowDialog();

            if (f.Validar)
            {
                Application.Run(new frmPrincipal());
            }


        }
    }
}
