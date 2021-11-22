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

namespace Sklad.Spravka
{
    public partial class provider_help : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public provider_help()
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

        private void товарнотранспортнаяНакладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttn form = new ttn();
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
        private void provider_help_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT id_provider as КОД, name_provider as Название, country_name_max as Страна FROM view_provider_help;";
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
                string unitProductSelectionQuery = $"select `id_country` from `country`" +
                $" where `country_name_max` = '{comboBox1.SelectedItem}'";
                MySqlCommand selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex = Convert.ToInt32(selectionQuery.ExecuteScalar());

                string query = $"insert into `provider_help` (name_provider, id_country) " +
                    $"values ('{NewProductName.Text}', {unitIndex});";
                MySqlCommand insertProductCommand = new MySqlCommand(query, connection);
                insertProductCommand.ExecuteNonQuery();

                string script = "SELECT id_provider as КОД, name_provider as Название, country_name_max as Страна FROM view_provider_help;";
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
            string query = "Select `country_name_max` from `country`;";
            MySqlCommand nameSelectionQuery = new MySqlCommand(query, connection);
            var reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["country_name_max"]);
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
                string sql = string.Format($"Delete from provider_help where id_provider = '{name}';");
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
            string script = "SELECT id_provider as КОД, name_provider as Название, country_name_max as Страна FROM view_provider_help;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
