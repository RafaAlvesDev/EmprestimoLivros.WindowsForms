using EmprestimoLivro.Application.Services;
using EmprestimoLivro.Domain.Entiteis;
using System;
using System.Windows.Forms;

namespace EmprestimoLivros.WindowsForms.View
{
    public partial class FrmClienteScreen : Form
    {
        private readonly ClienteService _clienteService;
        private Cliente _dataSourceSourceCliente = new Cliente();
        BindingSource BindingSourceCliente = new BindingSource();
        private readonly bool _clienteNovo;

        public FrmClienteScreen(ClienteService clienteService, Cliente cliente, bool clienteNovo)
        {
            InitializeComponent();
            _clienteService = clienteService;
            _clienteNovo = clienteNovo;
            _dataSourceSourceCliente = cliente;
        }

        private void SetBindingSource()
        {
            BindingSourceCliente.DataSource = _dataSourceSourceCliente;

            txtcliId.DataBindings.Add("Text", BindingSourceCliente, "Id", true, DataSourceUpdateMode.OnPropertyChanged, null, "D6");
            txtcliNome.DataBindings.Add("Text", BindingSourceCliente, "CliNome", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliCPF.DataBindings.Add("Text", BindingSourceCliente, "CliCpf", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliEndereco.DataBindings.Add("Text", BindingSourceCliente, "CliEndereco", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliCidade.DataBindings.Add("Text", BindingSourceCliente, "CliCidade", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliBairro.DataBindings.Add("Text", BindingSourceCliente, "CliBairro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliNumero.DataBindings.Add("Text", BindingSourceCliente, "CliNumero", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliTelefoneFixo.DataBindings.Add("Text", BindingSourceCliente, "CliTelefoneFixo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtcliTelefoneCelular.DataBindings.Add("Text", BindingSourceCliente, "CliTelefoneCelular", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void RefreshScreen()
        {
            BindingSourceCliente.ResetBindings(false);
        }

        private void FrmClienteScreen_Load(object sender, EventArgs e)
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
                if (_clienteNovo)
                {
                    _clienteService.Inserir(_dataSourceSourceCliente);
                }
                else
                {
                    _clienteService.Atualizar(_dataSourceSourceCliente);
                }

                MessageBox.Show("Cliente salvo com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar cliente.\r\nMotivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
