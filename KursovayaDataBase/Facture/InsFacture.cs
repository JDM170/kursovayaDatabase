using System;
using System.Collections;
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
    public partial class InsFacture : Form
    {
        public InsFacture()
        {
            InitializeComponent();
        }

        private void InsFacture_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.lSkladDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.lSkladDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);

        }

        private void InsButton_Click(object sender, EventArgs e)
        {
            var Count = int.Parse(textBox1.Text);

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Счет-Фактура` (`ID Лекарства`,`ID Сотрудника`,`ID Клиента`,`Количество`) VALUES (`@InsertIDPharm`,`@InsertIDStuff`,`@InsertIDClient`,`@Count`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@InsertIDPharm", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@InsertIDStuff", OleDbType.Integer).Value = comboBox2.SelectedValue;
            command.Parameters.Add("@InsertIDClient", OleDbType.Integer).Value = comboBox3.SelectedValue;
            command.Parameters.Add("@Count", OleDbType.Integer).Value = Count;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsButtonFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
