﻿
namespace Sklad.Spravka
{
    partial class country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(country));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главныйЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарнотранспортнаяНакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.требованиенакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаСкладскогоУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.едИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.NewProductPrice = new System.Windows.Forms.TextBox();
            this.NewProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddingButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главныйЭкранToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
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
            this.требованиенакладнаяToolStripMenuItem,
            this.карточкаСкладскогоУчетаToolStripMenuItem});
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
            // едИзмеренияToolStripMenuItem
            // 
            this.едИзмеренияToolStripMenuItem.Name = "едИзмеренияToolStripMenuItem";
            this.едИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.едИзмеренияToolStripMenuItem.Text = "Ед. измерения";
            this.едИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.едИзмеренияToolStripMenuItem_Click);
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(577, 407);
            this.advancedDataGridView1.TabIndex = 7;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(626, 187);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(135, 31);
            this.DeleteProductButton.TabIndex = 34;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // NewProductPrice
            // 
            this.NewProductPrice.Location = new System.Drawing.Point(626, 96);
            this.NewProductPrice.Name = "NewProductPrice";
            this.NewProductPrice.Size = new System.Drawing.Size(135, 22);
            this.NewProductPrice.TabIndex = 33;
            // 
            // NewProductName
            // 
            this.NewProductName.Location = new System.Drawing.Point(626, 51);
            this.NewProductName.Name = "NewProductName";
            this.NewProductName.Size = new System.Drawing.Size(135, 22);
            this.NewProductName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Полное имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Краткое имя";
            // 
            // ProductAddingButton
            // 
            this.ProductAddingButton.Location = new System.Drawing.Point(626, 124);
            this.ProductAddingButton.Name = "ProductAddingButton";
            this.ProductAddingButton.Size = new System.Drawing.Size(135, 31);
            this.ProductAddingButton.TabIndex = 29;
            this.ProductAddingButton.Text = "Добавить";
            this.ProductAddingButton.UseVisualStyleBackColor = true;
            this.ProductAddingButton.Click += new System.EventHandler(this.ProductAddingButton_Click);
            // 
            // country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.NewProductPrice);
            this.Controls.Add(this.NewProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductAddingButton);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.country_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главныйЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарнотранспортнаяНакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem требованиенакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаСкладскогоУчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem едИзмеренияToolStripMenuItem;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox NewProductPrice;
        private System.Windows.Forms.TextBox NewProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductAddingButton;
    }
}