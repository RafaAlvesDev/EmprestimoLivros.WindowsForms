using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Application.UseCases;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Data;
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
            new DatabaseConfig().CreateTables();

            IClienteRepository _clienteRepository = new ClienteRepository();
            ClienteUseCase _clienteUseCase = new ClienteUseCase(_clienteRepository);
            ClienteService _clienteService = new ClienteService(_clienteUseCase);

            ILivroRepository _livroRepository = new LivroRepository();
            LivroUseCase _livroUseCase = new LivroUseCase(_livroRepository);
            LivroService _livroService = new LivroService(_livroUseCase);

            ILivro_Cliente_EmprestimoRepository _livro_Cliente_EmprestimoRepository = new Livro_Cliente_EmprestimoRepository();
            Livro_Cliente_EmprestimoUseCase _livro_Cliente_EmprestimoUseCase = new Livro_Cliente_EmprestimoUseCase(_livro_Cliente_EmprestimoRepository);
            Livro_Cliente_EmprestimoService _livro_Cliente_EmprestimoService = new Livro_Cliente_EmprestimoService(_livro_Cliente_EmprestimoUseCase);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInterfaceMain(_clienteService, _livroService, _livro_Cliente_EmprestimoService));
        }
    }
}
