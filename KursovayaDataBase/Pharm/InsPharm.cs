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
    public partial class InsPharm : Form
    {
        public InsPharm()
        {
            InitializeComponent();
        }
        private void InsPharm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InsPharm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.lSkladDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Вид_упаковки". При необходимости она может быть перемещена или удалена.
            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);

        }

        private void InsFormPharm_Click(object sender, EventArgs e)
        {
            String NameFieldPharm = nameFieldPharm.Text;
            var Price = int.Parse(priceFieldPharm.Text);

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();


            string query = "INSERT INTO `Лекарства` (`Название`,`ID Категории`,`ID Производителя`) VALUES (`@NameField`,`@InsertIDCategory`,`@InsertIDFactory`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@NameField", OleDbType.VarChar).Value = NameFieldPharm;
            command.Parameters.Add("@InsertIDCategory", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@InsertIDFactory", OleDbType.Integer).Value = comboBox3.SelectedValue;

            command.ExecuteNonQuery();

            query = "SELECT MAX(`ID Лекарства`) as MaxID FROM `Лекарства`";

            command = new OleDbCommand(query, LSklad.getConnection());
            string result = null;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                result = Convert.ToString(reader["MaxID"]);

            query = "INSERT INTO `Цена` (`ID Лекарства`,`ID Вида упаковки`,`Цена`) VALUES (`@InsertIDPharmacy`,`@InsertIDType`,`@PriceField`)";
            command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@InsertIDPharmacy", OleDbType.Integer).Value = result;
            command.Parameters.Add("@InsertIDType", OleDbType.Integer).Value = comboBox2.SelectedValue;
            command.Parameters.Add("@PriceField", OleDbType.Integer).Value = Price;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
            /*Pharm pharm = new Pharm();
            pharm.dataGridView2.Update();*/
        }

        private void InsFormPharmFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
