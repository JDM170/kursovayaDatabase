namespace KursovayaDataBase
{
    partial class DelPharm
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
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.производительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.видУпаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.лекарстваTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ЛекарстваTableAdapter();
            this.вид_упаковкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter();
            this.DelFormPharm = new System.Windows.Forms.Button();
            this.DelFormPharmFalse = new System.Windows.Forms.Button();
            this.категорияTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КатегорияTableAdapter();
            this.производительTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПроизводительTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 190);
            this.panel1.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.производительBindingSource;
            this.comboBox4.DisplayMember = "Название";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(230, 145);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.ValueMember = "ID Производителя";
            // 
            // производительBindingSource
            // 
            this.производительBindingSource.DataMember = "Производитель";
            this.производительBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выберите производителя";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.категорияBindingSource;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(230, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "ID Категории";
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.lSkladDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите категорию";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.видУпаковкиBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(230, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID Вида упаковки";
            // 
            // видУпаковкиBindingSource
            // 
            this.видУпаковкиBindingSource.DataMember = "Вид упаковки";
            this.видУпаковкиBindingSource.DataSource = this.lSkladDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.лекарстваBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID Лекарства";
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "Лекарства";
            this.лекарстваBindingSource.DataSource = this.lSkladDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите тип упаковки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите лекарство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление данных";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 76);
            this.panel2.TabIndex = 3;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // вид_упаковкиTableAdapter
            // 
            this.вид_упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // DelFormPharm
            // 
            this.DelFormPharm.BackColor = System.Drawing.Color.White;
            this.DelFormPharm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormPharm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormPharm.Location = new System.Drawing.Point(54, 290);
            this.DelFormPharm.Name = "DelFormPharm";
            this.DelFormPharm.Size = new System.Drawing.Size(106, 35);
            this.DelFormPharm.TabIndex = 4;
            this.DelFormPharm.Text = "Удалить";
            this.DelFormPharm.UseVisualStyleBackColor = false;
            this.DelFormPharm.Click += new System.EventHandler(this.DelFormPharm_Click);
            // 
            // DelFormPharmFalse
            // 
            this.DelFormPharmFalse.BackColor = System.Drawing.Color.White;
            this.DelFormPharmFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormPharmFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormPharmFalse.Location = new System.Drawing.Point(226, 290);
            this.DelFormPharmFalse.Name = "DelFormPharmFalse";
            this.DelFormPharmFalse.Size = new System.Drawing.Size(106, 35);
            this.DelFormPharmFalse.TabIndex = 5;
            this.DelFormPharmFalse.Text = "Отмена";
            this.DelFormPharmFalse.UseVisualStyleBackColor = false;
            this.DelFormPharmFalse.Click += new System.EventHandler(this.DelFormPharmFalse_Click);
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // производительTableAdapter
            // 
            this.производительTableAdapter.ClearBeforeFill = true;
            // 
            // DelPharm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.DelFormPharmFalse);
            this.Controls.Add(this.DelFormPharm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DelPharm";
            this.Text = "DelPharm";
            this.Load += new System.EventHandler(this.DelPharm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private LSkladDataSetTableAdapters.ЛекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.BindingSource видУпаковкиBindingSource;
        private LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter вид_упаковкиTableAdapter;
        private System.Windows.Forms.Button DelFormPharm;
        private System.Windows.Forms.Button DelFormPharmFalse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private LSkladDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource производительBindingSource;
        private LSkladDataSetTableAdapters.ПроизводительTableAdapter производительTableAdapter;
    }
}