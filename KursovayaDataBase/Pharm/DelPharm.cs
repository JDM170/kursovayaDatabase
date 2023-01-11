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
    public partial class DelPharm : Form
    {
        public DelPharm()
        {
            InitializeComponent();
        }

        private void DelPharm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DelPharm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.lSkladDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Вид_упаковки". При необходимости она может быть перемещена или удалена.
            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);

        }

        private void DelFormPharm_Click(object sender, EventArgs e)
        {
            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "DELETE FROM `Цена` WHERE `ID Лекарства`= @deleteIDPharm AND `ID Вида упаковки`= @deleteIDType"; 

            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@deleteIDPharm", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@deleteIDType", OleDbType.Integer).Value = comboBox2.SelectedValue;

            command.ExecuteNonQuery();

            string secondquery = "DELETE FROM `Лекарства` WHERE `ID Лекарства`= @deleteIDPharm AND `ID Категории` = @deleteIDCategory AND `ID Производителя` = @deleteIDFactory";

            OleDbCommand secondcommand = new OleDbCommand(secondquery, LSklad.getConnection());
            secondcommand.Parameters.Add("@deleteIDPharm", OleDbType.Integer).Value = comboBox1.SelectedValue;
            secondcommand.Parameters.Add("@deleteIDCategory", OleDbType.Integer).Value = comboBox3.SelectedValue;
            secondcommand.Parameters.Add("@deleteIDFactory", OleDbType.Integer).Value = comboBox4.SelectedValue;

            secondcommand.ExecuteNonQuery();
            

            MessageBox.Show("Удаление успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void DelFormPharmFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
