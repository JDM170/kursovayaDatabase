namespace KursovayaDataBase
{
    partial class Packages
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDВидаУпаковкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видУпаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchPackagesButton = new System.Windows.Forms.Button();
            this.SearchPackages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DelButtonPackages = new System.Windows.Forms.Button();
            this.InsButtonPackages = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.вид_упаковкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад ( Виды упаковки )";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 75);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(4, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 262);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВидаУпаковкиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видУпаковкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDВидаУпаковкиDataGridViewTextBoxColumn
            // 
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.DataPropertyName = "ID Вида упаковки";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.HeaderText = "ID Вида упаковки";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.Name = "iDВидаУпаковкиDataGridViewTextBoxColumn";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видУпаковкиBindingSource
            // 
            this.видУпаковкиBindingSource.DataMember = "Вид упаковки";
            this.видУпаковкиBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SearchPackagesButton);
            this.panel3.Controls.Add(this.SearchPackages);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(4, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 113);
            this.panel3.TabIndex = 38;
            // 
            // SearchPackagesButton
            // 
            this.SearchPackagesButton.BackColor = System.Drawing.Color.White;
            this.SearchPackagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchPackagesButton.Location = new System.Drawing.Point(166, 43);
            this.SearchPackagesButton.Name = "SearchPackagesButton";
            this.SearchPackagesButton.Size = new System.Drawing.Size(75, 20);
            this.SearchPackagesButton.TabIndex = 3;
            this.SearchPackagesButton.Text = "Поиск";
            this.SearchPackagesButton.UseVisualStyleBackColor = false;
            this.SearchPackagesButton.Click += new System.EventHandler(this.SearchPackagesButton_Click);
            // 
            // SearchPackages
            // 
            this.SearchPackages.Location = new System.Drawing.Point(10, 43);
            this.SearchPackages.Name = "SearchPackages";
            this.SearchPackages.Size = new System.Drawing.Size(149, 20);
            this.SearchPackages.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Поиск по названию";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DelButtonPackages);
            this.panel4.Controls.Add(this.InsButtonPackages);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(451, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 113);
            this.panel4.TabIndex = 39;
            // 
            // DelButtonPackages
            // 
            this.DelButtonPackages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButtonPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonPackages.Location = new System.Drawing.Point(183, 43);
            this.DelButtonPackages.Name = "DelButtonPackages";
            this.DelButtonPackages.Size = new System.Drawing.Size(121, 37);
            this.DelButtonPackages.TabIndex = 29;
            this.DelButtonPackages.Text = "Delete";
            this.DelButtonPackages.UseVisualStyleBackColor = false;
            this.DelButtonPackages.Click += new System.EventHandler(this.DelButtonPackages_Click);
            // 
            // InsButtonPackages
            // 
            this.InsButtonPackages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsButtonPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsButtonPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsButtonPackages.Location = new System.Drawing.Point(16, 43);
            this.InsButtonPackages.Name = "InsButtonPackages";
            this.InsButtonPackages.Size = new System.Drawing.Size(121, 37);
            this.InsButtonPackages.TabIndex = 28;
            this.InsButtonPackages.Text = "Insert";
            this.InsButtonPackages.UseVisualStyleBackColor = false;
            this.InsButtonPackages.Click += new System.EventHandler(this.InsButtonPackages_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Работа с Базой данных";
            // 
            // вид_упаковкиTableAdapter
            // 
            this.вид_упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(781, 474);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Packages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.Packages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchPackages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchPackagesButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelButtonPackages;
        private System.Windows.Forms.Button InsButtonPackages;
        private System.Windows.Forms.BindingSource видУпаковкиBindingSource;
        private LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter вид_упаковкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВидаУпаковкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
    }
}