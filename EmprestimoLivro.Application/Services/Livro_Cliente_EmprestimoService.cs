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
    public class Livro_Cliente_EmprestimoService
    {
        private readonly Livro_Cliente_EmprestimoUseCase _livro_Cliente_EmprestimoUseCase;

        public Livro_Cliente_EmprestimoService(Livro_Cliente_EmprestimoUseCase livro_Cliente_Emprestimo)
        {
            _livro_Cliente_EmprestimoUseCase = livro_Cliente_Emprestimo;
        }

        public void Atualizar(Livro_Cliente_Emprestimo livro_Cliente_Emprestimo)
        {
            try
            {
                _livro_Cliente_EmprestimoUseCase.Atualizar(livro_Cliente_Emprestimo);
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
                return _livro_Cliente_EmprestimoUseCase.Consultar(lceId);
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
                _livro_Cliente_EmprestimoUseCase.Excluir(lceId);
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
                _livro_Cliente_EmprestimoUseCase.Inserir(livro_cliente_emprestimo);
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
                return _livro_Cliente_EmprestimoUseCase.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
