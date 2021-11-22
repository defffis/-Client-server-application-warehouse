
namespace Sklad
{
    partial class ntn_ed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ntn_ed));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.NewProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddingButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(612, 407);
            this.advancedDataGridView1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 7, 0, 0, 0, 0);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(647, 236);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(135, 31);
            this.DeleteProductButton.TabIndex = 38;
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // NewProductName
            // 
            this.NewProductName.Location = new System.Drawing.Point(647, 143);
            this.NewProductName.Name = "NewProductName";
            this.NewProductName.Size = new System.Drawing.Size(135, 22);
            this.NewProductName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Описание";
            // 
            // ProductAddingButton
            // 
            this.ProductAddingButton.Location = new System.Drawing.Point(647, 173);
            this.ProductAddingButton.Name = "ProductAddingButton";
            this.ProductAddingButton.Size = new System.Drawing.Size(135, 31);
            this.ProductAddingButton.TabIndex = 34;
            this.ProductAddingButton.Text = "Добавить";
            this.ProductAddingButton.UseVisualStyleBackColor = true;
            this.ProductAddingButton.Click += new System.EventHandler(this.ProductAddingButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(647, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // ntn_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.NewProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductAddingButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ntn_ed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Требование-накладная (изменение 1)";
            this.Load += new System.EventHandler(this.ntn_ed_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox NewProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductAddingButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}