using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Data
{
    public class DatabaseConfig : DAOConection<object>
    {
        public void CreateTables()
        {
            try
            {
                if (!TableExists("Cliente"))
                {
                    strSQL = "CREATE TABLE [dbo].[Cliente] (" +
                        "\r\n   [Id][int] IDENTITY(1, 1) PRIMARY KEY NOT NULL," +
                        "\r\n   [cliCPF] [varchar] (14) NULL," +
                        "\r\n   [cliNome][varchar](200) NULL," +
                        "\r\n   [cliEndereco][varchar](200) NULL," +
                        "\r\n   [cliCidade][varchar](200) NULL," +
                        "\r\n   [cliBairro][varchar](100) NULL," +
                        "\r\n   [cliNumero][varchar](50) NULL," +
                        "\r\n   [cliTelefoneCelular][varchar](14) NULL," +
                        "\r\n   [cliTelefoneFixo][varchar](13) NULL" +
                        "\r\n )";

                    ExecuteNonQueryTransaction(CommandType.Text, strSQL);
                }

                if (!TableExists("Livro"))
                {
                    strSQL = "CREATE TABLE[dbo].[Livro] (" +
                   "\r\n    [Id][int] IDENTITY(1, 1) PRIMARY KEY NOT NULL," +
                   "\r\n    [livroNome][varchar](50) NULL," +
                   "\r\n    [livroAutor][varchar](200) NULL," +
                   "\r\n    [livroEditora][varchar](100) NULL," +
                   "\r\n    [livroAnoPublicacao][datetime] NULL," +
                   "\r\n    [livroEdicao][varchar](50) NULL " +
                   "\r\n )";

                    ExecuteNonQueryTransaction(CommandType.Text, strSQL);
                }

                if (!TableExists("Livro_Cliente_Emprestimo"))
                {
                    strSQL = "CREATE TABLE[dbo].[Livro_Cliente_Emprestimo] (" +
                    "\r\n    [LceId][int] IDENTITY(1, 1) PRIMARY KEY NOT NULL," +
                    "\r\n    [LceIdCliente] [int] NOT NULL," +
                    "\r\n    [LceIdLivro] [int] NOT NULL," +
                    "\r\n    [LceDataEmprestimo] [datetime] NULL," +
                    "\r\n    [LceDataEntrega][datetime] NULL," +
                    "\r\n    [LceEntregue][bit] NULL," +
                    "\r\n    CONSTRAINT[FK_Livro_Cliente_Emprestimo_Cliente] FOREIGN KEY([LceIdCliente]) REFERENCES[dbo].[Cliente]([Id])," +
                    "\r\n    CONSTRAINT[FK_Livro_Cliente_Emprestimo_Livro] FOREIGN KEY([LceIdLivro]) REFERENCES[dbo].[Livro]([Id])" +
                    "\r\n )";

                    ExecuteNonQueryTransaction(CommandType.Text, strSQL);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool TableExists(string tableName)
        {
            string sql = $"IF OBJECT_ID('{tableName}', 'U') IS NOT NULL SELECT 1 ELSE SELECT 0";
            int result = Convert.ToInt32(ExecuteScalarTransaction(CommandType.Text, sql));
            return result == 1;
        }

        protected override List<object> GetObject(SqlDataReader objDataReader)
        {
            throw new NotImplementedException();
        }
    }
}
