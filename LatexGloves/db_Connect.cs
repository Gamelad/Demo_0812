using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatexGloves
{
    internal class db_Connect
    {
        /// <summary>
        /// строка для подключения
        /// </summary>
        public static string con = "Data Source = localhost; Initial Catalog = LatexGloves; Integrated Security = true";
        /// <summary>
        /// подключение к БД
        /// </summary>
        /// <returns>вход в БД</returns>
        public static SqlConnection SqlConnection()
        {
            return new SqlConnection(con);
        }
        /// <summary>
        /// метод для вызова данных
        /// </summary>
        /// <param name="sql">запрос</param>
        /// <returns>данные</returns>
        public static DataTable fromDB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SqlConnection());
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// метод для действий с данными
        /// </summary>
        /// <param name="sql">запрос</param>
        public static void toDB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SqlConnection());
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
