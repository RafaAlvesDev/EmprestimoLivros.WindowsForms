using System;

namespace EmprestimoLivro.Domain.Entiteis
{
    public class Livro_Cliente_Emprestimo
    {
        public Livro_Cliente_Emprestimo ShallowCopy()
        {
            return (Livro_Cliente_Emprestimo)this.MemberwiseClone();
        }

        public int LceId { get; set; }
        public int LceIdCliente { get; set; }
        public int LceIdLivro { get; set; }
        public DateTime? LceDataEmprestimo { get; set; }
        public DateTime? LceDataEntrega { get; set; }
        public bool LceEntregue { get; set; }

        public string CliNome { get; set; }
        public string LivroNome { get; set; }

        public string CodigoNomeCliente
        {
            get { return LceIdCliente.ToString("D6") + " - " + CliNome; }
            private set { }
        }

        public string CodigoNomeLivro
        {
            get { return LceIdLivro.ToString("D6") + " - " + LivroNome; }
            private set { }
        }
    }
}
