using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaDataBase
{
    public partial class InsCategory : Form
    {
        public InsCategory()
        {
            InitializeComponent();
        }

        private void InsFormCategory_Click(object sender, EventArgs e)
        {
            String category = categoryName.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();


            string query = "INSERT INTO `Категория` (`Название`) VALUES (`@categoryField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@categoryField", OleDbType.VarChar).Value = category;

            command.ExecuteNonQuery();

            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormCategoryFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
