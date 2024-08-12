using System.Collections.Generic;

namespace EmprestimoLivro.Domain.Interface.Repository
{
    public interface IGenericRepository<T>
    {
        List<T> Pesquisar(string pesquisar);
        T Consultar(int id);
        void Inserir(T value);
        void Atualizar(T value);
        void Excluir(int id);
    }
}
