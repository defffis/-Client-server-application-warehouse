using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sklad.Spravka;

namespace Sklad
{
    public partial class ttn : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public ttn()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        // Переход на другие формы
        private void главныйЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main form = new Main(this);
            form.Visible = true;
            this.Visible = false;

        }

        

        private void требованиенакладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ntn form = new ntn();
            form.Visible = true;
            this.Visible = false;

        }

        private void карточкаСкладскогоУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ksu form = new ksu();
            form.Visible = true;
            this.Visible = false;

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client_help form = new client_help();
            form.Visible = true;
            this.Visible = false;

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provider_help form = new provider_help();
            form.Visible = true;
            this.Visible = false;
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produkt_help form = new produkt_help();
            form.Visible = true;
            this.Visible = false;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            worker_help form = new worker_help();
            form.Visible = true;
            this.Visible = false;
        }

        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            country form = new country();
            form.Visible = true;
            this.Visible = false;
        }

        private void едИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unit_produkt form = new unit_produkt();
            form.Visible = true;
            this.Visible = false;
        }
        // Код позволяет загрузить данные в таблицу
        private void ttn_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT id_input_order as КОД, date_ttn as Дата, name_produkt as Продукт, input_produkt as Поступило, name_provider as Поставщик, id_ksu as КСУ, fio_worker as Работник FROM view_ttn;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            Select();
            connection.Close();
            dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            dateTimePicker1.Value = DateTime.Today;
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
                string unitProductSelectionQuery = $"Select `id_produkt` from `produkt_help`" +
                $" where `name_produkt` = '{comboBox1.SelectedItem}'";
                MySqlCommand selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex = Convert.ToInt32(selectionQuery.ExecuteScalar());

                unitProductSelectionQuery = $"Select `id_provider` from `provider_help`" +
                    $" where `name_provider` = '{comboBox2.SelectedItem}'";
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


                string query = $"insert into `ttn` (date_ttn, id_produkt, input_produkt, id_provider, id_ksu, id_worker) " +
                    $"values ('{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', {unitIndex}, {Convert.ToSingle(NewProductName.Text)}, {unitIndex2}, {unitIndex3}, {unitIndex4});";
                MySqlCommand insertProductCommand = new MySqlCommand(query, connection);
                insertProductCommand.ExecuteNonQuery();

                string script = "SELECT id_input_order as КОД, date_ttn as Дата, name_produkt as Продукт, input_produkt as Поступило, name_provider as Поставщик, id_ksu as КСУ, fio_worker as Работник FROM view_ttn;";
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
            string query = "Select `name_produkt` from `produkt_help`;";
            MySqlCommand nameSelectionQuery = new MySqlCommand(query, connection);
            var reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["name_produkt"]);
            }
            connection.Close();
            connection.Open();
            query = "Select `name_provider` from `provider_help`;";
            nameSelectionQuery = new MySqlCommand(query, connection);
            reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["name_provider"]);
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
                string name = _advancedDataGridViewSelectedRow.Cells[0].Value.ToString();
                string sql = string.Format($"Delete from ttn where id_input_order = '{name}';");
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
            string script = "SELECT id_input_order as КОД, date_ttn as Дата, name_produkt as Продукт, input_produkt as Поступило, name_provider as Поставщик, id_ksu as КСУ, fio_worker as Работник FROM view_ttn;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
