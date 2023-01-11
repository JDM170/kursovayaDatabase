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
    public partial class InsBank : Form
    {
        public InsBank()
        {
            InitializeComponent();
        }

        private void InsFormBank_Click(object sender, EventArgs e)
        {
            String bank = bankName.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Банки` (`Название`) VALUES (`@bankField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@bankField", OleDbType.VarChar).Value = bank;

            command.ExecuteNonQuery();

            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormBankFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
