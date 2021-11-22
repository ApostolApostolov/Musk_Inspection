using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Musk_Inspections
{
    public static class clsDB
    {
        public static class DBConnection
        {
            public static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " +
                                             "\"|DataDirectory|\\Musk_Inspections\\db_Musk.mdf\";";

            public static SqlConnection Connect()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }

            public static SqlCommand CreateCommand(string sql)
            {
                using (SqlConnection cn = Connect())
                {
                    return new SqlCommand(sql, cn);
                }
            }
        }

        public static DataTable Get_DataTable(string tableName)
        {
            using (SqlConnection cn =  DBConnection.Connect())
            {

                DbCommand command = DBConnection.CreateCommand("SELECT * FROM " + tableName);

                DbDataReader reader1 = command.ExecuteReader();

                DataTable table = new DataTable();

                if (reader1.Read())
                {
                    table.Load(reader1);
                }

                reader1.Close();

                return table;
            }
        }

        public static void Execute_SQL(string SQL_Text)
        {
            using (SqlConnection cn = DBConnection.Connect())
            {
                SqlCommand command = DBConnection.CreateCommand(SQL_Text);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                }
            }
        }

        public static DataRow Retrieve_Row(string tableName, int row)
        {
            using (SqlConnection cn = DBConnection.Connect())
            {
                DataTable table = Get_DataTable(tableName);

                try
                {
                    return table.Rows.Find(row);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static T Retrieve_Field<T>(string tableName, string column, int row)
        {
            using (SqlConnection cn = DBConnection.Connect())
            {
                DataTable table = Get_DataTable(tableName);

                try
                {
                    T data = table.Rows.Find(row).Field<T>(column);
                    return data;
                }
                catch (Exception e)
                {
                    return default;
                }
            }
        }

        public static byte[] Retrieve_BLOB(string tb, string column, int row)
        {
            using (SqlConnection c = DBConnection.Connect())
            {
                SqlCommand command = DBConnection.CreateCommand("SELECT " + column + " FROM " + tb + " WHERE id = " + row + ";");

                DbDataReader reader1 = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader1);

                try
                {
                    return table.Rows.Find(0).Field<byte[]>(column);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}