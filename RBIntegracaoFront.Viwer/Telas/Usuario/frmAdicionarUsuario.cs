using RBIntegracaoFront.Viwer.Enums;
using RBIntegracaoFront.Viwer.Services;
using System;
using System.Windows.Forms;

namespace RBIntegracaoFront.Viwer.Usuario
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
        }

        public void SalvarUsuario()
        {
            var usuario = new Models.Usuario();

            usuario.RazaoSocial = txtRacaoSocial.Text;
            usuario.NomeFantasia = txtNomeFantasia.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.CnpjCpf = txtCpjCnpj.Text;
            usuario.ClienteOuFornecedor = (EnumClienteOuFornecedor)cmbTipo.SelectedIndex;

            var service = new ServiceUsuario();

            var retorno = service.AdicionarUsuario(usuario);
        }
    }
}
