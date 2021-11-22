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
using System.Diagnostics;
using FastReport;
using System.IO;

namespace Sklad
{
    public partial class Main : Form
    {
        // Проверка авторизации
        IRegistration _autorithation;
        public Main(IRegistration autorithation)
        {
            InitializeComponent();
            _autorithation = autorithation;
        }
        // Код позволяет загрузить данные в таблицу
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=127.0.0.1; port=3306; username=root; password=1234; database=mydb";
            string script = "SELECT bid_ksu as КСУ, name_produkt as Название, input_produkt as Поступило, released as Реализовано, balance as Осталось, unit_produkt as Единица, total_price as Итого FROM view_balance;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(script, connection);
            DataTable table = new DataTable();
            mySql_dataAdapter.Fill(table);
            advancedDataGridView1.DataSource = table;
            connection.Close();

                if (_autorithation.primary == false)
            {
                упровлениеПользователямиToolStripMenuItem.Visible = false;
            }

            int ss = 0;
            while (ss < advancedDataGridView1.Rows.Count)
            {
                var bal1 = advancedDataGridView1.Rows[ss].Cells[1].Value;
                var bal2 = advancedDataGridView1.Rows[ss].Cells[4].Value;
                chart1.Series[0].Points.AddXY(Convert.ToString(bal1), Convert.ToInt32(bal2));
                ss++;
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

        // Переход на другие формы

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client_help form = new client_help();
            form.Visible = true;
            this.Visible = false;
        }

        private void упровлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reg form = new reg();
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

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Создание отчета
        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Load("report.frx");
            designerControl1.Report = report;
            designerControl1.Report.Show();
        }
        // Вызов справки
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("help.chm");
        }
    }
}
