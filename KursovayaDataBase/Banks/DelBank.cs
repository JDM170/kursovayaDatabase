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
    public partial class DelBank : Form
    {
        public DelBank()
        {
            InitializeComponent();
        }

        private void DelBank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Банки". При необходимости она может быть перемещена или удалена.
            this.банкиTableAdapter.Fill(this.lSkladDataSet.Банки);
        }

        private void DelFormBank_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Банки` WHERE `ID Банка`= @deleteIDBank";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDBank", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFormBankFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
