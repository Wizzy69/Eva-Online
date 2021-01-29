using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eva_Online.Code
{
    public static class sqlConnection
    {
        public static string sqlConnectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public static SqlConnection con = new SqlConnection(sqlConnectionString);

        public static bool Start()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string[] FetchData(string query)
        {
            try
            {

                SqlDataAdapter SqlAD = new SqlDataAdapter();
                SqlAD.SelectCommand = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlAD.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count != 0)
                {
                    string[] arr = new string[dt.Rows[0].ItemArray.Length];

                    arr = InitializeArrays.InitStringArray(arr);


                    DataRow row = dt.Rows[0]; //first array

                    for (int i = 0; i < dt.Rows[0].ItemArray.Length; i++)
                    {
                        arr[i] = row[i].ToString();

                    }
                    return arr;
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return null;
        }

        public static int Execute(string query)
        {
            try
            {
                SqlCommand com = new SqlCommand(query, con);
                return com.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("MSSQL Error -> Function exec(" + query + "), exception catched : " + Ex.ToString());
                return 0;
            }
        }

        public static bool Login(bool profesor, string username, string password)
        {
            string table = string.Empty;
            table = profesor ? "Profesori" : "Elevi";
            string[] date = FetchData($"USE Intrebari select * from {table} where Username = '{username}' and Password = '{password}'");
            if (date == null || date.Length == 0)
                return false;
            return true;
        }
    }

    class InitializeArrays
    {
        public static string[] InitStringArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "";
            }
            return arr;
        }

        public static int[] InitIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        public static bool[] InitBoolArray(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = false;
            }
            return arr;
        }
    }
}
