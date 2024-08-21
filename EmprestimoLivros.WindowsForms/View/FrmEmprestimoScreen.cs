using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmEmprestimoScreen : Form
    {
        private readonly Livro_Cliente_EmprestimoService _livro_Cliente_EmprestimoService;
        private readonly ClienteService _clienteService;
        private readonly LivroService _livroService;
        private Livro_Cliente_Emprestimo _dataSourceSourceEmprestimo = new Livro_Cliente_Emprestimo();
        BindingSource BindingSourceEmprestimo = new BindingSource();
        private readonly bool _emprestimoNovo;

        public FrmEmprestimoScreen(Livro_Cliente_EmprestimoService livro_Cliente_EmprestimoService, ClienteService clienteService,
             LivroService livroService, Livro_Cliente_Emprestimo livro, bool emprestimoNovo)
        {
            InitializeComponent();
            _livro_Cliente_EmprestimoService = livro_Cliente_EmprestimoService;
            _emprestimoNovo = emprestimoNovo;
            _clienteService = clienteService;
            _livroService = livroService;
            _dataSourceSourceEmprestimo = livro;

            txtLceIdCliente.KeyPress += TextBoxEvent_KeyPress;
            txtLceIdLivro.KeyPress += TextBoxEvent_KeyPress;
        }

        private void SetBindingSource()
        {
            BindingSourceEmprestimo.DataSource = _dataSourceSourceEmprestimo;

            txtLceId.DataBindings.Add("Text", BindingSourceEmprestimo, "LceId", true, DataSourceUpdateMode.OnPropertyChanged, null, "D6");
            txtLceIdCliente.DataBindings.Add("Text", BindingSourceEmprestimo, "LceIdCliente", true, DataSourceUpdateMode.OnPropertyChanged, null, "D6");
            txtCliNome.DataBindings.Add("Text", BindingSourceEmprestimo, "CliNome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtLceIdLivro.DataBindings.Add("Text", BindingSourceEmprestimo, "LceIdLivro", true, DataSourceUpdateMode.OnPropertyChanged, null, "D6");
            txtLivroNome.DataBindings.Add("Text", BindingSourceEmprestimo, "LivroNome", false, DataSourceUpdateMode.OnPropertyChanged);
            mskLceDataEmprestimo.DataBindings.Add("Text", BindingSourceEmprestimo, "LceDataEmprestimo", false, DataSourceUpdateMode.OnPropertyChanged);
            mskLceDataEntrega.DataBindings.Add("Text", BindingSourceEmprestimo, "LceDataEntrega", false, DataSourceUpdateMode.OnPropertyChanged);
            chbEntregue.DataBindings.Add("Checked", BindingSourceEmprestimo, "LceEntregue", true, DataSourceUpdateMode.OnValidation);

        }

        private void RefreshScreen()
        {
            BindingSourceEmprestimo.ResetBindings(false);
        }

        private void FrmLivroScreen_Load(object sender, EventArgs e)
        {
            SetBindingSource();
            _dataSourceSourceEmprestimo.LceDataEmprestimo = DateTime.Now;
            RefreshScreen();
            ActiveControl = txtLceIdCliente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_emprestimoNovo)
                {
                    _livro_Cliente_EmprestimoService.Inserir(_dataSourceSourceEmprestimo);
                }
                else
                {
                    _livro_Cliente_EmprestimoService.Atualizar(_dataSourceSourceEmprestimo);
                }

                MessageBox.Show("Empréstimo salvo com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar empréstimo.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLceIdCliente.Text) || Convert.ToInt32(txtLceIdCliente.Text) == 0)
                {
                    MessageBox.Show("Informe o código do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cliente cliente = _clienteService.Consultar(Convert.ToInt32(txtLceIdCliente.Text));

                if (cliente == null)
                {
                    MessageBox.Show("Cliente não localizado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLceIdCliente.Focus();
                    return;
                }

                _dataSourceSourceEmprestimo.CliNome = cliente.CliNome;
                txtLceIdLivro.Focus();
                RefreshScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao localizar o cliente.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesqLivro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLceIdLivro.Text) || Convert.ToInt32(txtLceIdLivro.Text) == 0)
                {
                    MessageBox.Show("Informe o código do livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Livro livro = _livroService.Consultar(Convert.ToInt32(txtLceIdLivro.Text));

                if (livro == null)
                {
                    MessageBox.Show("Livro não localizado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLceIdLivro.Focus();
                    return;
                }

                _dataSourceSourceEmprestimo.LivroNome = livro.LivroNome;
                mskLceDataEmprestimo.Focus();
                RefreshScreen();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao localizar o livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLceIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesqCliente.PerformClick();
            }
        }

        private void txtLceIdCliente_Leave(object sender, EventArgs e)
        {
            btnPesqCliente.PerformClick();
        }
    }
}
