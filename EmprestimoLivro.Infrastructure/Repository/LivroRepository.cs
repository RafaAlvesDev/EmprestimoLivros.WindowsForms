using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Repository
{
    public class LivroRepository : DAOConection<Livro>, ILivroRepository
    {
        public void Atualizar(Livro livro)
        {
            try
            {
                strSQL = "UPDATE Livro  SET livroNome = @livroNome, livroAutor = @livroAutor, livroEditora = @livroEditora," +
                       "\r\n livroAnoPublicacao = @livroAnoPublicacao, livroEdicao = @livroEdicao"+
                       "\r\n WHERE id = @id";

                ClearParameters();
                AddParametersLivro(livro);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Livro Consultar(int id)
        {
            try
            {
                strSQL = "SELECT Id, livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao" +
                    "\r\n FROM Livro" +
                    "\r\n WHERE Id = @Id";

                ClearParameters();
                AddParameters("@Id", id);
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
                strSQL = "DELETE FROM Livro WHERE Id = @Id";

                ClearParameters();
                AddParameters("@id", id);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir(Livro livro)
        {
            try
            {
                strSQL = "INSERT INTO Livro (livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao)" +
                    "\r\n VALUES(@livroNome, @livroAutor, @livroEditora, @livroAnoPublicacao, @livroEdicao)";

                ClearParameters();
                AddParametersLivro(livro);
                ExecuteNonQueryTransaction(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Livro> Pesquisar(string pesquisar)
        {
            try
            {
                strSQL = "SELECT Id, livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao"+
                    "\r\n FROM Livro" +
                    "\r\n WHERE livroNome LIKE @pesquisar";

                ClearParameters();
                AddParameters("@pesquisar", pesquisar + "%");
                return GetData(CommandType.Text, strSQL);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddParametersLivro(Livro livro)
        {
            if (livro.Id > 0)
            {
                AddParameters("@id", livro.Id);
            }

            AddParameters("@livroNome", livro.LivroNome);
            AddParameters("@livroAutor", livro.LivroAutor);
            AddParameters("@livroEditora", livro.LivroEditora);
            AddParameters("@livroAnoPublicacao", livro.LivroAnoPublicacao);
            AddParameters("@livroEdicao", livro.LivroEdicao);
        }

        protected override List<Livro> GetObject(SqlDataReader objDataReader)
        {
            var lista = new List<Livro>();

            while (objDataReader.Read())
            {
                var livro = new Livro();

                livro.Id = objDataReader.GetReaderInt("Id");
                livro.LivroNome = objDataReader.GetReaderString("livroNome");
                livro.LivroAutor = objDataReader.GetReaderString("livroAutor");
                livro.LivroEditora = objDataReader.GetReaderString("livroEditora");
                livro.LivroAnoPublicacao = objDataReader.GetReaderDateTime("livroAnoPublicacao");
                livro.LivroEdicao = objDataReader.GetReaderString("livroEdicao");

                lista.Add(livro);
            }

            return lista;
        }
    }
}
