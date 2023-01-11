namespace KursovayaDataBase
{
    partial class InsCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsFormCity = new System.Windows.Forms.Button();
            this.InsFormCityFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.cityName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 64);
            this.panel2.TabIndex = 3;
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(231, 16);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(121, 20);
            this.cityName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Укажите название города";
            // 
            // InsFormCity
            // 
            this.InsFormCity.BackColor = System.Drawing.Color.White;
            this.InsFormCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormCity.Location = new System.Drawing.Point(59, 152);
            this.InsFormCity.Name = "InsFormCity";
            this.InsFormCity.Size = new System.Drawing.Size(106, 35);
            this.InsFormCity.TabIndex = 4;
            this.InsFormCity.Text = "Добавить";
            this.InsFormCity.UseVisualStyleBackColor = false;
            this.InsFormCity.Click += new System.EventHandler(this.InsFormCity_Click);
            // 
            // InsFormCityFalse
            // 
            this.InsFormCityFalse.BackColor = System.Drawing.Color.White;
            this.InsFormCityFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormCityFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormCityFalse.Location = new System.Drawing.Point(213, 152);
            this.InsFormCityFalse.Name = "InsFormCityFalse";
            this.InsFormCityFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormCityFalse.TabIndex = 5;
            this.InsFormCityFalse.Text = "Отмена";
            this.InsFormCityFalse.UseVisualStyleBackColor = false;
            this.InsFormCityFalse.Click += new System.EventHandler(this.InsFormCityFalse_Click);
            // 
            // InsCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 196);
            this.Controls.Add(this.InsFormCityFalse);
            this.Controls.Add(this.InsFormCity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsCity";
            this.Text = "InsCity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Button InsFormCity;
        private System.Windows.Forms.Button InsFormCityFalse;
    }
}