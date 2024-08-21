using EmprestimoLivro.Application.Services;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmInterfaceMain : Form
    {
        private readonly ClienteService _clienteService;
        private readonly LivroService _livroService;
        private readonly Livro_Cliente_EmprestimoService _livro_Cliente_EmprestimoService;

        public FrmInterfaceMain(ClienteService clienteService, LivroService livroService, Livro_Cliente_EmprestimoService livro_Cliente_EmprestimoService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _livroService = livroService;
            _livro_Cliente_EmprestimoService = livro_Cliente_EmprestimoService;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmClienteMain frmClienteMain = new FrmClienteMain(_clienteService))
            {
                frmClienteMain.ShowDialog();
            }
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLivrosMain frmLivrosMain = new FrmLivrosMain(_livroService))
            {
                frmLivrosMain.ShowDialog();
            }
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmEmprestimoMain frmEmprestimoMain = new FrmEmprestimoMain(_livro_Cliente_EmprestimoService, _clienteService, _livroService))
            {
                frmEmprestimoMain.ShowDialog();
            }
        }
    }
}
