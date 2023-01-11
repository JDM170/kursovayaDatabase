namespace KursovayaDataBase
{
    partial class Suppliers
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDГородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикГородBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet1 = new KursovayaDataBase.LSkladDataSet();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDУлицыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикУлицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикБанкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корпусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.офисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетныйСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.поставщикTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПоставщикTableAdapter();
            this.банкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.БанкиTableAdapter();
            this.улицаTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.УлицаTableAdapter();
            this.городTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ГородTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchSuppliesButton = new System.Windows.Forms.Button();
            this.SearchSupplies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DelButtonSupplies = new System.Windows.Forms.Button();
            this.InsButtonSupplies = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикГородBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикУлицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикБанкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад ( Поставщики )";
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
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(4, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 262);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГородаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.поставщикГородBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(766, 89);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(160, 79);
            this.dataGridView4.TabIndex = 3;
            // 
            // iDГородаDataGridViewTextBoxColumn
            // 
            this.iDГородаDataGridViewTextBoxColumn.DataPropertyName = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn.HeaderText = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn.Name = "iDГородаDataGridViewTextBoxColumn";
            this.iDГородаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDГородаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn3
            // 
            this.названиеDataGridViewTextBoxColumn3.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn3.HeaderText = "Город";
            this.названиеDataGridViewTextBoxColumn3.Name = "названиеDataGridViewTextBoxColumn3";
            this.названиеDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // поставщикГородBindingSource
            // 
            this.поставщикГородBindingSource.DataMember = "Поставщик_Город";
            this.поставщикГородBindingSource.DataSource = this.поставщикBindingSource;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.lSkladDataSet1;
            // 
            // lSkladDataSet1
            // 
            this.lSkladDataSet1.DataSetName = "LSkladDataSet";
            this.lSkladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУлицыDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.поставщикУлицаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(766, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(160, 79);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDУлицыDataGridViewTextBoxColumn
            // 
            this.iDУлицыDataGridViewTextBoxColumn.DataPropertyName = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn.HeaderText = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn.Name = "iDУлицыDataGridViewTextBoxColumn";
            this.iDУлицыDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDУлицыDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn2
            // 
            this.названиеDataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn2.HeaderText = "Улица";
            this.названиеDataGridViewTextBoxColumn2.Name = "названиеDataGridViewTextBoxColumn2";
            this.названиеDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // поставщикУлицаBindingSource
            // 
            this.поставщикУлицаBindingSource.DataMember = "Поставщик_Улица";
            this.поставщикУлицаBindingSource.DataSource = this.поставщикBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDБанкаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.поставщикБанкиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(766, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(160, 79);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDБанкаDataGridViewTextBoxColumn
            // 
            this.iDБанкаDataGridViewTextBoxColumn.DataPropertyName = "ID Банка";
            this.iDБанкаDataGridViewTextBoxColumn.HeaderText = "ID Банка";
            this.iDБанкаDataGridViewTextBoxColumn.Name = "iDБанкаDataGridViewTextBoxColumn";
            this.iDБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDБанкаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Банк";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // поставщикБанкиBindingSource
            // 
            this.поставщикБанкиBindingSource.DataMember = "Поставщик_Банки";
            this.поставщикБанкиBindingSource.DataSource = this.поставщикBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПоставщикаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.корпусDataGridViewTextBoxColumn,
            this.офисDataGridViewTextBoxColumn,
            this.расчетныйСчетDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставщикBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDПоставщикаDataGridViewTextBoxColumn
            // 
            this.iDПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.HeaderText = "ID Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.Name = "iDПоставщикаDataGridViewTextBoxColumn";
            this.iDПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // корпусDataGridViewTextBoxColumn
            // 
            this.корпусDataGridViewTextBoxColumn.DataPropertyName = "Корпус";
            this.корпусDataGridViewTextBoxColumn.HeaderText = "Корпус";
            this.корпусDataGridViewTextBoxColumn.Name = "корпусDataGridViewTextBoxColumn";
            this.корпусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // офисDataGridViewTextBoxColumn
            // 
            this.офисDataGridViewTextBoxColumn.DataPropertyName = "Офис";
            this.офисDataGridViewTextBoxColumn.HeaderText = "Офис";
            this.офисDataGridViewTextBoxColumn.Name = "офисDataGridViewTextBoxColumn";
            this.офисDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // банкиTableAdapter
            // 
            this.банкиTableAdapter.ClearBeforeFill = true;
            // 
            // улицаTableAdapter
            // 
            this.улицаTableAdapter.ClearBeforeFill = true;
            // 
            // городTableAdapter
            // 
            this.городTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SearchSuppliesButton);
            this.panel3.Controls.Add(this.SearchSupplies);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(4, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 113);
            this.panel3.TabIndex = 38;
            // 
            // SearchSuppliesButton
            // 
            this.SearchSuppliesButton.BackColor = System.Drawing.Color.White;
            this.SearchSuppliesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchSuppliesButton.Location = new System.Drawing.Point(166, 43);
            this.SearchSuppliesButton.Name = "SearchSuppliesButton";
            this.SearchSuppliesButton.Size = new System.Drawing.Size(75, 20);
            this.SearchSuppliesButton.TabIndex = 3;
            this.SearchSuppliesButton.Text = "Поиск";
            this.SearchSuppliesButton.UseVisualStyleBackColor = false;
            this.SearchSuppliesButton.Click += new System.EventHandler(this.SearchSuppliesButton_Click);
            // 
            // SearchSupplies
            // 
            this.SearchSupplies.Location = new System.Drawing.Point(10, 43);
            this.SearchSupplies.Name = "SearchSupplies";
            this.SearchSupplies.Size = new System.Drawing.Size(149, 20);
            this.SearchSupplies.TabIndex = 2;
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
            this.panel4.Controls.Add(this.DelButtonSupplies);
            this.panel4.Controls.Add(this.InsButtonSupplies);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(451, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 113);
            this.panel4.TabIndex = 39;
            // 
            // DelButtonSupplies
            // 
            this.DelButtonSupplies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButtonSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonSupplies.Location = new System.Drawing.Point(183, 43);
            this.DelButtonSupplies.Name = "DelButtonSupplies";
            this.DelButtonSupplies.Size = new System.Drawing.Size(121, 37);
            this.DelButtonSupplies.TabIndex = 29;
            this.DelButtonSupplies.Text = "Delete";
            this.DelButtonSupplies.UseVisualStyleBackColor = false;
            this.DelButtonSupplies.Click += new System.EventHandler(this.DelButtonSupplies_Click);
            // 
            // InsButtonSupplies
            // 
            this.InsButtonSupplies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsButtonSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsButtonSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsButtonSupplies.Location = new System.Drawing.Point(16, 43);
            this.InsButtonSupplies.Name = "InsButtonSupplies";
            this.InsButtonSupplies.Size = new System.Drawing.Size(121, 37);
            this.InsButtonSupplies.TabIndex = 28;
            this.InsButtonSupplies.Text = "Insert";
            this.InsButtonSupplies.UseVisualStyleBackColor = false;
            this.InsButtonSupplies.Click += new System.EventHandler(this.InsButtonSupplies_Click);
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

            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(947, 474);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикГородBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикУлицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикБанкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private LSkladDataSet lSkladDataSet1;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private LSkladDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корпусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn офисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расчетныйСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource поставщикБанкиBindingSource;
        private LSkladDataSetTableAdapters.БанкиTableAdapter банкиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource поставщикУлицаBindingSource;
        private LSkladDataSetTableAdapters.УлицаTableAdapter улицаTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource поставщикГородBindingSource;
        private LSkladDataSetTableAdapters.ГородTableAdapter городTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchSupplies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchSuppliesButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelButtonSupplies;
        private System.Windows.Forms.Button InsButtonSupplies;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}