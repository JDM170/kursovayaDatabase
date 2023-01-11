namespace KursovayaDataBase
{
    partial class ExcelFacture
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
            this.счетФактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.счет_ФактураTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Счет_ФактураTableAdapter();
            this.ExcelButtonFacture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DelFactureButton = new System.Windows.Forms.Button();
            this.InsFactureButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDСотрудникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетФактураСотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУлицыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корпусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.офисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетФактураКлиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDЛекарстваDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетФактураЛекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDФактурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЛекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарстваTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ЛекарстваTableAdapter();
            this.клиентTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КлиентTableAdapter();
            this.сотрудникиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.СотрудникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураСотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураКлиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураЛекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.счетФактураBindingSource;
            this.comboBox1.DisplayMember = "ID Фактуры";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(921, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID Фактуры";
            // 
            // счетФактураBindingSource
            // 
            this.счетФактураBindingSource.DataMember = "Счет-Фактура";
            this.счетФактураBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счет_ФактураTableAdapter
            // 
            this.счет_ФактураTableAdapter.ClearBeforeFill = true;
            // 
            // ExcelButtonFacture
            // 
            this.ExcelButtonFacture.Location = new System.Drawing.Point(934, 262);
            this.ExcelButtonFacture.Name = "ExcelButtonFacture";
            this.ExcelButtonFacture.Size = new System.Drawing.Size(97, 36);
            this.ExcelButtonFacture.TabIndex = 1;
            this.ExcelButtonFacture.Text = "Сохранение в Excel";
            this.ExcelButtonFacture.UseVisualStyleBackColor = true;
            this.ExcelButtonFacture.Click += new System.EventHandler(this.ExcelButtonFacture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад (Счет-Фактура)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 76);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DelFactureButton);
            this.panel2.Controls.Add(this.InsFactureButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ExcelButtonFacture);
            this.panel2.Location = new System.Drawing.Point(5, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 329);
            this.panel2.TabIndex = 4;
            // 
            // DelFactureButton
            // 
            this.DelFactureButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelFactureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFactureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFactureButton.Location = new System.Drawing.Point(921, 96);
            this.DelFactureButton.Name = "DelFactureButton";
            this.DelFactureButton.Size = new System.Drawing.Size(97, 35);
            this.DelFactureButton.TabIndex = 8;
            this.DelFactureButton.Text = "Delete";
            this.DelFactureButton.UseVisualStyleBackColor = false;
            this.DelFactureButton.Click += new System.EventHandler(this.DelFactureButton_Click);
            // 
            // InsFactureButton
            // 
            this.InsFactureButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsFactureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFactureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFactureButton.Location = new System.Drawing.Point(921, 45);
            this.InsFactureButton.Name = "InsFactureButton";
            this.InsFactureButton.Size = new System.Drawing.Size(97, 35);
            this.InsFactureButton.TabIndex = 7;
            this.InsFactureButton.Text = "Insert";
            this.InsFactureButton.UseVisualStyleBackColor = false;
            this.InsFactureButton.Click += new System.EventHandler(this.InsFactureButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(867, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите пор.номер фактуры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(883, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Работа с Базой данных";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.счетФактураСотрудникиBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(463, 161);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(346, 150);
            this.dataGridView4.TabIndex = 4;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn1
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn1.DataPropertyName = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn1.HeaderText = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn1.Name = "iDСотрудникаDataGridViewTextBoxColumn1";
            this.iDСотрудникаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоDataGridViewTextBoxColumn.Visible = false;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // счетФактураСотрудникиBindingSource
            // 
            this.счетФактураСотрудникиBindingSource.DataMember = "Счет-Фактура_Сотрудники";
            this.счетФактураСотрудникиBindingSource.DataSource = this.счетФактураBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn1,
            this.iDГородаDataGridViewTextBoxColumn,
            this.iDУлицыDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1,
            this.корпусDataGridViewTextBoxColumn,
            this.офисDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.счетФактураКлиентBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 160);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(449, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // iDКлиентаDataGridViewTextBoxColumn1
            // 
            this.iDКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.HeaderText = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.Name = "iDКлиентаDataGridViewTextBoxColumn1";
            this.iDКлиентаDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            this.домDataGridViewTextBoxColumn.ReadOnly = true;
            this.домDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // счетФактураКлиентBindingSource
            // 
            this.счетФактураКлиентBindingSource.DataMember = "Счет-Фактура_Клиент";
            this.счетФактураКлиентBindingSource.DataSource = this.счетФактураBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЛекарстваDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.iDКатегорииDataGridViewTextBoxColumn,
            this.iDПроизводителяDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.счетФактураЛекарстваBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(562, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(247, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDЛекарстваDataGridViewTextBoxColumn1
            // 
            this.iDЛекарстваDataGridViewTextBoxColumn1.DataPropertyName = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn1.HeaderText = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn1.Name = "iDЛекарстваDataGridViewTextBoxColumn1";
            this.iDЛекарстваDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
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
            // счетФактураЛекарстваBindingSource
            // 
            this.счетФактураЛекарстваBindingSource.DataMember = "Счет-Фактура_Лекарства";
            this.счетФактураЛекарстваBindingSource.DataSource = this.счетФактураBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФактурыDataGridViewTextBoxColumn,
            this.iDЛекарстваDataGridViewTextBoxColumn,
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетФактураBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDФактурыDataGridViewTextBoxColumn
            // 
            this.iDФактурыDataGridViewTextBoxColumn.DataPropertyName = "ID Фактуры";
            this.iDФактурыDataGridViewTextBoxColumn.HeaderText = "ID Фактуры";
            this.iDФактурыDataGridViewTextBoxColumn.Name = "iDФактурыDataGridViewTextBoxColumn";
            this.iDФактурыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЛекарстваDataGridViewTextBoxColumn
            // 
            this.iDЛекарстваDataGridViewTextBoxColumn.DataPropertyName = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.HeaderText = "ID Лекарства";
            this.iDЛекарстваDataGridViewTextBoxColumn.Name = "iDЛекарстваDataGridViewTextBoxColumn";
            this.iDЛекарстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // ExcelFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExcelFacture";
            this.Text = "ExcelFacture";
            this.Load += new System.EventHandler(this.ExcelFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураСотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураКлиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураЛекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource счетФактураBindingSource;
        private LSkladDataSetTableAdapters.Счет_ФактураTableAdapter счет_ФактураTableAdapter;
        private System.Windows.Forms.Button ExcelButtonFacture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФактурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource счетФактураЛекарстваBindingSource;
        private LSkladDataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЛекарстваDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource счетФактураКлиентBindingSource;
        private LSkladDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn корпусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn офисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource счетФактураСотрудникиBindingSource;
        private LSkladDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelFactureButton;
        private System.Windows.Forms.Button InsFactureButton;
    }
}