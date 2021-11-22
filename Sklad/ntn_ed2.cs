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
    public partial class ntn_ed2 : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public ntn_ed2()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        // Переход на другие формы
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ntn form = new ntn();
            form.Visible = true;
            this.Visible = false;
        }
        // Код позволяет загрузить данные в таблицу
        private void ntn_ed2_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT id_ntn as КОД, name_produkt as Продукт, id_ksu as КСУ, requested as Запрошено, released as Реализовано, fio_worker as Работник FROM view_ntn_two;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            Select();
            connection.Close();
            
        }
        // Добавление данных в бд
        private void ProductAddingButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            Insetrt();
            connection.Close();
        }
        private void Insetrt()
        {
            try
            {
                string unitProductSelectionQuery = $"Select `id_ntn` from `ntn_one`" +
                $" where `id_ntn` = '{comboBox1.SelectedItem}'";
                MySqlCommand selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex = Convert.ToInt32(selectionQuery.ExecuteScalar());

                unitProductSelectionQuery = $"Select `id_produkt` from `produkt_help`" +
                    $" where `name_produkt` = '{comboBox2.SelectedItem}'";
                selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex2 = Convert.ToInt32(selectionQuery.ExecuteScalar());

                unitProductSelectionQuery = $"Select `id_ksu` from `ksu_one`" +
                    $" where `id_ksu` = '{comboBox3.SelectedItem}'";
                selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex3 = Convert.ToInt32(selectionQuery.ExecuteScalar());

                unitProductSelectionQuery = $"Select `id_worker` from `worker_help`" +
                    $" where `fio_worker` = '{comboBox4.SelectedItem}'";
                selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex4 = Convert.ToInt32(selectionQuery.ExecuteScalar());


                string query = $"insert into `ntn_two` (id_ntn, id_produkt, id_ksu, id_worker, requested, released) " +
                    $"values ({unitIndex}, {unitIndex2}, {unitIndex3}, {unitIndex4}, {Convert.ToSingle(textBox1.Text)}, {Convert.ToSingle(NewProductName.Text)});";
                MySqlCommand insertProductCommand = new MySqlCommand(query, connection);
                insertProductCommand.ExecuteNonQuery();

                string script = "SELECT id_ntn as КОД, name_produkt as Продукт, id_ksu as КСУ, requested as Запрошено, released as Реализовано, fio_worker as Работник FROM view_ntn_two;";
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
                DataTable table = new DataTable();
                mySql_dataAdapter.Fill(table);
                advancedDataGridView1.DataSource = table;
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
        // Загрузка данных из бд в combobox
        private new void Select()
        {

            connection.Open();
            string query = "Select `id_ntn` from `ntn_one`;";
            MySqlCommand nameSelectionQuery = new MySqlCommand(query, connection);
            var reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["id_ntn"]);
            }
            connection.Close();
            connection.Open();
            query = "Select `name_produkt` from `produkt_help`;";
            nameSelectionQuery = new MySqlCommand(query, connection);
            reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["name_produkt"]);
            }
            connection.Close();
            connection.Open();
            query = "Select `id_ksu` from `ksu_one`;";
            nameSelectionQuery = new MySqlCommand(query, connection);
            reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox3.Items.Add(reader["id_ksu"]);
            }
            connection.Close();
            connection.Open();
            query = "Select `fio_worker` from `worker_help`;";
            nameSelectionQuery = new MySqlCommand(query, connection);
            reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader["fio_worker"]);
            }
            connection.Close();
        }
        // Удаление выделенной строки
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            if (advancedDataGridView1.SelectedRows.Count > 0)
            {
                _advancedDataGridViewSelectedRow = advancedDataGridView1.SelectedRows[0];
                string name = _advancedDataGridViewSelectedRow.Cells[3].Value.ToString();
                string sql = string.Format($"Delete from ntn_two where requested = '{name}';");
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
            string script = "SELECT id_ntn as КОД, name_produkt as Продукт, id_ksu as КСУ, requested as Запрошено, released as Реализовано, fio_worker as Работник FROM view_ntn_two;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
