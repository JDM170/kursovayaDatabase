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
    public partial class ExcelNakladnaya : Form
    {
        public ExcelNakladnaya()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lSkladDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this.lSkladDataSet.Накладная);
        }

        private void ExcelNakladnaya_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SaveExcelNakladnaya_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filepath: Path.Combine(Environment.CurrentDirectory, "D:\\GitHub\\kursovayaDatabase\\KursovayaDataBase\\NakladnayaExample.xlsx")))
                    {
                        int IDPost = 0;
                        int IDPharm = 0;
                        int IDCity = 0;
                        int IDStreet = 0;
                        int IDBank = 0;
                        string IDNakladnaya = null;
                        string NamePost = null;
                        string BankPost = null;
                        string CityPost = null;
                        string StreetPost = null;
                        string HousePost = null;
                        string CampusPost = null;
                        string OfficePost = null;
                        string INNPost = null;
                        string NamePharm = null;
                        string PricePharm = null;
                        string CountPharm = null;

                        DataBase LSklad = new DataBase();

                        LSklad.Connect();
                        LSklad.openConnection();

                        string query = null;
                        OleDbCommand command;
                        OleDbDataReader reader;


                        query = "SELECT `ID Поставщика` as IDPost FROM `Накладная` WHERE `ID Накладной` = `@InsertIDNakladnaya`;";
                        command = new OleDbCommand(query, LSklad.getConnection());
                        command.Parameters.Add("@InsertIDNakladnaya", OleDbType.Integer).Value = comboBox1.SelectedValue;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDPost = Convert.ToInt32(reader["IDPost"]);
                        reader.Close();
                        

                        query = "SELECT `Название` as namepost FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            NamePost = Convert.ToString(reader["namepost"]);
                        reader.Close();
                        

                        query = "SELECT `ID Банка` as IDBank FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDBank = Convert.ToInt32(reader["IDBank"]);
                        reader.Close();


                        query = "SELECT `Название` as bank FROM `Банки` WHERE `ID Банка` = `@IDBank`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDBank", OleDbType.Integer).Value = IDBank;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            BankPost = Convert.ToString(reader["bank"]);
                        reader.Close();


                        query = "SELECT `ID Города` as IDCity FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDCity = Convert.ToInt32(reader["IDCity"]);
                        reader.Close();


                        query = "SELECT `ID Улицы` as IDStreet FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            IDStreet = Convert.ToInt32(reader["IDStreet"]);
                        reader.Close();


                        query = "SELECT `Название` as cityName FROM `Город` WHERE `ID Города` = `@IDCity`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDCity", OleDbType.Integer).Value = IDCity;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CityPost = Convert.ToString(reader["cityName"]);
                        reader.Close();


                        query = "SELECT `Название` as streetName FROM `Улица` WHERE `ID Улицы` = `@IDStreet`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDStreet", OleDbType.Integer).Value = IDStreet;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            StreetPost = Convert.ToString(reader["streetName"]);
                        reader.Close();


                        query = "SELECT `Дом` as housepost FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            HousePost = Convert.ToString(reader["housepost"]);
                        reader.Close();
                        

                        query = "SELECT `Корпус` as campuspost FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CampusPost = Convert.ToString(reader["campuspost"]);
                        reader.Close();
                        

                        query = "SELECT `Офис` as officepost FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            OfficePost = Convert.ToString(reader["officepost"]);
                        reader.Close();
                       

                        query = "SELECT `ИНН` as innpost FROM `Поставщик` WHERE `ID Поставщика` = `@IDPost`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@IDPost", OleDbType.Integer).Value = IDPost;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            INNPost = Convert.ToString(reader["innpost"]);
                        reader.Close();
                        

                        query = "SELECT `ID Лекарства` as IDPharm FROM `Накладная` WHERE `ID Накладной` = `@InsertIDNakladnaya`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@InsertIDNakladnaya", OleDbType.Integer).Value = comboBox1.SelectedValue;
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
                        

                        query = "SELECT `Количество` as CountPharm FROM `Накладная` WHERE `ID Накладной` = `@InsertIDNakladnaya`;";
                        command.Parameters.Clear();
                        command.CommandText = query;
                        command.Parameters.Add("@InsertIDNakladnaya", OleDbType.Integer).Value = comboBox1.SelectedValue;
                        reader = command.ExecuteReader();
                        while (reader.Read())
                            CountPharm = Convert.ToString(reader["CountPharm"]);
                        reader.Close();
                        

                        LSklad.closeConnection();

                        IDNakladnaya = Convert.ToString(IDPost);
                        String Time = Convert.ToString(DateTime.Now);

                        helper.Set(column: "F", row: 3, data: IDNakladnaya);
                        helper.Set(column: "G", row: 3, data: Time);
                        helper.Set(column: "D", row: 13, data: NamePharm);
                        helper.Set(column: "J", row: 13, data: CountPharm);
                        helper.Set(column: "L", row: 13, data: PricePharm);
                        helper.Set(column: "D", row: 9, data: BankPost);
                        helper.Set(column: "H", row: 5, data: CityPost);
                        helper.Set(column: "J", row: 5, data: StreetPost);
                        helper.Set(column: "L", row: 5, data: HousePost);
                        helper.Set(column: "N", row: 5, data: CampusPost);
                        helper.Set(column: "P", row: 5, data: OfficePost);
                        helper.Set(column: "R", row: 5, data: INNPost);

                        /*helper.Set(column: "B", row: 1, data: "");*/

                        helper.Save("D:\\GitHub\\kursovayaDatabase\\KursovayaDataBase\\nakladnayaTest.xlsx");

                        MessageBox.Show("Успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка работы с документом! Обратитесь к администратору!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void InsButtonNakladnaya_Click(object sender, EventArgs e)
        {
            InsNakladnaya insnak = new InsNakladnaya();
            insnak.ShowDialog();
            updateGridView();
        }

        private void DelButtonNakladnaya_Click(object sender, EventArgs e)
        {
            DelNakladnaya delnak = new DelNakladnaya();
            delnak.ShowDialog();
            updateGridView();
        }
    }
}
