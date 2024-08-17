using EmprestimoLivro.Application.Services;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmInterfaceMain : Form
    {
        private readonly ClienteService _clienteService;
        private readonly LivroService _livroService;

        public FrmInterfaceMain(ClienteService clienteService, LivroService livroService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _livroService = livroService;
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

        }
    }
}
