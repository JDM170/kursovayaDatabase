using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace KursovayaDataBase
{
    public partial class ExcelFacture : Form
    {
        public ExcelFacture()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.lSkladDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.lSkladDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet._Счет_Фактура". При необходимости она может быть перемещена или удалена.
            this.счет_ФактураTableAdapter.Fill(this.lSkladDataSet._Счет_Фактура);
        }

        private void ExcelFacture_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void ExcelButtonFacture_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    //if (helper.Open(filename: Path.Combine(Environment.CurrentDirectory, "D:\\KursovayaDataBase (TESTING)  V 3\\KursovayaDataBase\\Facture.xlsx")))
                    if (helper.Open(filepath: Path.Combine(Environment.CurrentDirectory, "D:\\GitHub\\kursovayaDatabase\\KursovayaDataBase\\Facture.xlsx")))
                    {
                        int IDFacture = Convert.ToInt32(comboBox1.SelectedValue);
                        int IDClient = 0;
                        int IDPharm = 0;
                        int IDStuff = 0;
                        int IDCity = 0;
                        int IDStreet = 0;
                        //string IDFacture = null;
                        string NameClient = null;
                        string CityClient = null;
                        string StreetClient = null;
                        string HouseClient = null;
                        string CampusClient = null;
                        string OfficeClient = null;
                        string INNClient = null;
                        string NamePharm = null;
                        string PricePharm = null;
                        string CountPharm = null;
                        string SurnameStuff = null;
                        
                        string query = null;
                        OleDbCommand command;
                        OleDbDataReader reader;

                        DataBase LSklad = new DataBase();

                        LSklad.Connect();
                        LSklad.openConnection();

                        query = "SELECT `ID Клиента` as IDClient FROM `Счет-Фактура` WHERE `ID Фактуры` = `@IDFacture`;";
                        command = new OleDbCommand(query, LSklad.getConnection());
                        command.Parameters.Add("@IDFacture", OleDbType.Integer).Value = IDFacture;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDClient = Convert.ToInt32(reader["IDClient"]);
                        reader.Close();


                        query = "SELECT `Название` as nameclient FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            NameClient = Convert.ToString(reader["nameclient"]);
                        reader.Close();


                        query = "SELECT `ID Города` as IDCity FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDCity = Convert.ToInt32(reader["IDCity"]);
                        reader.Close();


                        query = "SELECT `ID Улицы` as IDStreet FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDStreet = Convert.ToInt32(reader["IDStreet"]);
                        reader.Close();


                        query = "SELECT `Название` as city FROM `Город` WHERE `ID Города` = `@IDCity`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDCity;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CityClient = Convert.ToString(reader["city"]);
                        reader.Close();


                        query = "SELECT `Название` as street FROM `Улица` WHERE `ID Улицы` = `@IDStreet`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDStreet", OleDbType.Integer).Value = IDStreet;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            StreetClient = Convert.ToString(reader["street"]);
                        reader.Close();


                        query = "SELECT `Дом` as houseclient FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            HouseClient = Convert.ToString(reader["houseclient"]);
                        reader.Close();


                        query = "SELECT `Корпус` as campusclient FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CampusClient = Convert.ToString(reader["campusclient"]);
                        reader.Close();


                        query = "SELECT `Офис` as officeclient FROM `Клиент` WHERE `ID Клиента` = `IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            OfficeClient = Convert.ToString(reader["officeclient"]);
                        reader.Close();


                        query = "SELECT `ИНН` as innclient FROM `Клиент` WHERE `ID Клиента` = `@IDClient`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDClient", OleDbType.Integer).Value = IDClient;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            INNClient = Convert.ToString(reader["innclient"]);
                        reader.Close();


                        query = "SELECT `ID Лекарства` as IDPharm FROM `Счет-Фактура` WHERE `ID Фактуры` = `@IDFacture`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDFacture", OleDbType.Integer).Value = IDFacture;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDPharm = Convert.ToInt32(reader["IDPharm"]);
                        reader.Close();


                        query = "SELECT `Название` as namepharm FROM `Лекарства` WHERE `ID Лекарства` = `@IDPharm`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPharm", OleDbType.Integer).Value = IDPharm;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            NamePharm = Convert.ToString(reader["namepharm"]);
                        reader.Close();


                        query = "SELECT `Цена` as price FROM `Цена` WHERE `ID Лекарства` = `@IDPharm`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPharm", OleDbType.Integer).Value = IDPharm;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            PricePharm = Convert.ToString(reader["price"]);
                        reader.Close();


                        query = "SELECT `Количество` as CountPharm FROM `Счет-Фактура` WHERE `ID Фактуры` = `@IDFacture`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDFacture", OleDbType.Integer).Value = IDFacture;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CountPharm = Convert.ToString(reader["CountPharm"]);
                        reader.Close();


                        query = "SELECT `ID Сотрудника` as IDStuff FROM `Счет-Фактура` WHERE `ID Фактуры` = `@IDFacture`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDFacture", OleDbType.Integer).Value = IDFacture;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDStuff = Convert.ToInt32(reader["IDStuff"]);
                        reader.Close();


                        query = "SELECT `Фамилия` as surname FROM `Сотрудники` WHERE `ID Сотрудника` = `@IDStuff`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDStuff", OleDbType.Integer).Value = IDStuff;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            SurnameStuff = Convert.ToString(reader["surname"]);
                        reader.Close();


                        LSklad.closeConnection();

                        //IDFacture = Convert.ToString(IDClient);
                        String Time = Convert.ToString(DateTime.Now);

                        helper.Set(column: "E", row: 1, data: IDClient.ToString());
                        helper.Set(column: "G", row: 1, data: Time);
                        helper.Set(column: "B", row: 6, data: NameClient);
                        helper.Set(column: "C", row: 7, data: CityClient);
                        helper.Set(column: "E", row: 7, data: StreetClient);
                        helper.Set(column: "G", row: 7, data: HouseClient);
                        helper.Set(column: "I", row: 7, data: CampusClient);
                        helper.Set(column: "K", row: 7, data: OfficeClient);
                        helper.Set(column: "B", row: 8, data: INNClient);
                        helper.Set(column: "A", row: 13, data: NamePharm);
                        helper.Set(column: "D", row: 13, data: CountPharm);
                        helper.Set(column: "E", row: 13, data: PricePharm);
                        /*helper.Set(column: "B", row: 1, data: "");*/

                        helper.Save("D:\\GitHub\\kursovayaDatabase\\KursovayaDataBase\\FactureTest.xlsx");

                        MessageBox.Show("Успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Facture Ошибка работы с документом! Обратитесь к администратору!");
                        return;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void InsFactureButton_Click(object sender, EventArgs e)
        {
            InsFacture insfacture = new InsFacture();
            insfacture.ShowDialog();
            updateGridView();
        }

        private void DelFactureButton_Click(object sender, EventArgs e)
        {
            DelFacture delfacture = new DelFacture();
            delfacture.ShowDialog();
            updateGridView();
        }
    }
}

