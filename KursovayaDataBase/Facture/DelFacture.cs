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
    public partial class DelFacture : Form
    {
        public DelFacture()
        {
            InitializeComponent();
        }

        private void DelFacture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet._Счет_Фактура". При необходимости она может быть перемещена или удалена.
            this.счет_ФактураTableAdapter.Fill(this.lSkladDataSet._Счет_Фактура);
        }

        private void DelFactureButton_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Счет-Фактура` WHERE `ID Фактуры`= @deleteIDFacture";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDFacture", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFactureButtonFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
