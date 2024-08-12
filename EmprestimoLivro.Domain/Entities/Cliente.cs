using System.Collections.Generic;

namespace EmprestimoLivro.Domain.Entiteis
{
    public class Cliente
    {
        public Cliente ShallowCopy()
        {
            return (Cliente)this.MemberwiseClone();
        }

        public int Id { get; set; }
        public string CliCpf { get; set; }
        public string CliNome { get; set; }
        public string CliEndereco { get; set; }
        public string CliCidade { get; set; }
        public string CliBairro { get; set; }
        public string CliNumero { get; set; }
        public string CliTelefoneCelular { get; set; }
        public string CliTelefoneFixo { get; set; }
        
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; } = new List<LivroClienteEmprestimo>();
    }
}
