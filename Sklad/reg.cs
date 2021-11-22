using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sklad
{
    public partial class reg : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public reg()
        {
            InitializeComponent();
            primary = true;
        }
        int id = 1;

        public bool primary { get; set; }
        // Добавление данных в бд
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("reg", autorithation.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_idusers", id);
                command.Parameters.AddWithValue("_users_name", textBox1.Text);
                command.Parameters.AddWithValue("_users_pass", textBox2.Text);
                command.Parameters.AddWithValue("_users_primary", textBox3.Text);

                command.ExecuteNonQuery();
                string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
                string script = "SELECT idusers as Код, users_name as Имя, users_pass as Пароль, users_primary Доступ FROM users;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
                DataTable table = new DataTable();
                mySql_dataAdapter.Fill(table);
                advancedDataGridView1.DataSource = table;
                connection.Close();
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
        // Код позволяет загрузить данные в таблицу
        private void reg_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT idusers as Код, users_name as Имя, users_pass as Пароль, users_primary Доступ FROM users;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }
        // Переход на другие формы
        private void наГлавнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main form = new Main(this);
            form.Visible = true;
            this.Visible = false;
        }
        // Удаление выделенной строки
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (advancedDataGridView1.SelectedRows.Count > 0)
            {
                _advancedDataGridViewSelectedRow = advancedDataGridView1.SelectedRows[0];
                string name = _advancedDataGridViewSelectedRow.Cells[1].Value.ToString();
                string sql = string.Format($"Delete from users where users_name = '{name}';");
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmdSel.ExecuteNonQuery();
                        advancedDataGridView1.Refresh(); 
                    }
                    catch (MySqlException ex)
                    {
                        Exception error = new Exception("Уже удалено", ex);
                        throw error;
                    }
                }
            }
            string script = "SELECT idusers as Код, users_name as Имя, users_pass as Пароль, users_primary Доступ FROM users;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }

        private void advancedDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
