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
    public partial class DelNakladnaya : Form
    {
        public DelNakladnaya()
        {
            InitializeComponent();
        }

        private void DelNakladnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this.lSkladDataSet.Накладная);
        }

        private void DelButtonNak_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Накладная` WHERE `ID Накладной`= @deleteIDNakladnaya";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDNakladnaya", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelButtonNakFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
