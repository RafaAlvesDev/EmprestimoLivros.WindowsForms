using System;
using System.Collections.Generic;

namespace EmprestimoLivro.Domain.Entiteis
{
    public class Livro
    {
        public Livro ShallowCopy()
        {
            return (Livro)this.MemberwiseClone();

        }
        public int Id { get; set; }
        public string LivroNome { get; set; }
        public string LivroAutor { get; set; }
        public string LivroEditora { get; set; }
        public DateTime? LivroAnoPublicacao { get; set; }
        public string LivroEdicao { get; set; }

        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; } = new List<LivroClienteEmprestimo>();
    }
}
