using System.Data;
using System.Data.Common;
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

        public static string GetReaderDate(this SqlDataReader objDataReader, string colunm)
        {
            DataTable table = objDataReader.GetSchemaTable();
            int index = objDataReader.GetOrdinal(colunm);

            foreach (DataRow row in table.Rows)
            {
                if (row["ColumnName"].ToString().Equals(colunm))
                {
                    return objDataReader.IsDBNull(index) ? "" : objDataReader.GetDateTime(index).ToShortDateString();
                }
            }

            return string.Empty;
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
    }
}
