using System;
using System.Collections.Generic;
using System.Data;

namespace EmprestimoLivro.Domain.Interface.Connection
{
    public interface IConnection<T>
    {
        void ClearParameters();
        void AddParameters(string parameterName, object valueparameters);
        void ExecuteNonQueryTransaction(CommandType tipo, string sql);
        Object ExecuteScalarTransaction(CommandType tipo, string sql);
        T GetObject(CommandType tipo, string sql);
        List<T> GetData(CommandType tipo, string sql);
    }
}
