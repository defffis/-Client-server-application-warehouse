using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad
{
    public partial class autorithation : Form, IRegistration
    {
        // Подключение бд
        public static MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=1234; database=mydb");
        DataTable datatable = new DataTable();

        public bool primary { get; set; }

        public void Con()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public autorithation()
        {
            Con();
            InitializeComponent();
        }

        // Проверка данных входа
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                ($"Select * from users where users_name = '{textBox1.Text}' and users_pass = '{textBox2.Text}'", connection);
                dataAdapter.Fill(datatable);
                if (datatable.Rows.Count == 1)
                {
                    primary = Convert.ToBoolean(datatable.Rows[0].ItemArray[3]);
                    Main form = new Main(this);
                    form.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Значение вне границ.");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Значение вне границ.");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Используеться слишком большое число.");
            }

            

        }

        private void autorithation_Load(object sender, EventArgs e)
        {
             

        }
    }
}
