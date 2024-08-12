using EmprestimoLivro.Domain.Entiteis;
using EmprestimoLivro.Domain.Interface.Repository;
using System.Collections.Generic;
using System;

namespace EmprestimoLivro.Application.UseCases
{
    public class ClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                if (cliente is Cliente == false || cliente.Id.Equals(0))
                {
                    throw new Exception("Cliente não encontrado para atualizar");
                }

                if (string.IsNullOrEmpty(cliente.CliCpf))
                {
                    throw new Exception("Informe o CPF do cliente.");
                }

                if (cliente.CliCpf.Length < 14)
                {
                    throw new Exception("CPF do cliente inválido.");
                }

                if (string.IsNullOrEmpty(cliente.CliNome) || cliente.CliNome.Length < 3)
                {
                    throw new Exception("Informe o nome do cliente.");
                }

                _clienteRepository.Atualizar(cliente);  
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
                if (id.Equals(0))
                {
                    throw new Exception("Cliente não encontrado para consultar.");

                }
                return _clienteRepository.Consultar(id);
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
                if (id.Equals(0))
                {
                    throw new Exception("Cliente não encontrado para excluir");
                }

                _clienteRepository.Excluir(id);
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
                if (cliente is Cliente == false)
                {
                    throw new Exception("Cliente não informado para inserir");
                }

                if (string.IsNullOrEmpty(cliente.CliCpf) || cliente.CliCpf.Length < 14)
                {
                    throw new Exception("Informe o CPF do cliente.");
                }

                if (string.IsNullOrEmpty(cliente.CliNome) || cliente.CliNome.Length < 3)
                {
                    throw new Exception("Informe o nome do cliente.");
                }

                _clienteRepository.Inserir(cliente);
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
                return _clienteRepository.Pesquisar(pesquisar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
