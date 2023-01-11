namespace KursovayaDataBase
{
    partial class Pharm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InsButtonPharm = new System.Windows.Forms.Button();
            this.DelButtonPharm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchPharmButton = new System.Windows.Forms.Button();
            this.SearchPharm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.iDВидаУпаковкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаВидУпаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваЦенаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDЛекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.iDКатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарстваКатегорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарстваПроизводительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ЛекарстваTableAdapter();
            this.ценаTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ЦенаTableAdapter();
            this.производительTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПроизводительTableAdapter();
            this.категорияTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КатегорияTableAdapter();
            this.вид_упаковкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter();
            this.лекарстваЦенаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценаВидУпаковкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваЦенаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваКатегорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваПроизводительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваЦенаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 75);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад ( Лекарства )";
            // 
            // InsButtonPharm
            // 
            this.InsButtonPharm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsButtonPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsButtonPharm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsButtonPharm.Location = new System.Drawing.Point(35, 35);
            this.InsButtonPharm.Name = "InsButtonPharm";
            this.InsButtonPharm.Size = new System.Drawing.Size(121, 37);
            this.InsButtonPharm.TabIndex = 27;
            this.InsButtonPharm.Text = "Insert";
            this.InsButtonPharm.UseVisualStyleBackColor = false;
            this.InsButtonPharm.Click += new System.EventHandler(this.InsButtonPharm_Click);
            // 
            // DelButtonPharm
            // 
            this.DelButtonPharm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButtonPharm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonPharm.Location = new System.Drawing.Point(35, 91);
            this.DelButtonPharm.Name = "DelButtonPharm";
            this.DelButtonPharm.Size = new System.Drawing.Size(121, 37);
            this.DelButtonPharm.TabIndex = 26;
            this.DelButtonPharm.Text = "Delete";
            this.DelButtonPharm.UseVisualStyleBackColor = false;
            this.DelButtonPharm.Click += new System.EventHandler(this.DelButtonPharm_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.InsButtonPharm);
            this.panel5.Controls.Add(this.DelButtonPharm);
            this.panel5.Location = new System.Drawing.Point(659, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 338);
            this.panel5.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Работа с Базой данных";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.SearchPharmButton);
            this.panel4.Controls.Add(this.SearchPharm);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 100);
            this.panel4.TabIndex = 42;
            // 
            // SearchPharmButton
            // 
            this.SearchPharmButton.BackColor = System.Drawing.Color.White;
            this.SearchPharmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchPharmButton.Location = new System.Drawing.Point(162, 35);
            this.SearchPharmButton.Name = "SearchPharmButton";
            this.SearchPharmButton.Size = new System.Drawing.Size(75, 20);
            this.SearchPharmButton.TabIndex = 2;
            this.SearchPharmButton.Text = "Поиск";
            this.SearchPharmButton.UseVisualStyleBackColor = false;
            this.SearchPharmButton.Click += new System.EventHandler(this.SearchPharmButton_Click);
            // 
            // SearchPharm
            // 
            this.SearchPharm.Location = new System.Drawing.Point(7, 35);
            this.SearchPharm.Name = "SearchPharm";
            this.SearchPharm.Size = new System.Drawing.Size(149, 20);
            this.SearchPharm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поиск по названию";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView6);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView5);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.dataGridView4);
            this.panel3.Location = new System.Drawing.Point(12, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 232);
            this.panel3.TabIndex = 41;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВидаУпаковкиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn3});
            this.dataGridView6.DataSource = this.ценаВидУпаковкиBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(455, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(166, 86);
            this.dataGridView6.TabIndex = 44;
            // 
            // iDВидаУпаковкиDataGridViewTextBoxColumn
            // 
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.DataPropertyName = "ID Вида упаковки";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.HeaderText = "ID Вида упаковки";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.Name = "iDВидаУпаковкиDataGridViewTextBoxColumn";
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDВидаУпаковкиDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn3
            // 
            this.названиеDataGridViewTextBoxColumn3.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn3.HeaderText = "Вид упаковки";
            this.названиеDataGridViewTextBoxColumn3.Name = "названиеDataGridViewTextBoxColumn3";
            this.названиеDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ценаВидУпаковкиBindingSource
            // 
            this.ценаВидУпаковкиBindingSource.DataMember = "Цена_Вид упаковки";
            this.ценаВидУпаковкиBindingSource.DataSource = this.лекарстваЦенаBindingSource1;
            // 
            // лекарстваЦенаBindingSource1
            // 
            this.лекарстваЦенаBindingSource1.DataMember = "ЛекарстваЦена";
            this.лекарстваЦенаBindingSource1.DataSource = this.лекарстваBindingSource;
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЛекарстваDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.лекарстваBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(272, 221);
            this.dataGridView2.TabIndex = 37;
            // 
            // iDЛекарстваDataGridViewTextBoxColumn
            // 
            this.iDЛекарстваDataGridViewTextBoxColumn.DataPropertyName = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.HeaderText = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.Name = "iDЛекарстваDataGridViewTextBoxColumn";
            this.iDЛекарстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКатегорииDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn2});
            this.dataGridView5.DataSource = this.лекарстваКатегорияBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(455, 131);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(168, 93);
            this.dataGridView5.TabIndex = 40;
            // 
            // iDКатегорииDataGridViewTextBoxColumn
            // 
            this.iDКатегорииDataGridViewTextBoxColumn.DataPropertyName = "ID Категории";
            this.iDКатегорииDataGridViewTextBoxColumn.HeaderText = "ID Категории";
            this.iDКатегорииDataGridViewTextBoxColumn.Name = "iDКатегорииDataGridViewTextBoxColumn";
            this.iDКатегорииDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКатегорииDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn2
            // 
            this.названиеDataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.названиеDataGridViewTextBoxColumn2.Name = "названиеDataGridViewTextBoxColumn2";
            this.названиеDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // лекарстваКатегорияBindingSource
            // 
            this.лекарстваКатегорияBindingSource.DataMember = "Лекарства_Категория";
            this.лекарстваКатегорияBindingSource.DataSource = this.лекарстваBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.лекарстваЦенаBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(281, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(168, 86);
            this.dataGridView3.TabIndex = 38;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПроизводителяDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.лекарстваПроизводительBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(281, 131);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(168, 93);
            this.dataGridView4.TabIndex = 39;
            // 
            // iDПроизводителяDataGridViewTextBoxColumn
            // 
            this.iDПроизводителяDataGridViewTextBoxColumn.DataPropertyName = "ID Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.HeaderText = "ID Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.Name = "iDПроизводителяDataGridViewTextBoxColumn";
            this.iDПроизводителяDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПроизводителяDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Производитель";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // лекарстваПроизводительBindingSource
            // 
            this.лекарстваПроизводительBindingSource.DataMember = "Лекарства_Производитель";
            this.лекарстваПроизводительBindingSource.DataSource = this.лекарстваBindingSource;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // ценаTableAdapter
            // 
            this.ценаTableAdapter.ClearBeforeFill = true;
            // 
            // производительTableAdapter
            // 
            this.производительTableAdapter.ClearBeforeFill = true;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // вид_упаковкиTableAdapter
            // 
            this.вид_упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // лекарстваЦенаBindingSource
            // 
            this.лекарстваЦенаBindingSource.DataMember = "ЛекарстваЦена";
            this.лекарстваЦенаBindingSource.DataSource = this.лекарстваBindingSource;
            // 
            // Pharm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(871, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Pharm";
            this.Text = "Pharm";
            this.Load += new System.EventHandler(this.Pharm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценаВидУпаковкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваЦенаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваКатегорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваПроизводительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваЦенаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsButtonPharm;
        private System.Windows.Forms.Button DelButtonPharm;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private LSkladDataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.BindingSource лекарстваЦенаBindingSource;
        private LSkladDataSetTableAdapters.ЦенаTableAdapter ценаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource лекарстваЦенаBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource лекарстваПроизводительBindingSource;
        private LSkladDataSetTableAdapters.ПроизводительTableAdapter производительTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource лекарстваКатегорияBindingSource;
        private LSkladDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchPharmButton;
        private System.Windows.Forms.TextBox SearchPharm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource ценаВидУпаковкиBindingSource;
        private LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter вид_упаковкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВидаУпаковкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn3;
    }
}