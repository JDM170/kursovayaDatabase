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
    public partial class DelPackage : Form
    {
        public DelPackage()
        {
            InitializeComponent();
        }

        private void DelPackage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Вид_упаковки". При необходимости она может быть перемещена или удалена.
            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
        }

        private void DelFormPackage_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Вид упаковки` WHERE `ID Вида упаковки`= @deleteIDPackage";

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDPackage", OleDbType.Integer).Value = comboBox1.SelectedValue;

            command.ExecuteNonQuery();

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFormPackageFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
