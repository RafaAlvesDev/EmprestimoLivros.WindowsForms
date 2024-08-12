using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Application.UseCases;
using EmprestimoLivro.Domain.Interface.Repository;
using EmprestimoLivro.Infrastructure.Repositorie;
using EmprestimoLivros.WindowsForms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            IClienteRepository _clienteRepository = new ClienteRepositorie();
            ClienteUseCase _clienteUseCase = new ClienteUseCase(_clienteRepository);
            ClienteService _clienteService = new ClienteService(_clienteUseCase);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInterfaceMain(_clienteService));
        }
    }
}
