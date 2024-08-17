using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Application.UseCases;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Repository;
using EmprestimoLivros.WindowsForms.View;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IClienteRepository _clienteRepository = new ClienteRepository();
            ClienteUseCase _clienteUseCase = new ClienteUseCase(_clienteRepository);
            ClienteService _clienteService = new ClienteService(_clienteUseCase);

            ILivroRepository _livroRepository = new LivroRepository();
            LivroUseCase _livroUseCase = new LivroUseCase(_livroRepository);
            LivroService _livroService = new LivroService(_livroUseCase);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInterfaceMain(_clienteService, _livroService));
        }
    }
}
