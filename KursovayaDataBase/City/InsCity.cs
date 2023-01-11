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
    public partial class InsCity : Form
    {
        public InsCity()
        {
            InitializeComponent();
        }

        private void InsFormCity_Click(object sender, EventArgs e)
        {
            String city = cityName.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();


            string query = "INSERT INTO `Город` (`Название`) VALUES (`@cityField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@cityField", OleDbType.VarChar).Value = city;

            command.ExecuteNonQuery();

            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormCityFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
