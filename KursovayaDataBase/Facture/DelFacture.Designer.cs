namespace KursovayaDataBase
{
    partial class DelFacture
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.счетФактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счет_ФактураTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.Счет_ФактураTableAdapter();
            this.DelFactureButton = new System.Windows.Forms.Button();
            this.DelFactureButtonFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление данных";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 76);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 56);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите пор.номер фактуры";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.счетФактураBindingSource;
            this.comboBox1.DisplayMember = "ID Фактуры";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "ID Фактуры";
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетФактураBindingSource
            // 
            this.счетФактураBindingSource.DataMember = "Счет-Фактура";
            this.счетФактураBindingSource.DataSource = this.lSkladDataSet;
            // 
            // счет_ФактураTableAdapter
            // 
            this.счет_ФактураTableAdapter.ClearBeforeFill = true;
            // 
            // DelFactureButton
            // 
            this.DelFactureButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelFactureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFactureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFactureButton.Location = new System.Drawing.Point(62, 151);
            this.DelFactureButton.Name = "DelFactureButton";
            this.DelFactureButton.Size = new System.Drawing.Size(104, 38);
            this.DelFactureButton.TabIndex = 6;
            this.DelFactureButton.Text = "Удалить";
            this.DelFactureButton.UseVisualStyleBackColor = false;
            this.DelFactureButton.Click += new System.EventHandler(this.DelFactureButton_Click);
            // 
            // DelFactureButtonFalse
            // 
            this.DelFactureButtonFalse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelFactureButtonFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFactureButtonFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelFactureButtonFalse.Location = new System.Drawing.Point(231, 151);
            this.DelFactureButtonFalse.Name = "DelFactureButtonFalse";
            this.DelFactureButtonFalse.Size = new System.Drawing.Size(104, 38);
            this.DelFactureButtonFalse.TabIndex = 7;
            this.DelFactureButtonFalse.Text = "Отмена";
            this.DelFactureButtonFalse.UseVisualStyleBackColor = false;
            this.DelFactureButtonFalse.Click += new System.EventHandler(this.DelFactureButtonFalse_Click);
            // 
            // DelFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 201);
            this.Controls.Add(this.DelFactureButtonFalse);
            this.Controls.Add(this.DelFactureButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DelFacture";
            this.Text = "DelFacture";
            this.Load += new System.EventHandler(this.DelFacture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетФактураBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource счетФактураBindingSource;
        private LSkladDataSetTableAdapters.Счет_ФактураTableAdapter счет_ФактураTableAdapter;
        private System.Windows.Forms.Button DelFactureButton;
        private System.Windows.Forms.Button DelFactureButtonFalse;
    }
}