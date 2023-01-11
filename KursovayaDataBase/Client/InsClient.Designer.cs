namespace KursovayaDataBase
{
    partial class InsClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameFieldClient = new System.Windows.Forms.TextBox();
            this.streetFieldClient = new System.Windows.Forms.TextBox();
            this.numberHouseFieldClient = new System.Windows.Forms.TextBox();
            this.numberCampusFieldClient = new System.Windows.Forms.TextBox();
            this.numberOfficeFieldClient = new System.Windows.Forms.TextBox();
            this.phoneFieldClient = new System.Windows.Forms.TextBox();
            this.innFieldClient = new System.Windows.Forms.TextBox();
            this.CitycomboBoxField = new System.Windows.Forms.ComboBox();
            this.InsFormClient = new System.Windows.Forms.Button();
            this.InsFormFalse = new System.Windows.Forms.Button();
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.городBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ГородTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 76);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CitycomboBoxField);
            this.panel2.Controls.Add(this.innFieldClient);
            this.panel2.Controls.Add(this.phoneFieldClient);
            this.panel2.Controls.Add(this.numberOfficeFieldClient);
            this.panel2.Controls.Add(this.numberCampusFieldClient);
            this.panel2.Controls.Add(this.numberHouseFieldClient);
            this.panel2.Controls.Add(this.streetFieldClient);
            this.panel2.Controls.Add(this.nameFieldClient);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 311);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите название";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Выберите город";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Укажите улицу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Укажите номер дома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Укажите номер корпуса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Укажите номер офиса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Укажите телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Укажите ИНН";
            // 
            // nameFieldClient
            // 
            this.nameFieldClient.Location = new System.Drawing.Point(214, 9);
            this.nameFieldClient.Name = "nameFieldClient";
            this.nameFieldClient.Size = new System.Drawing.Size(132, 20);
            this.nameFieldClient.TabIndex = 16;
            // 
            // streetFieldClient
            // 
            this.streetFieldClient.Location = new System.Drawing.Point(214, 80);
            this.streetFieldClient.Name = "streetFieldClient";
            this.streetFieldClient.Size = new System.Drawing.Size(132, 20);
            this.streetFieldClient.TabIndex = 17;
            // 
            // numberHouseFieldClient
            // 
            this.numberHouseFieldClient.Location = new System.Drawing.Point(214, 115);
            this.numberHouseFieldClient.Name = "numberHouseFieldClient";
            this.numberHouseFieldClient.Size = new System.Drawing.Size(132, 20);
            this.numberHouseFieldClient.TabIndex = 18;
            // 
            // numberCampusFieldClient
            // 
            this.numberCampusFieldClient.Location = new System.Drawing.Point(214, 152);
            this.numberCampusFieldClient.Name = "numberCampusFieldClient";
            this.numberCampusFieldClient.Size = new System.Drawing.Size(132, 20);
            this.numberCampusFieldClient.TabIndex = 19;
            // 
            // numberOfficeFieldClient
            // 
            this.numberOfficeFieldClient.Location = new System.Drawing.Point(214, 191);
            this.numberOfficeFieldClient.Name = "numberOfficeFieldClient";
            this.numberOfficeFieldClient.Size = new System.Drawing.Size(132, 20);
            this.numberOfficeFieldClient.TabIndex = 20;
            // 
            // phoneFieldClient
            // 
            this.phoneFieldClient.Location = new System.Drawing.Point(214, 229);
            this.phoneFieldClient.Name = "phoneFieldClient";
            this.phoneFieldClient.Size = new System.Drawing.Size(132, 20);
            this.phoneFieldClient.TabIndex = 21;
            // 
            // innFieldClient
            // 
            this.innFieldClient.Location = new System.Drawing.Point(214, 264);
            this.innFieldClient.Name = "innFieldClient";
            this.innFieldClient.Size = new System.Drawing.Size(132, 20);
            this.innFieldClient.TabIndex = 22;
            // 
            // CitycomboBoxField
            // 
            this.CitycomboBoxField.DataSource = this.городBindingSource;
            this.CitycomboBoxField.DisplayMember = "Название";
            this.CitycomboBoxField.FormattingEnabled = true;
            this.CitycomboBoxField.Location = new System.Drawing.Point(214, 44);
            this.CitycomboBoxField.Name = "CitycomboBoxField";
            this.CitycomboBoxField.Size = new System.Drawing.Size(132, 21);
            this.CitycomboBoxField.TabIndex = 23;
            this.CitycomboBoxField.ValueMember = "ID Города";
            // 
            // InsFormClient
            // 
            this.InsFormClient.BackColor = System.Drawing.Color.White;
            this.InsFormClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormClient.Location = new System.Drawing.Point(48, 403);
            this.InsFormClient.Name = "InsFormClient";
            this.InsFormClient.Size = new System.Drawing.Size(106, 35);
            this.InsFormClient.TabIndex = 24;
            this.InsFormClient.Text = "Добавить";
            this.InsFormClient.UseVisualStyleBackColor = false;
            this.InsFormClient.Click += new System.EventHandler(this.InsFormClient_Click);
            // 
            // InsFormFalse
            // 
            this.InsFormFalse.BackColor = System.Drawing.Color.White;
            this.InsFormFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormFalse.Location = new System.Drawing.Point(228, 403);
            this.InsFormFalse.Name = "InsFormFalse";
            this.InsFormFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormFalse.TabIndex = 25;
            this.InsFormFalse.Text = "Отмена";
            this.InsFormFalse.UseVisualStyleBackColor = false;
            this.InsFormFalse.Click += new System.EventHandler(this.InsFormFalse_Click);
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
            // InsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.InsFormFalse);
            this.Controls.Add(this.InsFormClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsClient";
            this.Text = "InsClient";
            this.Load += new System.EventHandler(this.InsClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox innFieldClient;
        private System.Windows.Forms.TextBox phoneFieldClient;
        private System.Windows.Forms.TextBox numberOfficeFieldClient;
        private System.Windows.Forms.TextBox numberCampusFieldClient;
        private System.Windows.Forms.TextBox numberHouseFieldClient;
        private System.Windows.Forms.TextBox streetFieldClient;
        private System.Windows.Forms.TextBox nameFieldClient;
        private System.Windows.Forms.ComboBox CitycomboBoxField;
        private System.Windows.Forms.Button InsFormClient;
        private System.Windows.Forms.Button InsFormFalse;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource городBindingSource;
        private LSkladDataSetTableAdapters.ГородTableAdapter городTableAdapter;
    }
}