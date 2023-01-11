namespace KursovayaDataBase
{
    partial class DelBank
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DelFormBank = new System.Windows.Forms.Button();
            this.DelFormBankFalse = new System.Windows.Forms.Button();
            this.банкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.БанкиTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 48);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.банкиBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID Банка";
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
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите банк";
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
            // DelFormBank
            // 
            this.DelFormBank.BackColor = System.Drawing.Color.White;
            this.DelFormBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormBank.Location = new System.Drawing.Point(57, 136);
            this.DelFormBank.Name = "DelFormBank";
            this.DelFormBank.Size = new System.Drawing.Size(106, 35);
            this.DelFormBank.TabIndex = 4;
            this.DelFormBank.Text = "Удалить";
            this.DelFormBank.UseVisualStyleBackColor = false;
            this.DelFormBank.Click += new System.EventHandler(this.DelFormBank_Click);
            // 
            // DelFormBankFalse
            // 
            this.DelFormBankFalse.BackColor = System.Drawing.Color.White;
            this.DelFormBankFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFormBankFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFormBankFalse.Location = new System.Drawing.Point(229, 136);
            this.DelFormBankFalse.Name = "DelFormBankFalse";
            this.DelFormBankFalse.Size = new System.Drawing.Size(106, 35);
            this.DelFormBankFalse.TabIndex = 5;
            this.DelFormBankFalse.Text = "Отмена";
            this.DelFormBankFalse.UseVisualStyleBackColor = false;
            this.DelFormBankFalse.Click += new System.EventHandler(this.DelFormBankFalse_Click);
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
            // DelBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 181);
            this.Controls.Add(this.DelFormBankFalse);
            this.Controls.Add(this.DelFormBank);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DelBank";
            this.Text = "DelBank";
            this.Load += new System.EventHandler(this.DelBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.Button DelFormBank;
        private System.Windows.Forms.Button DelFormBankFalse;
        private System.Windows.Forms.BindingSource банкиBindingSource;
        private LSkladDataSetTableAdapters.БанкиTableAdapter банкиTableAdapter;
    }
}