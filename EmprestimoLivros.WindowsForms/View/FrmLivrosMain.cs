using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmLivrosMain : Form
    {
        private readonly LivroService _livroService;

        public FrmLivrosMain(LivroService livroService)
        {
            InitializeComponent();
            _livroService = livroService;
        }

        private void Pesquisar()
        {
            try
            {
                dataGridViewLivro.DataSource = null;
                dataGridViewLivro.DataSource = _livroService.Pesquisar(txtPesquisar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao pesquisar livro.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLivrosMain_Load(object sender, EventArgs e)
        {
            dataGridViewLivro.AutoGenerateColumns = false;
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

        private void dataGridViewLivro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewLivro.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (FrmLivroScreen frmLivroScreen = new FrmLivroScreen(_livroService, new Livro(), true))
            {
                frmLivroScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivro.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Selecione um livro para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Livro livro = dataGridViewLivro.SelectedRows[0].DataBoundItem as Livro;
            using (FrmLivroScreen frmLivroScreen = new FrmLivroScreen(_livroService, livro.ShallowCopy(), false))
            {
                frmLivroScreen.ShowDialog();
            }

            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivro.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show($"Selecione um livro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Livro livro = dataGridViewLivro.SelectedRows[0].DataBoundItem as Livro;

                if (MessageBox.Show($"Deseja realmente excluir o livro {livro.LivroNome}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _livroService.Excluir(livro.Id);
                    MessageBox.Show($"Livro {livro.LivroNome} excluído com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pesquisar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir livro.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
