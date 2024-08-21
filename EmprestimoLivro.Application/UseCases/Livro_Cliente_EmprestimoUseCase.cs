using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using System.Collections.Generic;
using System;

namespace EmprestimoLivro.Application.UseCases
{
    public class Livro_Cliente_EmprestimoUseCase
    {
        private readonly ILivro_Cliente_EmprestimoRepository _livro_Cliente_Emprestimo;

        public Livro_Cliente_EmprestimoUseCase(ILivro_Cliente_EmprestimoRepository livro_Cliente_Emprestimo)
        {
            _livro_Cliente_Emprestimo = livro_Cliente_Emprestimo;
        }

        public void Atualizar(Livro_Cliente_Emprestimo livro_cliente_emprestimo)
        {
            try
            {
                ValidateObject(livro_cliente_emprestimo);
                _livro_Cliente_Emprestimo.Atualizar(livro_cliente_emprestimo);
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
                return _livro_Cliente_Emprestimo.Consultar(lceId);
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
                _livro_Cliente_Emprestimo.Excluir(lceId);
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
                ValidateObject(livro_cliente_emprestimo);

                _livro_Cliente_Emprestimo.Inserir(livro_cliente_emprestimo);
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
                return _livro_Cliente_Emprestimo.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidateObject(Livro_Cliente_Emprestimo livro_cliente_emprestimo)
        {
            string msg = null;
            DateTime dataParaVerificar = new DateTime(1975, 1, 1);

            if (livro_cliente_emprestimo.LceIdCliente.Equals(0))
            {
                msg += "\r\n - Informe o cliente.";
            }

            if (livro_cliente_emprestimo.LceIdLivro.Equals(0))
            {
                msg += "\r\n - Informe o livro.";
            }

            if (dataParaVerificar.CompareTo(livro_cliente_emprestimo.LceDataEmprestimo) > 0)
            {
                msg += "\r\n - Data de empréstimo inválida.";
            }

            if (dataParaVerificar.CompareTo(livro_cliente_emprestimo.LceDataEntrega)  > 0)
            {
                msg += "\r\n - Data de entrega inválida.";
            }

            if (msg != null)
            {
                throw new Exception("Informações inválidas, verifique:" + msg);
            }
        }
    }
}