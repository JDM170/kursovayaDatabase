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
    public partial class DelCity : Form
    {
        public DelCity()
        {
            InitializeComponent();
        }

        private void DelCity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet.Город);
        }

        private void DelFormCity_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Город` WHERE `ID Города`= @deleteIDCity"; 

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDCity", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFormCityFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
