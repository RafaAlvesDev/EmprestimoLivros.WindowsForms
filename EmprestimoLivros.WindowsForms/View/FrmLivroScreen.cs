using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmLivroScreen : Form
    {
        private readonly LivroService _livroService;
        private Livro _dataSourceSourceLivro = new Livro();
        BindingSource BindingSourceLivro = new BindingSource();
        private readonly bool _livroNovo;

        public FrmLivroScreen(LivroService livroService, Livro livro, bool livroNovo)
        {
            InitializeComponent();
            _livroService = livroService;
            _livroNovo = livroNovo;
            _dataSourceSourceLivro = livro;
        }

        private void SetBindingSource()
        {
            BindingSourceLivro.DataSource = _dataSourceSourceLivro;

            txtcliId.DataBindings.Add("Text", BindingSourceLivro, "Id", true, DataSourceUpdateMode.OnPropertyChanged, null, "D6");
            txtlivroNome.DataBindings.Add("Text", BindingSourceLivro, "livroNome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtlivroAutor.DataBindings.Add("Text", BindingSourceLivro, "livroAutor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtlivroEditora.DataBindings.Add("Text", BindingSourceLivro, "livroEditora", false, DataSourceUpdateMode.OnPropertyChanged);
            txtlivroEdicao.DataBindings.Add("Text", BindingSourceLivro, "livroEdicao", false, DataSourceUpdateMode.OnPropertyChanged);
            mskAnoPublicacao.DataBindings.Add("Text", BindingSourceLivro, "livroAnoPublicacao", true, DataSourceUpdateMode.OnValidation);
        }

        private void RefreshScreen()
        {
            BindingSourceLivro.ResetBindings(false);
        }

        private void FrmLivroScreen_Load(object sender, EventArgs e)
        {
            SetBindingSource();
            RefreshScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_livroNovo)
                {
                    _livroService.Inserir(_dataSourceSourceLivro);
                }
                else
                {
                    _livroService.Atualizar(_dataSourceSourceLivro);
                }

                MessageBox.Show("Livro salvo com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar livro.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
