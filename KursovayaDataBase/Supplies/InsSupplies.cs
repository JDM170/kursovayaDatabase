using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaDataBase
{
    public partial class InsSupplies : Form
    {
        public InsSupplies()
        {
            InitializeComponent();
        }

        private void InsSupplies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InsSupplies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Банки". При необходимости она может быть перемещена или удалена.
            this.банкиTableAdapter.Fill(this.lSkladDataSet.Банки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet.Город);

        }

        private void InsFormSupplies_Click(object sender, EventArgs e)
        {
            String NameFieldSupplies = nameFieldSupplies.Text;
            String StreetFieldSupplies = streetFieldSupplies.Text;
            var House = int.Parse(numberHouseFieldSupplies.Text);
            var Campus = int.Parse(numberCampusFieldSupplies.Text);
            var Office = int.Parse(numberOfficeFieldSupplies.Text);
            String score = scoreFieldSupplies.Text;
            String inn = innFieldSupplies.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Улица` (`Название`) VALUES (`@StreetField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@StreetField", OleDbType.VarChar).Value = StreetFieldSupplies;           

            command.ExecuteNonQuery();

            query = "SELECT MAX(`ID Улицы`) as MaxID FROM `Улица`";

            command = new OleDbCommand(query, LSklad.getConnection());
            string result = null;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                result = Convert.ToString(reader["MaxID"]);

            query = "INSERT INTO `Поставщик` (`Название`,`ID Города`,`ID Улицы`,`Дом`,`Корпус`,`Офис`,`ID Банка`,`Расчетный счет`,`ИНН`) " +
                "VALUES (`@NameField`,`@InsertIDCity`,`@InsertIDStreet`,`@House`,`@Campus`,`@Office`,`@InsertIDBank`,`@Score`,`@INN`)";
            command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@NameField", OleDbType.VarChar).Value = NameFieldSupplies;
            command.Parameters.Add("@InsertIDCity", OleDbType.Integer).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@InsertIDStreet", OleDbType.Integer).Value = result;
            command.Parameters.Add("@House", OleDbType.Integer).Value = House;
            command.Parameters.Add("@Campus", OleDbType.Integer).Value = Campus;
            command.Parameters.Add("@Office", OleDbType.Integer).Value = Office;
            command.Parameters.Add("@InsertIDBank", OleDbType.Integer).Value = comboBox2.SelectedValue;
            command.Parameters.Add("@ScoreField", OleDbType.VarChar).Value = score;
            command.Parameters.Add("@INNField", OleDbType.VarChar).Value = inn;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormSuppliesFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
