using EmprestimoLivro.Application.UseCases;
using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivro.Application.Services
{
    public class LivroService
    {
        private readonly LivroUseCase _livroUseCase;

        public LivroService(LivroUseCase livroUseCase)
        {
            _livroUseCase = livroUseCase;
        }

        public void Atualizar(Livro livro)
        {
            try
            {
                _livroUseCase.Atualizar(livro);
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
                return _livroUseCase.Consultar(id);
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
                _livroUseCase.Excluir(id);
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
                _livroUseCase.Inserir(livro);
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
                return _livroUseCase.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
