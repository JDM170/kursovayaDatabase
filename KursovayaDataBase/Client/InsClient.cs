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
    public partial class InsClient : Form
    {
        public InsClient()
        {
            InitializeComponent();
        }

        private void InsClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet.Город);

        }

        private void InsFormClient_Click(object sender, EventArgs e)
        {

            String NameFieldClient = nameFieldClient.Text;
            String StreetFieldClient = streetFieldClient.Text;
            var House = int.Parse(numberHouseFieldClient.Text);
            var Campus = int.Parse(numberCampusFieldClient.Text);
            var Office = int.Parse(numberOfficeFieldClient.Text);
            String phone = phoneFieldClient.Text;
            String inn = innFieldClient.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Улица` (`Название`) VALUES (`@StreetField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());
            command.Parameters.Add("@StreetField", OleDbType.VarChar).Value = StreetFieldClient;

            command.ExecuteNonQuery();

            query = "SELECT MAX(`ID Улицы`) as MaxID FROM `Улица`";

            command = new OleDbCommand(query, LSklad.getConnection());
            string result = null;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
                result = Convert.ToString(reader["MaxID"]);

            query = "INSERT INTO `Клиент` (`ID Города`,`ID Улицы`,`Дом`,`Название`,`Корпус`,`Офис`,`Телефон`,`ИНН`) " +
                "VALUES (`@InsertIDCity`,`@InsertIDStreet`,`@House`,`@NameField`,`@Campus`,`@Office`,`@Phone`,`@INN`)";
            command = new OleDbCommand(query, LSklad.getConnection());
       
            command.Parameters.Add("@InsertIDCity", OleDbType.Integer).Value = CitycomboBoxField.SelectedValue;
            command.Parameters.Add("@InsertIDStreet", OleDbType.Integer).Value = result;
            command.Parameters.Add("@House", OleDbType.Integer).Value = House;
            command.Parameters.Add("@NameField", OleDbType.VarChar).Value = NameFieldClient;
            command.Parameters.Add("@Campus", OleDbType.Integer).Value = Campus;
            command.Parameters.Add("@Office", OleDbType.Integer).Value = Office;
            command.Parameters.Add("@Phone", OleDbType.VarChar).Value = phone;
            command.Parameters.Add("@INN", OleDbType.VarChar).Value = inn;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsFormFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
