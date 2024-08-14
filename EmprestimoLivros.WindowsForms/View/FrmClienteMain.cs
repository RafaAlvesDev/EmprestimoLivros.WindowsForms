using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmClienteMain : Form
    {
        private readonly ClienteService _clienteService;

        public FrmClienteMain(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
        }

        private void Pesquisar()
        {
            try
            {
                dataGridViewCliente.DataSource = null;
                dataGridViewCliente.DataSource = _clienteService.Pesquisar(txtPesquisar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao pesquisar cliente.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClienteMain_Load(object sender, EventArgs e)
        {
            dataGridViewCliente.AutoGenerateColumns = false;
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void dataGridViewCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewCliente.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (FrmClienteScreen frmClienteScreen = new FrmClienteScreen(_clienteService, new Cliente(), true))
            {
                frmClienteScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente;
            using (FrmClienteScreen frmClienteScreen = new FrmClienteScreen(_clienteService, cliente.ShallowCopy(), false))
            {
                frmClienteScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show($"Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente cliente = dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente;

                if (MessageBox.Show($"Deseja realmente excluir o cliente {cliente.CliNome}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _clienteService.Excluir(cliente.Id);
                    MessageBox.Show($"Cliente {cliente.CliNome} excluído com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pesquisar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir cliente.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
