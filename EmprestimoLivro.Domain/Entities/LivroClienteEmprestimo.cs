using System;

namespace EmprestimoLivro.Domain.Entiteis
{
    public class LivroClienteEmprestimo
    {
        public int LceId { get; set; }
        public int LceIdCliente { get; set; }
        public int LceIdLivro { get; set; }
        public DateTime LceDataEmprestimo { get; set; }
        public DateTime LceDataEntrega { get; set; }
        public bool LceEntregue { get; set; }

        public virtual Cliente LceIdClienteNavigation { get; set; }
        public virtual Livro LceIdLivroNavigation { get; set; }
    }
}
