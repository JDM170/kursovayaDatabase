namespace KursovayaDataBase
{
    partial class DelNakladnaya
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
            this.накладнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладнаяTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.НакладнаяTableAdapter();
            this.DelButtonNak = new System.Windows.Forms.Button();
            this.DelButtonNakFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 76);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 63);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите пор.номер накладной";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.накладнаяBindingSource;
            this.comboBox1.DisplayMember = "ID Накладной";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "ID Накладной";
            // 
            // lSkladDataSet
            // 
            this.lSkladDataSet.DataSetName = "LSkladDataSet";
            this.lSkladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладнаяBindingSource
            // 
            this.накладнаяBindingSource.DataMember = "Накладная";
            this.накладнаяBindingSource.DataSource = this.lSkladDataSet;
            // 
            // накладнаяTableAdapter
            // 
            this.накладнаяTableAdapter.ClearBeforeFill = true;
            // 
            // DelButtonNak
            // 
            this.DelButtonNak.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonNak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButtonNak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonNak.Location = new System.Drawing.Point(48, 166);
            this.DelButtonNak.Name = "DelButtonNak";
            this.DelButtonNak.Size = new System.Drawing.Size(111, 38);
            this.DelButtonNak.TabIndex = 7;
            this.DelButtonNak.Text = "Удалить";
            this.DelButtonNak.UseVisualStyleBackColor = false;
            this.DelButtonNak.Click += new System.EventHandler(this.DelButtonNak_Click);
            // 
            // DelButtonNakFalse
            // 
            this.DelButtonNakFalse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelButtonNakFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelButtonNakFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButtonNakFalse.Location = new System.Drawing.Point(210, 166);
            this.DelButtonNakFalse.Name = "DelButtonNakFalse";
            this.DelButtonNakFalse.Size = new System.Drawing.Size(111, 38);
            this.DelButtonNakFalse.TabIndex = 8;
            this.DelButtonNakFalse.Text = "Отмена";
            this.DelButtonNakFalse.UseVisualStyleBackColor = false;
            this.DelButtonNakFalse.Click += new System.EventHandler(this.DelButtonNakFalse_Click);
            // 
            // DelNakladnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 216);
            this.Controls.Add(this.DelButtonNakFalse);
            this.Controls.Add(this.DelButtonNak);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DelNakladnaya";
            this.Text = "DelNakladnaya";
            this.Load += new System.EventHandler(this.DelNakladnaya_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаяBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource накладнаяBindingSource;
        private LSkladDataSetTableAdapters.НакладнаяTableAdapter накладнаяTableAdapter;
        private System.Windows.Forms.Button DelButtonNak;
        private System.Windows.Forms.Button DelButtonNakFalse;
    }
}