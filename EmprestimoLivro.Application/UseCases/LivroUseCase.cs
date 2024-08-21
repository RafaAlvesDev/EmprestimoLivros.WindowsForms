using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivro.Application.UseCases
{
    public class LivroUseCase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroUseCase(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Atualizar(Livro livro)
        {
            try
            {
                _livroRepository.Atualizar(livro);
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
                return _livroRepository.Consultar(id);
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
                _livroRepository.Excluir(id);
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
                _livroRepository.Inserir(livro);
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
                return _livroRepository.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
