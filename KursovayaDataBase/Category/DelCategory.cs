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
    public partial class DelCategory : Form
    {
        public DelCategory()
        {
            InitializeComponent();
        }

        private void DelCategory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);
        }

        private void DelFormCategory_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Категория` WHERE `ID Категории`= @deleteIDCategory";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDCategory", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFormCategoryFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
