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
    public partial class InsNakladnaya : Form
    {
        public InsNakladnaya()
        {
            InitializeComponent();
        }

        private void InsNakladnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lSkladDataSet.Поставщик);
        }

        private void InsButtonNak_Click(object sender, EventArgs e)
        {
            var Count = int.Parse(textBox1.Text);

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Накладная` (`ID Поставщика`,`ID Лекарства`,`Количество`) VALUES (`@InsertIDPost`,`@InsertIDPharm`,`@Count`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@InsertIDPost", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@InsertIDPharm", OleDbType.Integer).Value = comboBox2.SelectedValue;
            command.Parameters.Add("@Count", OleDbType.Integer).Value = Count;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();

            this.Close();
        }

        private void InsButtonNakFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
