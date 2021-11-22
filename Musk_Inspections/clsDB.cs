using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace SQL_Interface_Test._classes
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

        public enum ConnectionType {MySql, Local}

        // DB names
        public static string nm_DB_Local = "db_Local";
        public static string nm_DB_MySQL = "msql_DB_1";
        public static string nm_DB_Current = nm_DB_Local;

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

        
        public static string Retrieve_Data(string SQL_Text)
        {
            using (SqlConnection cn = DBConnection.Connect())
            {
                SqlCommand command = DBConnection.CreateCommand(SQL_Text);

                DbDataReader reader1 = command.ExecuteReader();

                DataTable table = new DataTable();
                    table.Load(reader1);

                try
                {
                    return table.Rows.Find(0).Field<string>("bin");
                }
                catch (Exception e)
                {
                    return e.Message;
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