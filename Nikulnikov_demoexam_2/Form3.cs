using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikulnikov_demoexam_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection();

        }

        private void Form3_Load(object sender, EventArgs e) {
            //подключение к локальному серверу на SQL Server Management Studio
            string connectionString = "Data Source=DESKTOP-G7LMSC7;Initial Catalog=Никульников;Integrated Security=True;Encrypt=False";
            //извлечение таблицы из БД
            string query = "SELECT * FROM [Partners_import$]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                var partner_1_ID = 1;
                var partner_2_ID = 2;
                var partner_3_ID = 3;
                var partner1 = partner_1_ID --;
                var partner2 = partner_2_ID --;
                var partner3 = partner_3_ID --;

                typeLabel1.Text = Convert.ToString(dataTable.Rows[partner1]["Тип_партнера"]);
                nameLabel1.Text = Convert.ToString(dataTable.Rows[partner1]["Наименование_партнера"]);
                directorLabel1.Text = Convert.ToString(dataTable.Rows[partner1]["Директор"]);
                phoneLabel1.Text = phoneLabel1.Text + Convert.ToString(dataTable.Rows[partner1]["Телефон_партнера"]);
                scoreLabel1.Text = Convert.ToString(dataTable.Rows[partner1]["Рейтинг"]);

                typeLabel2.Text = Convert.ToString(dataTable.Rows[partner2]["Тип_партнера"]);
                nameLabel2.Text = Convert.ToString(dataTable.Rows[partner2]["Наименование_партнера"]);
                directorLabel2.Text = Convert.ToString(dataTable.Rows[partner2]["Директор"]);
                phoneLabel2.Text = phoneLabel2.Text + Convert.ToString(dataTable.Rows[partner2]["Телефон_партнера"]);
                scoreLabel2.Text = Convert.ToString(dataTable.Rows[partner2]["Рейтинг"]);

                typeLabel3.Text = Convert.ToString(dataTable.Rows[partner3]["Тип_партнера"]);
                nameLabel3.Text = Convert.ToString(dataTable.Rows[partner3]["Наименование_партнера"]);
                directorLabel3.Text = Convert.ToString(dataTable.Rows[partner3]["Директор"]);
                phoneLabel3.Text = phoneLabel3.Text + Convert.ToString(dataTable.Rows[partner3]["Телефон_партнера"]);
                scoreLabel3.Text = Convert.ToString(dataTable.Rows[partner3]["Рейтинг"]);

            }
        }
    }
}
