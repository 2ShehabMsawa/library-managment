using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace library_managment.DAL
{
    internal class DBMethods
    {
        private static SqlConnection conn = new SqlConnection("server =.;DataBase = LDB;User Id=sa;Password=123456;");

        public static DataTable getData(string query, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameter != null)
                cmd.Parameters.AddRange(parameter);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static void implementQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.StoredProcedure;
            if (parameter != null )
                command.Parameters.AddRange(parameter);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void checkConnection()
        {
            try
            {
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
    
}
