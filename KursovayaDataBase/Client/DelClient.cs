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
    public partial class DelClient : Form
    {
        public DelClient()
        {
            InitializeComponent();
        }

        private void DelClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.lSkladDataSet.Клиент);
        }

        private void DelClientButton_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query;
            OleDbCommand command;
            int streetID = 0;

            query = "SELECT (`ID Улицы`) as StreetID FROM `Клиент` WHERE `ID Клиента` = @deleteIDClient";
            command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDClient", OleDbType.Integer).Value = comboBox1.SelectedValue;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                streetID = Convert.ToInt32(reader["StreetID"]);
            reader.Close();

            query = "DELETE FROM `Улица` WHERE `ID Улицы` = @deleteIDStreet";
            command.Parameters.Clear();
            command.CommandText = query;
            command.Parameters.Add("@deleteIDStreet", OleDbType.Integer).Value = streetID;
            command.ExecuteNonQuery();

            query = "DELETE FROM `Клиент` WHERE `ID Клиента`= @deleteIDClient";
            command.Parameters.Clear();
            command.CommandText = query;
            command.Parameters.Add("@deleteIDClient", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void DelClientButtonFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
