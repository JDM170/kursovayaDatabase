namespace KursovayaDataBase
{
    partial class Stuff
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
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.сотрудникиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.СотрудникиTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchStuffButton = new System.Windows.Forms.Button();
            this.SearchStuff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdStuffButton = new System.Windows.Forms.Button();
            this.DelStuffButton = new System.Windows.Forms.Button();
            this.InsStuffButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптечный склад ( Сотрудники )";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 75);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 160);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SearchStuffButton);
            this.panel3.Controls.Add(this.SearchStuff);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 100);
            this.panel3.TabIndex = 38;
            // 
            // SearchStuffButton
            // 
            this.SearchStuffButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchStuffButton.Location = new System.Drawing.Point(177, 48);
            this.SearchStuffButton.Name = "SearchStuffButton";
            this.SearchStuffButton.Size = new System.Drawing.Size(75, 20);
            this.SearchStuffButton.TabIndex = 43;
            this.SearchStuffButton.Text = "Поиск";
            this.SearchStuffButton.UseVisualStyleBackColor = false;
            this.SearchStuffButton.Click += new System.EventHandler(this.SearchStuffButton_Click);
            // 
            // SearchStuff
            // 
            this.SearchStuff.Location = new System.Drawing.Point(21, 48);
            this.SearchStuff.Name = "SearchStuff";
            this.SearchStuff.Size = new System.Drawing.Size(149, 20);
            this.SearchStuff.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Поиск по названию";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.UpdStuffButton);
            this.panel4.Controls.Add(this.DelStuffButton);
            this.panel4.Controls.Add(this.InsStuffButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(578, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 267);
            this.panel4.TabIndex = 39;
            // 
            // UpdStuffButton
            // 
            this.UpdStuffButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdStuffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdStuffButton.Location = new System.Drawing.Point(64, 204);
            this.UpdStuffButton.Name = "UpdStuffButton";
            this.UpdStuffButton.Size = new System.Drawing.Size(105, 40);
            this.UpdStuffButton.TabIndex = 5;
            this.UpdStuffButton.Text = "Update";
            this.UpdStuffButton.UseVisualStyleBackColor = false;
            // 
            // DelStuffButton
            // 
            this.DelStuffButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelStuffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelStuffButton.Location = new System.Drawing.Point(64, 85);
            this.DelStuffButton.Name = "DelStuffButton";
            this.DelStuffButton.Size = new System.Drawing.Size(105, 40);
            this.DelStuffButton.TabIndex = 4;
            this.DelStuffButton.Text = "Delete";
            this.DelStuffButton.UseVisualStyleBackColor = false;
            this.DelStuffButton.Click += new System.EventHandler(this.DelStuffButton_Click);
            // 
            // InsStuffButton
            // 
            this.InsStuffButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsStuffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsStuffButton.Location = new System.Drawing.Point(64, 39);
            this.InsStuffButton.Name = "InsStuffButton";
            this.InsStuffButton.Size = new System.Drawing.Size(105, 40);
            this.InsStuffButton.TabIndex = 3;
            this.InsStuffButton.Text = "Insert";
            this.InsStuffButton.UseVisualStyleBackColor = false;
            this.InsStuffButton.Click += new System.EventHandler(this.InsStuffButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Работа с Базой данных";
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "Поряд.Номер Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Stuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 376);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Stuff";
            this.Text = "Stuff";
            this.Load += new System.EventHandler(this.Stuff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private LSkladDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchStuffButton;
        private System.Windows.Forms.TextBox SearchStuff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsStuffButton;
        private System.Windows.Forms.Button UpdStuffButton;
        private System.Windows.Forms.Button DelStuffButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
    }
}