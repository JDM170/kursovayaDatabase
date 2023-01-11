namespace KursovayaDataBase
{
    partial class ExcelNakladnaya
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.накладнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.накладнаяTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.НакладнаяTableAdapter();
            this.SaveExcelNakladnaya = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DelButtonNakladnaya = new System.Windows.Forms.Button();
            this.InsButtonNakladnaya = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDЛекарстваDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.накладнаяЛекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDПоставщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУлицыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корпусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.офисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетныйСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.накладнаяПоставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDНакладнойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЛекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.поставщикTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПоставщикTableAdapter();
            this.лекарстваTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ЛекарстваTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяЛекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяПоставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.накладнаяBindingSource;
            this.comboBox1.DisplayMember = "ID Накладной";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(872, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID Накладной";
            // 
            // накладнаяBindingSource
            // 
            this.накладнаяBindingSource.DataMember = "Накладная";
            this.накладнаяBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладнаяTableAdapter
            // 
            this.накладнаяTableAdapter.ClearBeforeFill = true;
            // 
            // SaveExcelNakladnaya
            // 
            this.SaveExcelNakladnaya.Location = new System.Drawing.Point(872, 263);
            this.SaveExcelNakladnaya.Name = "SaveExcelNakladnaya";
            this.SaveExcelNakladnaya.Size = new System.Drawing.Size(121, 38);
            this.SaveExcelNakladnaya.TabIndex = 1;
            this.SaveExcelNakladnaya.Text = "Сохранить в Excel";
            this.SaveExcelNakladnaya.UseVisualStyleBackColor = true;
            this.SaveExcelNakladnaya.Click += new System.EventHandler(this.SaveExcelNakladnaya_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад (Накладная)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 76);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DelButtonNakladnaya);
            this.panel2.Controls.Add(this.InsButtonNakladnaya);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.SaveExcelNakladnaya);
            this.panel2.Location = new System.Drawing.Point(13, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 345);
            this.panel2.TabIndex = 5;
            // 
            // DelButtonNakladnaya
            // 
            this.DelButtonNakladnaya.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonNakladnaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButtonNakladnaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonNakladnaya.Location = new System.Drawing.Point(875, 99);
            this.DelButtonNakladnaya.Name = "DelButtonNakladnaya";
            this.DelButtonNakladnaya.Size = new System.Drawing.Size(121, 37);
            this.DelButtonNakladnaya.TabIndex = 13;
            this.DelButtonNakladnaya.Text = "Delete";
            this.DelButtonNakladnaya.UseVisualStyleBackColor = false;
            this.DelButtonNakladnaya.Click += new System.EventHandler(this.DelButtonNakladnaya_Click);
            // 
            // InsButtonNakladnaya
            // 
            this.InsButtonNakladnaya.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsButtonNakladnaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsButtonNakladnaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsButtonNakladnaya.Location = new System.Drawing.Point(875, 47);
            this.InsButtonNakladnaya.Name = "InsButtonNakladnaya";
            this.InsButtonNakladnaya.Size = new System.Drawing.Size(121, 37);
            this.InsButtonNakladnaya.TabIndex = 12;
            this.InsButtonNakladnaya.Text = "Insert";
            this.InsButtonNakladnaya.UseVisualStyleBackColor = false;
            this.InsButtonNakladnaya.Click += new System.EventHandler(this.InsButtonNakladnaya_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЛекарстваDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn1,
            this.iDКатегорииDataGridViewTextBoxColumn,
            this.iDПроизводителяDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.накладнаяЛекарстваBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(460, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(270, 307);
            this.dataGridView3.TabIndex = 11;
            // 
            // iDЛекарстваDataGridViewTextBoxColumn1
            // 
            this.iDЛекарстваDataGridViewTextBoxColumn1.DataPropertyName = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn1.HeaderText = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn1.Name = "iDЛекарстваDataGridViewTextBoxColumn1";
            this.iDЛекарстваDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDКатегорииDataGridViewTextBoxColumn
            // 
            this.iDКатегорииDataGridViewTextBoxColumn.DataPropertyName = "ID Категории";
            this.iDКатегорииDataGridViewTextBoxColumn.HeaderText = "ID Категории";
            this.iDКатегорииDataGridViewTextBoxColumn.Name = "iDКатегорииDataGridViewTextBoxColumn";
            this.iDКатегорииDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКатегорииDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDПроизводителяDataGridViewTextBoxColumn
            // 
            this.iDПроизводителяDataGridViewTextBoxColumn.DataPropertyName = "ID Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.HeaderText = "ID Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.Name = "iDПроизводителяDataGridViewTextBoxColumn";
            this.iDПроизводителяDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDПроизводителяDataGridViewTextBoxColumn.Visible = false;
            // 
            // накладнаяЛекарстваBindingSource
            // 
            this.накладнаяЛекарстваBindingSource.DataMember = "Накладная_Лекарства";
            this.накладнаяЛекарстваBindingSource.DataSource = this.накладнаяBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПоставщикаDataGridViewTextBoxColumn1,
            this.iDГородаDataGridViewTextBoxColumn,
            this.iDУлицыDataGridViewTextBoxColumn,
            this.iDБанкаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.корпусDataGridViewTextBoxColumn,
            this.офисDataGridViewTextBoxColumn,
            this.расчетныйСчетDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.накладнаяПоставщикBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(4, 161);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(449, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // iDПоставщикаDataGridViewTextBoxColumn1
            // 
            this.iDПоставщикаDataGridViewTextBoxColumn1.DataPropertyName = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn1.HeaderText = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn1.Name = "iDПоставщикаDataGridViewTextBoxColumn1";
            this.iDПоставщикаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDГородаDataGridViewTextBoxColumn
            // 
            this.iDГородаDataGridViewTextBoxColumn.DataPropertyName = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn.HeaderText = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn.Name = "iDГородаDataGridViewTextBoxColumn";
            this.iDГородаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDГородаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDУлицыDataGridViewTextBoxColumn
            // 
            this.iDУлицыDataGridViewTextBoxColumn.DataPropertyName = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn.HeaderText = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn.Name = "iDУлицыDataGridViewTextBoxColumn";
            this.iDУлицыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDУлицыDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDБанкаDataGridViewTextBoxColumn
            // 
            this.iDБанкаDataGridViewTextBoxColumn.DataPropertyName = "ID Банка";
            this.iDБанкаDataGridViewTextBoxColumn.HeaderText = "ID Банка";
            this.iDБанкаDataGridViewTextBoxColumn.Name = "iDБанкаDataGridViewTextBoxColumn";
            this.iDБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDБанкаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.ReadOnly = true;
            this.домDataGridViewTextBoxColumn.Visible = false;
            // 
            // корпусDataGridViewTextBoxColumn
            // 
            this.корпусDataGridViewTextBoxColumn.DataPropertyName = "Корпус";
            this.корпусDataGridViewTextBoxColumn.HeaderText = "Корпус";
            this.корпусDataGridViewTextBoxColumn.Name = "корпусDataGridViewTextBoxColumn";
            this.корпусDataGridViewTextBoxColumn.ReadOnly = true;
            this.корпусDataGridViewTextBoxColumn.Visible = false;
            // 
            // офисDataGridViewTextBoxColumn
            // 
            this.офисDataGridViewTextBoxColumn.DataPropertyName = "Офис";
            this.офисDataGridViewTextBoxColumn.HeaderText = "Офис";
            this.офисDataGridViewTextBoxColumn.Name = "офисDataGridViewTextBoxColumn";
            this.офисDataGridViewTextBoxColumn.ReadOnly = true;
            this.офисDataGridViewTextBoxColumn.Visible = false;
            // 
            // расчетныйСчетDataGridViewTextBoxColumn
            // 
            this.расчетныйСчетDataGridViewTextBoxColumn.DataPropertyName = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.HeaderText = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.Name = "расчетныйСчетDataGridViewTextBoxColumn";
            this.расчетныйСчетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // накладнаяПоставщикBindingSource
            // 
            this.накладнаяПоставщикBindingSource.DataMember = "Накладная_Поставщик";
            this.накладнаяПоставщикBindingSource.DataSource = this.накладнаяBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDНакладнойDataGridViewTextBoxColumn,
            this.iDПоставщикаDataGridViewTextBoxColumn,
            this.iDЛекарстваDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.накладнаяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDНакладнойDataGridViewTextBoxColumn
            // 
            this.iDНакладнойDataGridViewTextBoxColumn.DataPropertyName = "ID Накладной";
            this.iDНакладнойDataGridViewTextBoxColumn.HeaderText = "ID Накладной";
            this.iDНакладнойDataGridViewTextBoxColumn.Name = "iDНакладнойDataGridViewTextBoxColumn";
            this.iDНакладнойDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDПоставщикаDataGridViewTextBoxColumn
            // 
            this.iDПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.HeaderText = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.Name = "iDПоставщикаDataGridViewTextBoxColumn";
            this.iDПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЛекарстваDataGridViewTextBoxColumn
            // 
            this.iDЛекарстваDataGridViewTextBoxColumn.DataPropertyName = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.HeaderText = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.Name = "iDЛекарстваDataGridViewTextBoxColumn";
            this.iDЛекарстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(839, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Работа с Базой данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(813, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите пор.номер накладной";
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // ExcelNakladnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExcelNakladnaya";
            this.Text = "ExcelNakladnaya";
            this.Load += new System.EventHandler(this.ExcelNakladnaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяЛекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяПоставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource накладнаяBindingSource;
        private LSkladDataSetTableAdapters.НакладнаяTableAdapter накладнаяTableAdapter;
        private System.Windows.Forms.Button SaveExcelNakladnaya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDНакладнойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource накладнаяПоставщикBindingSource;
        private LSkladDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корпусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn офисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расчетныйСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource накладнаяЛекарстваBindingSource;
        private LSkladDataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛекарстваDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DelButtonNakladnaya;
        private System.Windows.Forms.Button InsButtonNakladnaya;
    }
}