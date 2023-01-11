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
    public partial class InsPackage : Form
    {
        public InsPackage()
        {
            InitializeComponent();
        }

        private void InsFormPackage_Click(object sender, EventArgs e)
        {
            String package = packageName.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Вид упаковки` (`Название`) VALUES (`@packageField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@packageField", OleDbType.VarChar).Value = package;

            command.ExecuteNonQuery();

            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormPackageFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
