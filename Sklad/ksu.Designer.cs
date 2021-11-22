
namespace Sklad
{
    partial class ksu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ksu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главныйЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарнотранспортнаяНакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.требованиенакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.едИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.advancedDataGridView2 = new Zuby.ADGV.AdvancedDataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главныйЭкранToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главныйЭкранToolStripMenuItem
            // 
            this.главныйЭкранToolStripMenuItem.Name = "главныйЭкранToolStripMenuItem";
            this.главныйЭкранToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.главныйЭкранToolStripMenuItem.Text = "Главный экран";
            this.главныйЭкранToolStripMenuItem.Click += new System.EventHandler(this.главныйЭкранToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарнотранспортнаяНакладнаяToolStripMenuItem,
            this.требованиенакладнаяToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
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
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
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
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
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
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 31);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersWidth = 49;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(976, 66);
            this.advancedDataGridView1.TabIndex = 5;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToAddRows = false;
            this.advancedDataGridView2.AllowUserToDeleteRows = false;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.advancedDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.FilterAndSortEnabled = true;
            this.advancedDataGridView2.Location = new System.Drawing.Point(12, 103);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.ReadOnly = true;
            this.advancedDataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView2.RowHeadersWidth = 49;
            this.advancedDataGridView2.RowTemplate.Height = 24;
            this.advancedDataGridView2.Size = new System.Drawing.Size(976, 335);
            this.advancedDataGridView2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1022, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1022, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ksu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ksu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка складского учета";
            this.Load += new System.EventHandler(this.ksu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главныйЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарнотранспортнаяНакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem требованиенакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem едИзмеренияToolStripMenuItem;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}