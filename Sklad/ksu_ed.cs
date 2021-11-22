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
    public partial class ksu_ed : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public ksu_ed()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        // Код позволяет загрузить данные в таблицу
        private void ksu_ed_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT id_ksu as Номер, name_produkt as Имя, id_produkt as Код_Продукта, unit_produkt as Единица, unit_price_produkt as Цена_за_ед FROM view_ksu_one;";
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
                string unitProductSelectionQuery = $"select `id_produkt` from `produkt_help`" +
               $" where `name_produkt` = '{comboBox1.SelectedItem}'";
                MySqlCommand selectionQuery = new MySqlCommand(unitProductSelectionQuery, connection);
                int unitIndex = Convert.ToInt32(selectionQuery.ExecuteScalar());

                string query = $"insert into `ksu_one` (id_produkt) " +
                    $"values ({unitIndex});";
                MySqlCommand insertProductCommand = new MySqlCommand(query, connection);
                insertProductCommand.ExecuteNonQuery();

                string script = "SELECT id_ksu as Номер, name_produkt as Имя, id_produkt as Код_Продукта, unit_produkt as Единица, unit_price_produkt as Цена_за_ед FROM view_ksu_one;";
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
                string sql = string.Format($"Delete from ksu_one where id_ksu = '{name}';");
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
            string script = "SELECT id_ksu as Номер, name_produkt as Имя, id_produkt as Код_Продукта, unit_produkt as Единица, unit_price_produkt as Цена_за_ед FROM view_ksu_one;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
        }
        // Переход на другие формы
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ksu form = new ksu();
            form.Visible = true;
            this.Visible = false;
        }
    }
}
