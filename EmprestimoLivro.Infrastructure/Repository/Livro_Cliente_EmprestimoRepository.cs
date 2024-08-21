using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Repository
{
    public class Livro_Cliente_EmprestimoRepository : DAOConection<Livro_Cliente_Emprestimo>, ILivro_Cliente_EmprestimoRepository
    {
        public void Atualizar(Livro_Cliente_Emprestimo livro_Cliente_Emprestimo)
        {
            try
            {
                strSQL = "UPDATE Livro_Cliente_Emprestimo SET LceId = @LceId, LceIdCliente = @LceIdCliente," +
                    "\r\n LceIdLivro = @LceIdLivro, LceDataEmprestimo = @LceDataEmprestimo, LceDataEntrega = @LceDataEntrega," +
                    "\r\n LceEntregue = @LceEntregue" +
                    "\r\n WHERE LceId = @LceId";

                ClearParameters();
                AddParametersEmprestimo(livro_Cliente_Emprestimo);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Livro_Cliente_Emprestimo Consultar(int lceId)
        {
            try
            {
                strSQL = "SELECT LceId, LceIdCliente, LceIdLivro, LceDataEmprestimo, LceDataEntrega, LceEntregue" +
                    "\r\n FROM Livro_Cliente_Emprestimo" +
                    "\r\n WHERE LceId = @LceId";

                ClearParameters();
                AddParameters("@LceId", lceId + "");
                return GetObject(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int lceId)
        {
            try
            {
                strSQL = "DELETE FROM Livro_Cliente_Emprestimo WHERE LceId = @LceId";

                ClearParameters();
                AddParameters("@LceId", lceId);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir(Livro_Cliente_Emprestimo livro_cliente_emprestimo)
        {

            try
            {
                strSQL = "INSERT INTO Livro_Cliente_Emprestimo(LceIdCliente, LceIdLivro, LceDataEmprestimo, LceDataEntrega, LceEntregue)" +
                    "\r\n VALUES(@LceIdCliente, @LceIdLivro, @LceDataEmprestimo, @LceDataEntrega, @LceEntregue) ";

                ClearParameters();
                AddParametersEmprestimo(livro_cliente_emprestimo);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Livro_Cliente_Emprestimo> Pesquisar(string pesquisar)
        {
            try
            {
                strSQL = "SELECT LCE.LceId, LCE.LceIdCliente, LCE.LceIdLivro, LCE.LceDataEmprestimo, LCE.LceDataEntrega," +
                    "\r\n LCE.LceEntregue, Cliente.CliNome, Livro.LivroNome" +
                    "\r\n FROM Livro_Cliente_Emprestimo LCE" +
                    "\r\n LEFT JOIN Cliente ON Cliente.id = LCE.LceIdCliente" +
                    "\r\n LEFT JOIN Livro ON Livro.id = LCE.LceIdLivro" +
                    "\r\n WHERE Cliente.cliCPF LIKE @pesquisar OR" +
                    "\r\n Cliente.cliNome LIKE @pesquisar OR" +
                    "\r\n Livro.livroNome LIKE @pesquisar";

                ClearParameters();
                AddParameters("@pesquisar", pesquisar + "%");
                return GetData(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddParametersEmprestimo(Livro_Cliente_Emprestimo livro_Cliente_Emprestimo)
        {
            if (livro_Cliente_Emprestimo.LceId > 0)
            {
                AddParameters("@LceId", livro_Cliente_Emprestimo.LceId);
            }

            AddParameters("@LceId", livro_Cliente_Emprestimo.LceId);
            AddParameters("@LceIdCliente", livro_Cliente_Emprestimo.LceIdCliente);
            AddParameters("@LceIdLivro", livro_Cliente_Emprestimo.LceIdLivro);
            AddParameters("@LceDataEmprestimo", livro_Cliente_Emprestimo.LceDataEmprestimo);
            AddParameters("@LceDataEntrega", livro_Cliente_Emprestimo.LceDataEntrega);
            AddParameters("@LceEntregue", livro_Cliente_Emprestimo.LceEntregue);

        }

        protected override List<Livro_Cliente_Emprestimo> GetObject(SqlDataReader objDataReader)
        {
            var lista = new List<Livro_Cliente_Emprestimo>();

            while (objDataReader.Read())
            {
                var emprestimo = new Livro_Cliente_Emprestimo();

                emprestimo.LceId = objDataReader.GetReaderInt("LceId");
                emprestimo.LceIdCliente = objDataReader.GetReaderInt("LceIdCliente");
                emprestimo.LceIdLivro = objDataReader.GetReaderInt("LceIdLivro");
                emprestimo.LceDataEmprestimo = objDataReader.GetReaderDateTime("LceDataEmprestimo");
                emprestimo.LceDataEntrega = objDataReader.GetReaderDateTime("LceDataEntrega");
                emprestimo.LceEntregue = objDataReader.GetReaderBoolean("LceEntregue");

                emprestimo.CliNome = objDataReader.GetReaderString("CliNome");
                emprestimo.LivroNome = objDataReader.GetReaderString("LivroNome");

                lista.Add(emprestimo);
            }

            return lista;
        }
    }
}
