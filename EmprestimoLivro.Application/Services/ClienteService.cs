using EmprestimoLivro.Application.UseCases;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Collections.Generic;

namespace EmprestimoLivro.Application.Services
{
    public class ClienteService
    {
        private readonly ClienteUseCase _clienteUseCase;

        public ClienteService(ClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                _clienteUseCase.Atualizar(cliente);
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
                return _clienteUseCase.Consultar(id);
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
                _clienteUseCase.Excluir(id);
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
                _clienteUseCase.Inserir(cliente);
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
                return _clienteUseCase.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
