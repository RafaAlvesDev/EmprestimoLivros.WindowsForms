using EmprestimoLivro.Application.Services;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmInterfaceMain : Form
    {
        private readonly ClienteService _clienteService;

        public FrmInterfaceMain(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
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
    }
}
