using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;

namespace Firewatch
{
    /// <summary>
    /// Класс для доступа к БД
    /// </summary>
    public class Utils
    {
        /*В этом классе будет 2 метода и одна константа: строка подключения. Каждый участник проекта 
         *  скачает себе этот файл, изменит строку подключения на свою и добавит этот файл в .git ignore, 
         *  таким образом у каждого будет использоваться его строка подключения, но при этом при пуше или пуле проекта,
         *  эта переменная не будет меняться. 
         *  Еще важный момент - надо чтобы у всех были одинаковые названия таблиц и столбцов в БД, 
         *  чтобы передавая запрос, он работал у всхех */
        static SqlConnection conn = new SqlConnection("");
        public DataTable Select(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                //ну фигово че
            }
            conn.Close();
            return dt;
        }
        public void NonQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //ну фигово че
            }
            conn.Close();
        }
    }
}
