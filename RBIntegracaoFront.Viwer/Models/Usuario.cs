
using RBIntegracaoFront.Viwer.Enums;

namespace RBIntegracaoFront.Viwer.Models
{
    public class Usuario
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CnpjCpf { get; set; }
        public EnumClienteOuFornecedor ClienteOuFornecedor { get; set; }
    }
}
