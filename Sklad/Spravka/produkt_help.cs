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
    public partial class produkt_help : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public produkt_help()
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

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provider_help form = new provider_help();
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
        private void produkt_help_Load(object sender, EventArgs e)
        {
            string script = "SELECT id_produkt as КОД, name_produkt as Название, unit_price_produkt as Цена, unit_produkt as Величина FROM view_produkt_help;";
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            SelectUnits();
            connection.Close();
        }
        // Добавление данных в бд
        private void ProductAddingButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            InsetrtProduct();
            connection.Close();
        }

        private void InsetrtProduct()
        {
            try
            {
                string unitProductSelectionQuery = $"select `id_unit_produkt` from `unit_produkt`" +
                $" where `unit_produkt_full` = '{NewProductUnits.SelectedItem}'";
                MySqlCommand selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex = Convert.ToInt32(selectionQuery.ExecuteScalar());

                string query = $"insert into `produkt_help` (name_produkt, id_unit_produkt, unit_price_produkt) " +
                    $"values ('{NewProductName.Text}', {unitIndex}, {Convert.ToSingle(NewProductPrice.Text)});";
                MySqlCommand insertProductCommand = new MySqlCommand(query, connection);
                insertProductCommand.ExecuteNonQuery();

                string script = "SELECT id_produkt as КОД, name_produkt as Название, unit_price_produkt as Цена, unit_produkt as Величина FROM view_produkt_help;";
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
        private void SelectUnits()
        {
            string query = "Select `unit_produkt_full` from `unit_produkt`;";
            MySqlCommand nameSelectionQuery = new MySqlCommand(query, connection);
            var reader = nameSelectionQuery.ExecuteReader();
            while (reader.Read())
            {
                NewProductUnits.Items.Add(reader["unit_produkt_full"]);
            }
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
                string sql = string.Format($"Delete from produkt_help where id_produkt = '{name}';");
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
            string script = "SELECT id_produkt as КОД, name_produkt as Название, unit_price_produkt as Цена, unit_produkt as Величина FROM view_produkt_help;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();

        }
    }
}
