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
using Sklad.Spravka;

namespace Sklad
{
    public partial class ksu : Form, IRegistration
    {
        // Подключение бд
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";

        public ksu()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        // Код позволяет загрузить данные в таблицу
        private void ksu_Load(object sender, EventArgs e)
        {
            string script = "SELECT id_ksu as Номер, name_produkt as Имя, id_produkt as Код_Продукта, unit_produkt as Единица, unit_price_produkt as Цена_за_ед FROM view_ksu_one;";
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();
            string script1 = "SELECT ntn_date as Дата, id_input_order as Код_Прихода, id_ntn as Код_Расхода, aaa as Поставщик, name_client as Клиент, input_produkt as Поступило, released as Реализовано, balance as Остаток, total_price as Итого, bid_ksu as Номер FROM view_ksu_two;";
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter1 = new MySqlDataAdapter(script1, connection);
            DataTable table1 = new DataTable();
            mySql_dataAdapter1.Fill(table1);
            advancedDataGridView2.DataSource = table1;
            SelectProductsNames();
            connection.Close();
        }

        private void SelectProductsNames()
        {
            
        }
        // Поиск
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_ksu as Номер, name_produkt as Имя, id_produkt as Код_Продукта, unit_produkt as Единица, unit_price_produkt as Цена_за_ед FROM view_ksu_one WHERE id_ksu LIKE '%" + textBox1.Text + "%'", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.advancedDataGridView1.AutoGenerateColumns = true;
                this.advancedDataGridView1.DataSource = ds.Tables[0];
                connection.Close();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT ntn_date as Дата, id_input_order as Код_Прихода, id_ntn as Код_Расхода, aaa as Поставщик, name_client as Клиент, input_produkt as Поступило, released as Реализовано, balance as Остаток, total_price as Цена, bid_ksu as Номер FROM view_ksu_two WHERE bid_ksu LIKE '%" + textBox1.Text + "%'", connection);
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                this.advancedDataGridView2.AutoGenerateColumns = true;
                this.advancedDataGridView2.DataSource = ds2.Tables[0];
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

        private void button2_Click(object sender, EventArgs e)
        {
            
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

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ksu_ed form = new ksu_ed();
            form.Visible = true;
            this.Visible = false;
        }
    }
}
