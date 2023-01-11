namespace KursovayaDataBase
{
    partial class InsCategory
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
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsFormCategory = new System.Windows.Forms.Button();
            this.InsFormCategoryFalse = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.categoryName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 64);
            this.panel2.TabIndex = 3;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(231, 16);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(121, 20);
            this.categoryName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Укажите название категории";
            // 
            // InsFormCategory
            // 
            this.InsFormCategory.BackColor = System.Drawing.Color.White;
            this.InsFormCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormCategory.Location = new System.Drawing.Point(59, 152);
            this.InsFormCategory.Name = "InsFormCategory";
            this.InsFormCategory.Size = new System.Drawing.Size(106, 35);
            this.InsFormCategory.TabIndex = 4;
            this.InsFormCategory.Text = "Добавить";
            this.InsFormCategory.UseVisualStyleBackColor = false;
            this.InsFormCategory.Click += new System.EventHandler(this.InsFormCategory_Click);
            // 
            // InsFormCategoryFalse
            // 
            this.InsFormCategoryFalse.BackColor = System.Drawing.Color.White;
            this.InsFormCategoryFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsFormCategoryFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsFormCategoryFalse.Location = new System.Drawing.Point(213, 152);
            this.InsFormCategoryFalse.Name = "InsFormCategoryFalse";
            this.InsFormCategoryFalse.Size = new System.Drawing.Size(106, 35);
            this.InsFormCategoryFalse.TabIndex = 5;
            this.InsFormCategoryFalse.Text = "Отмена";
            this.InsFormCategoryFalse.UseVisualStyleBackColor = false;
            this.InsFormCategoryFalse.Click += new System.EventHandler(this.InsFormCategoryFalse_Click);
            // 
            // InsCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(389, 196);
            this.Controls.Add(this.InsFormCategoryFalse);
            this.Controls.Add(this.InsFormCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InsCategory";
            this.Text = "InsCategory";
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
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Button InsFormCategory;
        private System.Windows.Forms.Button InsFormCategoryFalse;
    }
}