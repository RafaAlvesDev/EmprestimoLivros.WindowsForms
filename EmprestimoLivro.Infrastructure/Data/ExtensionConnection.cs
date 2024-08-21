using System;
using System.Data;
using System.Data.SqlClient;

namespace EmprestimoLivro.Infrastructure.Data
{
    public static class ExtensionConnection
    {
        public static string GetReaderString(this SqlDataReader objDataReader, string colunm)
        {
            DataTable table = objDataReader.GetSchemaTable();
            int index = objDataReader.GetOrdinal(colunm);

            foreach (DataRow row in table.Rows)
            {
                if (row["ColumnName"].ToString().Equals(colunm))
                {
                    return objDataReader.IsDBNull(index) ? "" : objDataReader.GetString(index);
                }
            }
            return string.Empty;
        }

        public static DateTime? GetReaderDateTime(this SqlDataReader objDataReader, string colunm)
        {
            DataTable table = objDataReader.GetSchemaTable();
            int index = objDataReader.GetOrdinal(colunm);

            foreach (DataRow row in table.Rows)
            {
                if (row["ColumnName"].ToString().Equals(colunm))
                {
                    return objDataReader.IsDBNull(index) ? (DateTime?)null : objDataReader.GetDateTime(index);
                }
            }

            return null;
        }

        public static int GetReaderInt(this SqlDataReader objDataReader, string colunm)
        {
            DataTable table = objDataReader.GetSchemaTable();
            int index = objDataReader.GetOrdinal(colunm);

            foreach (DataRow row in table.Rows)
            {
                if (row["ColumnName"].ToString().Equals(colunm))
                {
                    return objDataReader.IsDBNull(index) ? 0 : objDataReader.GetInt32(index);
                }
            }

            return 0;
        }

        public static bool GetReaderBoolean(this SqlDataReader objDataReader, string colunm)
        {
            DataTable table = objDataReader.GetSchemaTable();
            int index = objDataReader.GetOrdinal(colunm);

            foreach (DataRow row in table.Rows)
            {
                if (row["ColumnName"].ToString().Equals(colunm))
                {
                    return objDataReader.IsDBNull(index) ? false: objDataReader.GetBoolean(index);
                }
            }

            return false;
        }
    }
}
