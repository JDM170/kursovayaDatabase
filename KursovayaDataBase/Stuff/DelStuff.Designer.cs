namespace KursovayaDataBase
{
    partial class DelStuff
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
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.сотрудникиTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.СотрудникиTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteStuffButton = new System.Windows.Forms.Button();
            this.DeleteStuffButtonFalse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 76);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(13, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 65);
            this.panel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.сотрудникиBindingSource;
            this.comboBox1.DisplayMember = "ID Сотрудника";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID Сотрудника";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите порядковый номер";
            // 
            // DeleteStuffButton
            // 
            this.DeleteStuffButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteStuffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteStuffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStuffButton.Location = new System.Drawing.Point(66, 165);
            this.DeleteStuffButton.Name = "DeleteStuffButton";
            this.DeleteStuffButton.Size = new System.Drawing.Size(95, 34);
            this.DeleteStuffButton.TabIndex = 7;
            this.DeleteStuffButton.Text = "Удалить";
            this.DeleteStuffButton.UseVisualStyleBackColor = false;
            this.DeleteStuffButton.Click += new System.EventHandler(this.DeleteStuffButton_Click);
            // 
            // DeleteStuffButtonFalse
            // 
            this.DeleteStuffButtonFalse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteStuffButtonFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteStuffButtonFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStuffButtonFalse.Location = new System.Drawing.Point(212, 165);
            this.DeleteStuffButtonFalse.Name = "DeleteStuffButtonFalse";
            this.DeleteStuffButtonFalse.Size = new System.Drawing.Size(95, 34);
            this.DeleteStuffButtonFalse.TabIndex = 8;
            this.DeleteStuffButtonFalse.Text = "Отмена";
            this.DeleteStuffButtonFalse.UseVisualStyleBackColor = false;
            this.DeleteStuffButtonFalse.Click += new System.EventHandler(this.DeleteStuffButtonFalse_Click);
            // 
            // DelStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 211);
            this.Controls.Add(this.DeleteStuffButtonFalse);
            this.Controls.Add(this.DeleteStuffButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DelStuff";
            this.Text = "DelStuff";
            this.Load += new System.EventHandler(this.DelStuff_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private LSkladDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteStuffButton;
        private System.Windows.Forms.Button DeleteStuffButtonFalse;
    }
}