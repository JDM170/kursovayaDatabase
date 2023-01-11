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
    public partial class DelSupplies : Form
    {
        public DelSupplies()
        {
            InitializeComponent();
        }

        private void DelSupplies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DelSupplies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lSkladDataSet.Поставщик);

        }

        private void DelFormSupplies_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "SELECT (`ID Улицы`) as StreetID FROM `Поставщик` WHERE `ID Поставщика` = @deleteIDSupplies";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDSupplies", OleDbType.Integer).Value = comboBox1.SelectedValue;
            string result = null;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                result = Convert.ToString(reader["StreetID"]);

            query = "DELETE FROM `Улица` WHERE `ID Улицы` = @deleteIDStreet";

            command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDStreet", OleDbType.Integer).Value = result;

            command.ExecuteNonQuery();

            query = "DELETE FROM `Поставщик` WHERE `ID Поставщика`= @deleteIDSupplies";

            command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDSupplies", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();
            this.Close();
        }



        private void DelFormSuppliesFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
