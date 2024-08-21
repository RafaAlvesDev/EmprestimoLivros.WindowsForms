using EmprestimoLivro.Domain.Interface.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Data
{
    public abstract class DAOConection<T> : IConnection<T> 
    {
        protected abstract List<T> GetObject(SqlDataReader objDataReader);
        private readonly string _connectionString;
        private readonly SqlParameterCollection _parameters;
        public string strSQL;

        public DAOConection()
        {
            _connectionString = ConectionStringBD.GetConectionString();
            _parameters = new SqlCommand().Parameters;
        }

        public void AddParameters(string parameterName, object valueparameters)
        {
            if (valueparameters == null)
            {
                _parameters.AddWithValue(parameterName, DBNull.Value);
                return;
            }

            _parameters.AddWithValue(parameterName, valueparameters);
        }

        public void ClearParameters()
        {
            _parameters.Clear();
        }

        public void ExecuteNonQueryTransaction(CommandType tipo, string sql)
        {
            if (_connectionString == null)
            {
                throw new Exception("Falha na string de conexão do banco de dados.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.CommandType = tipo;
                            command.CommandText = sql;
                            command.Connection = connection;
                            command.Transaction = transaction;

                            foreach (DbParameter parameter in _parameters)
                            {
                                command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                            }

                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public Object ExecuteScalarTransaction(CommandType tipo, string sql)
        {
            if (_connectionString == null)
            {
                throw new Exception("Falha na string de conexão do banco de dados.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<T> listObject = new List<T>();
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.CommandType = tipo;
                            command.CommandText = sql;
                            command.Connection = connection;
                            command.Transaction = transaction;

                            foreach (DbParameter parameter in _parameters)
                            {
                                command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                            }

                            var data = command.ExecuteScalar();
                            transaction.Commit();
                            return data;
                        }

                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public T GetObject(CommandType tipo, string sql)
        {
            List<T> listObject = new List<T>();

            if (_connectionString == null)
            {
                throw new Exception("Falha na string de conexão do banco de dados.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = tipo;
                        command.CommandText = sql;
                        command.Connection = connection;

                        foreach (DbParameter parameter in _parameters)
                        {
                            command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                        }

                        using (SqlDataReader objDataReader = command.ExecuteReader())
                        {
                            if (objDataReader.HasRows)
                            {
                                listObject = GetObject(objDataReader);
                            }
                        }

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            if (listObject.Count > 0)
            {
                return listObject[0];
            }

            return default(T);
        }

        public List<T> GetData(CommandType tipo, string sql)
        {
            List<T> listObject = new List<T>();

            if (_connectionString == null)
            {
                throw new Exception("Falha na string de conexão do banco de dados.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = tipo;
                        command.CommandText = sql;
                        command.Connection = connection;

                        foreach (DbParameter parameter in _parameters)
                        {
                            command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                        }

                        using (SqlDataReader objDataReader = command.ExecuteReader())
                        {
                            if (objDataReader.HasRows)
                            {
                                listObject = GetObject(objDataReader);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return listObject;
        }
    }
}
