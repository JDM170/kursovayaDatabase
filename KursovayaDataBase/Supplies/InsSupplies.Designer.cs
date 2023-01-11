namespace KursovayaDataBase
{
    partial class InsSupplies
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameFieldSupplies = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.городBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ГородTableAdapter();
            this.streetFieldSupplies = new System.Windows.Forms.TextBox();
            this.numberHouseFieldSupplies = new System.Windows.Forms.TextBox();
            this.numberCampusFieldSupplies = new System.Windows.Forms.TextBox();
            this.numberOfficeFieldSupplies = new System.Windows.Forms.TextBox();
            this.scoreFieldSupplies = new System.Windows.Forms.TextBox();
            this.innFieldSupplies = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.банкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.БанкиTableAdapter();
            this.InsFormSupplies = new System.Windows.Forms.Button();
            this.InsFormSuppliesFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.innFieldSupplies);
            this.panel2.Controls.Add(this.scoreFieldSupplies);
            this.panel2.Controls.Add(this.numberOfficeFieldSupplies);
            this.panel2.Controls.Add(this.numberCampusFieldSupplies);
            this.panel2.Controls.Add(this.numberHouseFieldSupplies);
            this.panel2.Controls.Add(this.streetFieldSupplies);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nameFieldSupplies);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 371);
            this.panel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Укажите улицу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Выберите город";
            // 
            // nameFieldSupplies
            // 
            this.nameFieldSupplies.Location = new System.Drawing.Point(214, 11);
            this.nameFieldSupplies.Name = "nameFieldSupplies";
            this.nameFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.nameFieldSupplies.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Укажите ИНН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Укажите расчетный счет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Укажите номер офиса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Укажите номер корпуса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Укажите номер дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите название";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Выберите банк";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.городBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID Города";
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // городBindingSource
            // 
            this.городBindingSource.DataMember = "Город";
            this.городBindingSource.DataSource = this.lSkladDataSet;
            // 
            // городTableAdapter
            // 
            this.городTableAdapter.ClearBeforeFill = true;
            // 
            // streetFieldSupplies
            // 
            this.streetFieldSupplies.Location = new System.Drawing.Point(214, 90);
            this.streetFieldSupplies.Name = "streetFieldSupplies";
            this.streetFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.streetFieldSupplies.TabIndex = 12;
            // 
            // numberHouseFieldSupplies
            // 
            this.numberHouseFieldSupplies.Location = new System.Drawing.Point(214, 136);
            this.numberHouseFieldSupplies.Name = "numberHouseFieldSupplies";
            this.numberHouseFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.numberHouseFieldSupplies.TabIndex = 13;
            // 
            // numberCampusFieldSupplies
            // 
            this.numberCampusFieldSupplies.Location = new System.Drawing.Point(214, 176);
            this.numberCampusFieldSupplies.Name = "numberCampusFieldSupplies";
            this.numberCampusFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.numberCampusFieldSupplies.TabIndex = 14;
            // 
            // numberOfficeFieldSupplies
            // 
            this.numberOfficeFieldSupplies.Location = new System.Drawing.Point(214, 217);
            this.numberOfficeFieldSupplies.Name = "numberOfficeFieldSupplies";
            this.numberOfficeFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.numberOfficeFieldSupplies.TabIndex = 15;
            // 
            // scoreFieldSupplies
            // 
            this.scoreFieldSupplies.Location = new System.Drawing.Point(214, 295);
            this.scoreFieldSupplies.Name = "scoreFieldSupplies";
            this.scoreFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.scoreFieldSupplies.TabIndex = 16;
            // 
            // innFieldSupplies
            // 
            this.innFieldSupplies.Location = new System.Drawing.Point(214, 335);
            this.innFieldSupplies.Name = "innFieldSupplies";
            this.innFieldSupplies.Size = new System.Drawing.Size(132, 20);
            this.innFieldSupplies.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.банкиBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "ID Банка";
            // 
            // банкиBindingSource
            // 
            this.банкиBindingSource.DataMember = "Банки";
            this.банкиBindingSource.DataSource = this.lSkladDataSet;
            // 
            // банкиTableAdapter
            // 
            this.банкиTableAdapter.ClearBeforeFill = true;
            // 
            // InsFormSupplies
            // 
            this.InsFormSupplies.BackColor = System.Drawing.Color.White;
            this.InsFormSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormSupplies.Location = new System.Drawing.Point(56, 475);
            this.InsFormSupplies.Name = "InsFormSupplies";
            this.InsFormSupplies.Size = new System.Drawing.Size(106, 35);
            this.InsFormSupplies.TabIndex = 5;
            this.InsFormSupplies.Text = "Добавить";
            this.InsFormSupplies.UseVisualStyleBackColor = false;
            this.InsFormSupplies.Click += new System.EventHandler(this.InsFormSupplies_Click);
            // 
            // InsFormSuppliesFalse
            // 
            this.InsFormSuppliesFalse.BackColor = System.Drawing.Color.White;
            this.InsFormSuppliesFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormSuppliesFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormSuppliesFalse.Location = new System.Drawing.Point(227, 475);
            this.InsFormSuppliesFalse.Name = "InsFormSuppliesFalse";
            this.InsFormSuppliesFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormSuppliesFalse.TabIndex = 6;
            this.InsFormSuppliesFalse.Text = "Отмена";
            this.InsFormSuppliesFalse.UseVisualStyleBackColor = false;
            this.InsFormSuppliesFalse.Click += new System.EventHandler(this.InsFormSuppliesFalse_Click);
            // 
            // InsSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(388, 522);
            this.Controls.Add(this.InsFormSuppliesFalse);
            this.Controls.Add(this.InsFormSupplies);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsSupplies";
            this.Text = "InsSupplies";
            this.Load += new System.EventHandler(this.InsSupplies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameFieldSupplies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource городBindingSource;
        private LSkladDataSetTableAdapters.ГородTableAdapter городTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox innFieldSupplies;
        private System.Windows.Forms.TextBox scoreFieldSupplies;
        private System.Windows.Forms.TextBox numberOfficeFieldSupplies;
        private System.Windows.Forms.TextBox numberCampusFieldSupplies;
        private System.Windows.Forms.TextBox numberHouseFieldSupplies;
        private System.Windows.Forms.TextBox streetFieldSupplies;
        private System.Windows.Forms.BindingSource банкиBindingSource;
        private LSkladDataSetTableAdapters.БанкиTableAdapter банкиTableAdapter;
        private System.Windows.Forms.Button InsFormSupplies;
        private System.Windows.Forms.Button InsFormSuppliesFalse;
    }
}