namespace KursovayaDataBase
{
    partial class InsPackage
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
            this.packageName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsFormPackage = new System.Windows.Forms.Button();
            this.InsFormPackageFalse = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(420, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 64);
            this.panel2.TabIndex = 3;
            // 
            // packageName
            // 
            this.packageName.Location = new System.Drawing.Point(282, 103);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(121, 20);
            this.packageName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Укажите название вида упаковки";
            // 
            // InsFormPackage
            // 
            this.InsFormPackage.BackColor = System.Drawing.Color.White;
            this.InsFormPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormPackage.Location = new System.Drawing.Point(76, 152);
            this.InsFormPackage.Name = "InsFormPackage";
            this.InsFormPackage.Size = new System.Drawing.Size(106, 35);
            this.InsFormPackage.TabIndex = 4;
            this.InsFormPackage.Text = "Добавить";
            this.InsFormPackage.UseVisualStyleBackColor = false;
            this.InsFormPackage.Click += new System.EventHandler(this.InsFormPackage_Click);
            // 
            // InsFormPackageFalse
            // 
            this.InsFormPackageFalse.BackColor = System.Drawing.Color.White;
            this.InsFormPackageFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormPackageFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormPackageFalse.Location = new System.Drawing.Point(230, 152);
            this.InsFormPackageFalse.Name = "InsFormPackageFalse";
            this.InsFormPackageFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormPackageFalse.TabIndex = 5;
            this.InsFormPackageFalse.Text = "Отмена";
            this.InsFormPackageFalse.UseVisualStyleBackColor = false;
            this.InsFormPackageFalse.Click += new System.EventHandler(this.InsFormPackageFalse_Click);
            // 
            // InsPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(420, 196);
            this.Controls.Add(this.packageName);
            this.Controls.Add(this.InsFormPackageFalse);
            this.Controls.Add(this.InsFormPackage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsPackage";
            this.Text = "InsPackage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox packageName;
        private System.Windows.Forms.Button InsFormPackage;
        private System.Windows.Forms.Button InsFormPackageFalse;
    }
}