using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
   
       public class DatabaseHelper
        {
            // نص الاتصال - يفضل وضعه هنا لتغييره من مكان واحد فقط
            private string connectionString = @"Data Source=DESKTOP-GHA82A2\HUSINSERVER;Initial Catalog = mang; Integrated Security = True;";

            // دالة لجلب البيانات (تستخدم للـ Dashboard والـ DataGridView)
            public DataTable GetDataTable(string query)
            {
                DataTable dt = new DataTable();
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في جلب البيانات: " + ex.Message);
                }
                return dt;
            }

            // دالة لتنفيذ الأوامر (Insert, Update, Delete)
            public bool ExecuteCommand(string query)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تنفيذ الأمر: " + ex.Message);
                    return false;
                }
            }
       }
    
}
