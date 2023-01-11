namespace KursovayaDataBase
{
    partial class DelSupplies
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.поставщикTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.ПоставщикTableAdapter();
            this.DelFormSupplies = new System.Windows.Forms.Button();
            this.DelFormSuppliesFalse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 76);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 67);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.поставщикBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID Поставщика";
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.lSkladDataSet;
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите поставщика";
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // DelFormSupplies
            // 
            this.DelFormSupplies.BackColor = System.Drawing.Color.White;
            this.DelFormSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormSupplies.Location = new System.Drawing.Point(59, 170);
            this.DelFormSupplies.Name = "DelFormSupplies";
            this.DelFormSupplies.Size = new System.Drawing.Size(106, 35);
            this.DelFormSupplies.TabIndex = 5;
            this.DelFormSupplies.Text = "Удалить";
            this.DelFormSupplies.UseVisualStyleBackColor = false;
            this.DelFormSupplies.Click += new System.EventHandler(this.DelFormSupplies_Click);
            // 
            // DelFormSuppliesFalse
            // 
            this.DelFormSuppliesFalse.BackColor = System.Drawing.Color.White;
            this.DelFormSuppliesFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormSuppliesFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormSuppliesFalse.Location = new System.Drawing.Point(225, 170);
            this.DelFormSuppliesFalse.Name = "DelFormSuppliesFalse";
            this.DelFormSuppliesFalse.Size = new System.Drawing.Size(105, 35);
            this.DelFormSuppliesFalse.TabIndex = 0;
            this.DelFormSuppliesFalse.Text = "Отмена";
            this.DelFormSuppliesFalse.UseVisualStyleBackColor = false;
            this.DelFormSuppliesFalse.Click += new System.EventHandler(this.DelFormSuppliesFalse_Click);
            // 
            // DelSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(390, 227);
            this.Controls.Add(this.DelFormSuppliesFalse);
            this.Controls.Add(this.DelFormSupplies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DelSupplies";
            this.Text = "DelSupplies";
            this.Load += new System.EventHandler(this.DelSupplies_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private LSkladDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.Button DelFormSupplies;
        private System.Windows.Forms.Button DelFormSuppliesFalse;
    }
}