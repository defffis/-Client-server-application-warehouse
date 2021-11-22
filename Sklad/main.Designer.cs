
namespace Sklad
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            FastReport.Design.DesignerSettings designerSettings1 = new FastReport.Design.DesignerSettings();
            FastReport.Design.DesignerRestrictions designerRestrictions1 = new FastReport.Design.DesignerRestrictions();
            FastReport.Export.Email.EmailSettings emailSettings1 = new FastReport.Export.Email.EmailSettings();
            FastReport.PreviewSettings previewSettings1 = new FastReport.PreviewSettings();
            FastReport.ReportSettings reportSettings1 = new FastReport.ReportSettings();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарнотранспортнаяНакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.требованиенакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаСкладскогоУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.едИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упровлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.designerControl1 = new FastReport.Design.StandardDesigner.DesignerControl();
            this.environmentSettings1 = new FastReport.EnvironmentSettings();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.упровлениеПользователямиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(985, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарнотранспортнаяНакладнаяToolStripMenuItem,
            this.требованиенакладнаяToolStripMenuItem,
            this.карточкаСкладскогоУчетаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // товарнотранспортнаяНакладнаяToolStripMenuItem
            // 
            this.товарнотранспортнаяНакладнаяToolStripMenuItem.Name = "товарнотранспортнаяНакладнаяToolStripMenuItem";
            this.товарнотранспортнаяНакладнаяToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.товарнотранспортнаяНакладнаяToolStripMenuItem.Text = "Товарно-транспортная накладная";
            this.товарнотранспортнаяНакладнаяToolStripMenuItem.Click += new System.EventHandler(this.товарнотранспортнаяНакладнаяToolStripMenuItem_Click);
            // 
            // требованиенакладнаяToolStripMenuItem
            // 
            this.требованиенакладнаяToolStripMenuItem.Name = "требованиенакладнаяToolStripMenuItem";
            this.требованиенакладнаяToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.требованиенакладнаяToolStripMenuItem.Text = "Требование-накладная";
            this.требованиенакладнаяToolStripMenuItem.Click += new System.EventHandler(this.требованиенакладнаяToolStripMenuItem_Click);
            // 
            // карточкаСкладскогоУчетаToolStripMenuItem
            // 
            this.карточкаСкладскогоУчетаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.карточкаСкладскогоУчетаToolStripMenuItem.Name = "карточкаСкладскогоУчетаToolStripMenuItem";
            this.карточкаСкладскогоУчетаToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.карточкаСкладскогоУчетаToolStripMenuItem.Text = "Карточка складского учета";
            this.карточкаСкладскогоУчетаToolStripMenuItem.Click += new System.EventHandler(this.карточкаСкладскогоУчетаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.страныToolStripMenuItem,
            this.едИзмеренияToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // страныToolStripMenuItem
            // 
            this.страныToolStripMenuItem.Name = "страныToolStripMenuItem";
            this.страныToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.страныToolStripMenuItem.Text = "Страны";
            this.страныToolStripMenuItem.Click += new System.EventHandler(this.страныToolStripMenuItem_Click);
            // 
            // едИзмеренияToolStripMenuItem
            // 
            this.едИзмеренияToolStripMenuItem.Name = "едИзмеренияToolStripMenuItem";
            this.едИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.едИзмеренияToolStripMenuItem.Text = "Ед. измерения";
            this.едИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.едИзмеренияToolStripMenuItem_Click);
            // 
            // упровлениеПользователямиToolStripMenuItem
            // 
            this.упровлениеПользователямиToolStripMenuItem.Name = "упровлениеПользователямиToolStripMenuItem";
            this.упровлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(228, 25);
            this.упровлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.упровлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.упровлениеПользователямиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 47);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersWidth = 49;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(778, 465);
            this.advancedDataGridView1.TabIndex = 7;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Linen;
            this.chart1.BorderlineColor = System.Drawing.Color.Linen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(796, 212);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(308, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // designerControl1
            // 
            this.designerControl1.AskSave = true;
            this.designerControl1.LayoutState = resources.GetString("designerControl1.LayoutState");
            this.designerControl1.Location = new System.Drawing.Point(1924, 81);
            this.designerControl1.Name = "designerControl1";
            this.designerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.designerControl1.Size = new System.Drawing.Size(30, 10);
            this.designerControl1.TabIndex = 12;
            this.designerControl1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2012Light;
            this.designerControl1.Visible = false;
            this.designerControl1.Zoom = 1F;
            // 
            // environmentSettings1
            // 
            designerSettings1.ApplicationConnection = null;
            designerSettings1.DefaultFont = new System.Drawing.Font("Arial", 10F);
            designerSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("designerSettings1.Icon")));
            designerSettings1.Restrictions = designerRestrictions1;
            designerSettings1.Text = "";
            this.environmentSettings1.DesignerSettings = designerSettings1;
            emailSettings1.Address = "";
            emailSettings1.Host = "";
            emailSettings1.MessageTemplate = "";
            emailSettings1.Name = "";
            emailSettings1.Password = "";
            emailSettings1.UserName = "";
            this.environmentSettings1.EmailSettings = emailSettings1;
            previewSettings1.FastScrolling = true;
            previewSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("previewSettings1.Icon")));
            previewSettings1.SaveInitialDirectory = null;
            previewSettings1.Text = "";
            this.environmentSettings1.PreviewSettings = previewSettings1;
            reportSettings1.ImageLocationRoot = null;
            reportSettings1.ShowPerformance = true;
            this.environmentSettings1.ReportSettings = reportSettings1;
            this.environmentSettings1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2012Light;
            this.environmentSettings1.UseRibbonUI = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Диаграмма остатков";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(985, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.designerControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведомость учета остатков на складе";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designerControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарнотранспортнаяНакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem требованиенакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаСкладскогоУчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упровлениеПользователямиToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem едИзмеренияToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private FastReport.Report report1;
        private FastReport.Design.StandardDesigner.DesignerControl designerControl1;
        private FastReport.EnvironmentSettings environmentSettings1;
        private System.Windows.Forms.Label label2;
    }
}

