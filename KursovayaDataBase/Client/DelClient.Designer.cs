namespace KursovayaDataBase
{
    partial class DelClient
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
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSkladDataSet = new KursovayaDataBase.LSkladDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.клиентTableAdapter = new KursovayaDataBase.LSkladDataSetTableAdapters.КлиентTableAdapter();
            this.DelClientButton = new System.Windows.Forms.Button();
            this.DelClientButtonFalse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 76);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 77);
            this.panel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.клиентBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID Клиента";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.lSkladDataSet;
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
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите клиента";
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // DelClientButton
            // 
            this.DelClientButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelClientButton.Location = new System.Drawing.Point(51, 179);
            this.DelClientButton.Name = "DelClientButton";
            this.DelClientButton.Size = new System.Drawing.Size(107, 34);
            this.DelClientButton.TabIndex = 7;
            this.DelClientButton.Text = "Удалить";
            this.DelClientButton.UseVisualStyleBackColor = false;
            this.DelClientButton.Click += new System.EventHandler(this.DelClientButton_Click);
            // 
            // DelClientButtonFalse
            // 
            this.DelClientButtonFalse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelClientButtonFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelClientButtonFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelClientButtonFalse.Location = new System.Drawing.Point(210, 179);
            this.DelClientButtonFalse.Name = "DelClientButtonFalse";
            this.DelClientButtonFalse.Size = new System.Drawing.Size(107, 34);
            this.DelClientButtonFalse.TabIndex = 8;
            this.DelClientButtonFalse.Text = "Отмена";
            this.DelClientButtonFalse.UseVisualStyleBackColor = false;
            this.DelClientButtonFalse.Click += new System.EventHandler(this.DelClientButtonFalse_Click);
            // 
            // DelClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 234);
            this.Controls.Add(this.DelClientButtonFalse);
            this.Controls.Add(this.DelClientButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DelClient";
            this.Text = "DelClient";
            this.Load += new System.EventHandler(this.DelClient_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSkladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private LSkladDataSet lSkladDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private LSkladDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.Button DelClientButton;
        private System.Windows.Forms.Button DelClientButtonFalse;
    }
}