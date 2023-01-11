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
    public partial class InsStuff : Form
    {
        public InsStuff()
        {
            InitializeComponent();
        }

        private void InsertStuffButton_Click(object sender, EventArgs e)
        {
            String NameFieldStuff = nameField.Text;
            String SurnameFieldStuff = surnameField.Text;
            String SecondnameFieldStuff = secondnameField.Text;
            String PositionFieldStuff = positionField.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();

            string query = "INSERT INTO `Сотрудники` (`Имя`,`Фамилия`,`Отчество`,`Должность`) " +
                "VALUES (`@NameField`, `@SurnameField`,`@SecondnameField`,`@PositionField`)";
            OleDbCommand command = new OleDbCommand(query, LSklad.getConnection());

            command.Parameters.Add("@NameField", OleDbType.VarChar).Value = NameFieldStuff;
            command.Parameters.Add("@SurnameField", OleDbType.VarChar).Value = SurnameFieldStuff;
            command.Parameters.Add("@SecondnameField", OleDbType.VarChar).Value = SecondnameFieldStuff;
            command.Parameters.Add("@PositionField", OleDbType.VarChar).Value = PositionFieldStuff;

            command.ExecuteNonQuery();
            MessageBox.Show("Добавлено успешно!");

            LSklad.closeConnection();
            this.Close();
        }

        private void InsertStuffButtonFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
