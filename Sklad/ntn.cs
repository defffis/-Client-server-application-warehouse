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
    public partial class ntn : Form, IRegistration
    {
        // Подключение бд
        private DataGridViewRow _advancedDataGridViewSelectedRow;
        public bool primary { get { return true; } set { } }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
        public ntn()
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
        private void ntn_Load(object sender, EventArgs e)
        {
            
            connection.Open();
            string script = "SELECT id_ntn as КОД, ntn_date as Дата, name_client as Клиент, about_ntn as Описание FROM view_ntn_one;";
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;

            script = "SELECT id_ntn as КОД, name_produkt as Продукт, id_ksu as КСУ, requested as Запрошено, released as Реализовано, fio_worker as Работник FROM view_ntn_two;";
            mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView2.DataSource = table;
            connection.Close();
        }
        // Переход на другие формы
        private void button1_Click(object sender, EventArgs e)
        {
            ntn_ed form = new ntn_ed();
            form.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ntn_ed2 form = new ntn_ed2();
            form.Visible = true;
            this.Visible = false;
        }
        // Поиск
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_ntn as КОД, ntn_date as Дата, name_client as Клиент, about_ntn as Описание FROM view_ntn_one WHERE id_ntn LIKE '%" + textBox1.Text + "%'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.advancedDataGridView1.AutoGenerateColumns = true;
            this.advancedDataGridView1.DataSource = ds.Tables[0];
            connection.Close();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT id_ntn as КОД, name_produkt as Продукт, id_ksu as КСУ, requested as Запрошено, released as Реализовано, fio_worker as Работник FROM view_ntn_two WHERE id_ntn LIKE '%" + textBox1.Text + "%'", connection);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            this.advancedDataGridView2.AutoGenerateColumns = true;
            this.advancedDataGridView2.DataSource = ds2.Tables[0];
            connection.Close();
        }
    }
}
