using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmEmprestimoMain : Form
    {
        private readonly Livro_Cliente_EmprestimoService _livro_Cliente_EmprestimoService;
        private readonly ClienteService _clienteService;
        private readonly LivroService _livroService;
      
        public FrmEmprestimoMain(Livro_Cliente_EmprestimoService livro_Cliente_EmprestimoService,
            ClienteService clienteService, LivroService livroService)
        {
            InitializeComponent();
            _livro_Cliente_EmprestimoService = livro_Cliente_EmprestimoService;
            _clienteService = clienteService;
            _livroService = livroService;
        }

        private void Pesquisar()
        {
            try
            {
                dataGridViewCliente.DataSource = null;
                dataGridViewCliente.DataSource = _livro_Cliente_EmprestimoService.Pesquisar(txtPesquisar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao pesquisar empréstimos.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (FrmEmprestimoScreen frmEmprestimoScreen = new FrmEmprestimoScreen(_livro_Cliente_EmprestimoService,
                _clienteService, _livroService, new Livro_Cliente_Emprestimo(), true))
            {
                frmEmprestimoScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Selecione um empréstimo para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Livro_Cliente_Emprestimo emprestimo = dataGridViewCliente.SelectedRows[0].DataBoundItem as Livro_Cliente_Emprestimo;

            using (FrmEmprestimoScreen frmEmprestimoScreen = new FrmEmprestimoScreen(_livro_Cliente_EmprestimoService,
                _clienteService, _livroService, emprestimo.ShallowCopy(), false))
            {
                frmEmprestimoScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show($"Selecione um empréstimo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Livro_Cliente_Emprestimo emprestimo = dataGridViewCliente.SelectedRows[0].DataBoundItem as Livro_Cliente_Emprestimo;

                if (MessageBox.Show($"Deseja realmente excluir o empréstimo número {emprestimo.LceId.ToString("D6")}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _livro_Cliente_EmprestimoService.Excluir(emprestimo.LceId);
                    MessageBox.Show($"Empréstimo {emprestimo.LceId.ToString("D6")} excluído com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pesquisar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir empréstimo.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
