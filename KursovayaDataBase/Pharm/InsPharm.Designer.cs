namespace KursovayaDataBase
{
    partial class InsPharm
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
            this.priceFieldPharm = new System.Windows.Forms.TextBox();
            this.nameFieldPharm = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.производительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.видУпаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.категорияTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КатегорияTableAdapter();
            this.вид_упаковкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter();
            this.производительTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПроизводительTableAdapter();
            this.InsFormPharm = new System.Windows.Forms.Button();
            this.InsFormPharmFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление данных";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.priceFieldPharm);
            this.panel2.Controls.Add(this.nameFieldPharm);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 221);
            this.panel2.TabIndex = 3;
            // 
            // priceFieldPharm
            // 
            this.priceFieldPharm.Location = new System.Drawing.Point(232, 175);
            this.priceFieldPharm.Name = "priceFieldPharm";
            this.priceFieldPharm.Size = new System.Drawing.Size(121, 20);
            this.priceFieldPharm.TabIndex = 9;
            // 
            // nameFieldPharm
            // 
            this.nameFieldPharm.Location = new System.Drawing.Point(232, 4);
            this.nameFieldPharm.Name = "nameFieldPharm";
            this.nameFieldPharm.Size = new System.Drawing.Size(121, 20);
            this.nameFieldPharm.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.производительBindingSource;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(232, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "ID Производителя";
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
            // comboBox2
            // 
            this.comboBox2.DataSource = this.видУпаковкиBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "ID Вида упаковки";
            // 
            // видУпаковкиBindingSource
            // 
            this.видУпаковкиBindingSource.DataMember = "Вид упаковки";
            this.видУпаковкиBindingSource.DataSource = this.lSkladDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.категорияBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ID Категории";
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.lSkladDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите тип упаковки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выберите производителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Укажите цену";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите название";
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // вид_упаковкиTableAdapter
            // 
            this.вид_упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // производительTableAdapter
            // 
            this.производительTableAdapter.ClearBeforeFill = true;
            // 
            // InsFormPharm
            // 
            this.InsFormPharm.BackColor = System.Drawing.Color.White;
            this.InsFormPharm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormPharm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormPharm.Location = new System.Drawing.Point(57, 325);
            this.InsFormPharm.Name = "InsFormPharm";
            this.InsFormPharm.Size = new System.Drawing.Size(106, 35);
            this.InsFormPharm.TabIndex = 4;
            this.InsFormPharm.Text = "Добавить";
            this.InsFormPharm.UseVisualStyleBackColor = false;
            this.InsFormPharm.Click += new System.EventHandler(this.InsFormPharm_Click);
            // 
            // InsFormPharmFalse
            // 
            this.InsFormPharmFalse.BackColor = System.Drawing.Color.White;
            this.InsFormPharmFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormPharmFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormPharmFalse.Location = new System.Drawing.Point(211, 325);
            this.InsFormPharmFalse.Name = "InsFormPharmFalse";
            this.InsFormPharmFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormPharmFalse.TabIndex = 5;
            this.InsFormPharmFalse.Text = "Отмена";
            this.InsFormPharmFalse.UseVisualStyleBackColor = false;
            this.InsFormPharmFalse.Click += new System.EventHandler(this.InsFormPharmFalse_Click);
            // 
            // InsPharm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 372);
            this.Controls.Add(this.InsFormPharmFalse);
            this.Controls.Add(this.InsFormPharm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsPharm";
            this.Text = "InsPharm";
            this.Load += new System.EventHandler(this.InsPharm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видУпаковкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceFieldPharm;
        private System.Windows.Forms.TextBox nameFieldPharm;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private LSkladDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.BindingSource видУпаковкиBindingSource;
        private LSkladDataSetTableAdapters.Вид_упаковкиTableAdapter вид_упаковкиTableAdapter;
        private System.Windows.Forms.BindingSource производительBindingSource;
        private LSkladDataSetTableAdapters.ПроизводительTableAdapter производительTableAdapter;
        private System.Windows.Forms.Button InsFormPharm;
        private System.Windows.Forms.Button InsFormPharmFalse;
    }
}