using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Repositorie
{
    public class ClienteRepositorie : DAOConection<Cliente>, IClienteRepository
    {
        public void Atualizar(Cliente cliente)
        {
            try
            {
                strSQL = "UPDATE Cliente  SET cliCPF = @cliCPF, cliNome = @cliNome, cliEndereco = @cliEndereco," +
                       "\r\n cliCidade = @cliCidade, cliBairro = @cliBairro, cliNumero = @cliNumero, cliTelefoneCelular = @cliTelefoneCelular," +
                       "\r\n clitelefoneFixo = @clitelefoneFixo" +
                       "\r\n WHERE id = @id";

                ClearParameters();
                AddParametersCliente(cliente);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cliente Consultar(int id)
        {
            try
            {
                strSQL = "SELECT Id, cliCPF, cliNome, cliEndereco, cliCidade, cliBairro, cliNumero," +
                    "\r\n cliTelefoneCelular, cliTelefoneFixo" +
                    "\r\n FROM Cliente" +
                    "\r\n WHERE Id = @Id";

                ClearParameters();
                AddParameters("@id", id + "%");
                return GetObject(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                strSQL = "DELETE FROM Cliente WHERE Id = @Id";

                ClearParameters();
                AddParameters("@id", id);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir(Cliente cliente)
        {
            try
            {
                strSQL = "INSERT INTO Cliente (cliCPF, cliNome, cliEndereco, cliCidade, cliBairro," +
                    "\r\n cliNumero, cliTelefoneCelular, clitelefoneFixo)" +
                    "\r\n VALUES(@cliCPF, @cliNome, @cliEndereco, @cliCidade, @cliBairro, @cliNumero, " +
                    "\r\n @cliTelefoneCelular, @clitelefoneFixo)";

                ClearParameters();
                AddParametersCliente(cliente);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cliente> Pesquisar(string pesquisar)
        {
            try
            {
                strSQL = "SELECT Id, cliCPF, cliNome, cliEndereco, cliCidade, cliBairro, cliNumero," +
                    "\r\n cliTelefoneCelular, cliTelefoneFixo" +
                    "\r\n FROM Cliente" +
                    "\r\n WHERE cliNome LIKE @pesquisar OR cliCPF LIKE @pesquisar";

                ClearParameters();
                AddParameters("@pesquisar", pesquisar + "%");
                return GetData(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddParametersCliente(Cliente cliente)
        {
            if (cliente.Id > 0)
            {
                AddParameters("@id", cliente.Id);
            }

            AddParameters("@cliCpf", cliente.CliCpf);
            AddParameters("@cliNome", cliente.CliNome);
            AddParameters("@cliEndereco", cliente.CliEndereco);
            AddParameters("@cliCidade", cliente.CliCidade);
            AddParameters("@cliBairro", cliente.CliBairro);
            AddParameters("@cliNumero", cliente.CliNumero);
            AddParameters("@cliTelefoneCelular", cliente.CliTelefoneCelular);
            AddParameters("@cliTelefoneFixo", cliente.CliTelefoneFixo);
        }

        protected override List<Cliente> GetObject(SqlDataReader objDataReader)
        {
            var lista = new List<Cliente>();

            while (objDataReader.Read())
            {
                var cliente = new Cliente();
                
                cliente.Id = objDataReader.GetReaderInt("Id");
                cliente.CliCpf = objDataReader.GetReaderString("cliCPF");
                cliente.CliNome = objDataReader.GetReaderString("cliNome");
                cliente.CliEndereco = objDataReader.GetReaderString("cliEndereco");
                cliente.CliCidade = objDataReader.GetReaderString("cliCidade");
                cliente.CliBairro = objDataReader.GetReaderString("cliBairro");
                cliente.CliNumero = objDataReader.GetReaderString("cliNumero");
                cliente.CliTelefoneCelular = objDataReader.GetReaderString("cliTelefoneCelular");
                cliente.CliTelefoneFixo = objDataReader.GetReaderString("cliTelefoneFixo");

                lista.Add(cliente);
            }

            return lista;
        }
    }
}
