namespace KursovayaDataBase
{
    partial class Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУлицыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.корпусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.офисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.клиентTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КлиентTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchClientButton = new System.Windows.Forms.Button();
            this.SearchClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDУлицыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентУлицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDГородаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентГородBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ГородTableAdapter();
            this.улицаTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.УлицаTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DelButtonClient = new System.Windows.Forms.Button();
            this.InsButtonClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентУлицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентГородBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад ( Клиенты )";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 75);
            this.panel1.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDГородаDataGridViewTextBoxColumn,
            this.iDУлицыDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.корпусDataGridViewTextBoxColumn,
            this.офисDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
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
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchClientButton);
            this.panel2.Controls.Add(this.SearchClient);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 326);
            this.panel2.TabIndex = 38;
            // 
            // SearchClientButton
            // 
            this.SearchClientButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchClientButton.Location = new System.Drawing.Point(702, 202);
            this.SearchClientButton.Name = "SearchClientButton";
            this.SearchClientButton.Size = new System.Drawing.Size(64, 20);
            this.SearchClientButton.TabIndex = 42;
            this.SearchClientButton.Text = "Поиск";
            this.SearchClientButton.UseVisualStyleBackColor = false;
            this.SearchClientButton.Click += new System.EventHandler(this.SearchClientButton_Click);
            // 
            // SearchClient
            // 
            this.SearchClient.Location = new System.Drawing.Point(547, 202);
            this.SearchClient.Name = "SearchClient";
            this.SearchClient.Size = new System.Drawing.Size(149, 20);
            this.SearchClient.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(544, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Поиск по названию";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУлицыDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.клиентУлицаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(265, 159);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(259, 150);
            this.dataGridView3.TabIndex = 39;
            // 
            // iDУлицыDataGridViewTextBoxColumn1
            // 
            this.iDУлицыDataGridViewTextBoxColumn1.DataPropertyName = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn1.HeaderText = "ID Улицы";
            this.iDУлицыDataGridViewTextBoxColumn1.Name = "iDУлицыDataGridViewTextBoxColumn1";
            this.iDУлицыDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn2
            // 
            this.названиеDataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn2.Name = "названиеDataGridViewTextBoxColumn2";
            this.названиеDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // клиентУлицаBindingSource
            // 
            this.клиентУлицаBindingSource.DataMember = "Клиент_Улица";
            this.клиентУлицаBindingSource.DataSource = this.клиентBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГородаDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.клиентГородBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(255, 150);
            this.dataGridView2.TabIndex = 38;
            // 
            // iDГородаDataGridViewTextBoxColumn1
            // 
            this.iDГородаDataGridViewTextBoxColumn1.DataPropertyName = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn1.HeaderText = "ID Города";
            this.iDГородаDataGridViewTextBoxColumn1.Name = "iDГородаDataGridViewTextBoxColumn1";
            this.iDГородаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // клиентГородBindingSource
            // 
            this.клиентГородBindingSource.DataMember = "Клиент_Город";
            this.клиентГородBindingSource.DataSource = this.клиентBindingSource;
            // 
            // городTableAdapter
            // 
            this.городTableAdapter.ClearBeforeFill = true;
            // 
            // улицаTableAdapter
            // 
            this.улицаTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DelButtonClient);
            this.panel3.Controls.Add(this.InsButtonClient);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(798, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 326);
            this.panel3.TabIndex = 39;
            // 
            // DelButtonClient
            // 
            this.DelButtonClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButtonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonClient.Location = new System.Drawing.Point(48, 95);
            this.DelButtonClient.Name = "DelButtonClient";
            this.DelButtonClient.Size = new System.Drawing.Size(110, 42);
            this.DelButtonClient.TabIndex = 3;
            this.DelButtonClient.Text = "Delete";
            this.DelButtonClient.UseVisualStyleBackColor = false;
            this.DelButtonClient.Click += new System.EventHandler(this.DelButtonClient_Click);
            // 
            // InsButtonClient
            // 
            this.InsButtonClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsButtonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsButtonClient.Location = new System.Drawing.Point(48, 36);
            this.InsButtonClient.Name = "InsButtonClient";
            this.InsButtonClient.Size = new System.Drawing.Size(110, 42);
            this.InsButtonClient.TabIndex = 2;
            this.InsButtonClient.Text = "Insert";
            this.InsButtonClient.UseVisualStyleBackColor = false;
            this.InsButtonClient.Click += new System.EventHandler(this.InsButtonClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Работа с Базой данных";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентУлицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентГородBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private LSkladDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корпусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn офисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource клиентГородBindingSource;
        private LSkladDataSetTableAdapters.ГородTableAdapter городTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГородаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource клиентУлицаBindingSource;
        private LSkladDataSetTableAdapters.УлицаTableAdapter улицаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox SearchClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchClientButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsButtonClient;
        private System.Windows.Forms.Button DelButtonClient;
    }
}