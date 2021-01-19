using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperWazeDAL
{
    public class RunQueriesOnDB
    {
        string connetionString = null;
        SqlConnection connection;
        SqlCommand command;

        public RunQueriesOnDB()
        {
            connetionString = @"Data Source=LAPTOP-0J363PR7\SQLEXPRESS;Initial Catalog=SupperWaze;Integrated Security=True";
            connection = new SqlConnection(connetionString);
        }
        public DataTable RunAnySqlQueryOnDB(string sqlQuery)
        {
            DataTable resultTable = new DataTable();
            try
            {
                connection.Open();
                command = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                resultTable.Load(sqlDataReader);
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            return resultTable;
            //public DataTable RunAnySqlQueryOnDB(string sqlQuery)
            //{
            //    DataTable resultTable = new DataTable();
            //    try
            //    {
            //        connection.Open();
            //        command = new SqlCommand(sqlQuery, connection);
            //        SqlDataReader dataReader = command.ExecuteReader();
            //        do
            //        {
            //            while (dataReader.Read())
            //                resultTable.Rows.Add((int)(dataReader[0]), dataReader[1].ToString(), (int)(dataReader[2]), (dataReader[3].ToString()), dataReader[4].ToString());
            //        }
            //        while (dataReader.NextResult());
            //        // resultTable.Load(command.ExecuteReader());
            //        command.Dispose();
            //        connection.Close();
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    return resultTable;
            //}
            //public List<object> RunAnySqlQueryOnDB(string sqlQuery)
            //{
            //    List<object> resultTable = new List<object>();
            //    SqlCommand command = new SqlCommand(sqlQuery, connection);

            //    connection.Open();
            //    SqlDataReader dataReader = command.ExecuteReader();
            //    do
            //    {
            //        while (dataReader.Read())
            //        {
            //            resultTable.Add(new Object[] { (dataReader[0]).ToString() });
            //        }
            //    }
            //    while (dataReader.NextResult());

            //    connection.Close();
            //    return resultTable;
            //}
        }

        public String RunSqlQueryAndReturnString(string sqlQuery)
        {
            String result="";
            try
            {
                connection.Open();
                command = new SqlCommand(sqlQuery, connection);
                result = command.ExecuteScalar().ToString();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
