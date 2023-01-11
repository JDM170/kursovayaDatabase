using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaDataBase
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public Boolean isLoginExist()
        {
            String reglogin = regloginField.Text;

            DataBase LSklad = new DataBase();
            LSklad.Connect();
            LSklad.openConnection();

            DataTable table = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Authorize` WHERE `login` = @urL", LSklad.getConnection());
            command.Parameters.Add("@urL", OleDbType.VarChar).Value = reglogin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            LSklad.closeConnection();

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован!");
                return true;
            }
            else
                return false;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            String reglogin = regloginField.Text;
            String regpass = regpassField.Text;

            DataBase LSklad = new DataBase();
            LSklad.Connect();
            LSklad.openConnection();

            if (isLoginExist())
            {
                LSklad.closeConnection();
                return;
            }

            OleDbCommand command = new OleDbCommand("INSERT INTO `Authorize` (`login`,`pass`) VALUES (@urL, @urP)", LSklad.getConnection());
            command.Parameters.Add("@urL", OleDbType.VarChar).Value = reglogin;
            command.Parameters.Add("@urP", OleDbType.VarChar).Value = regpass;

            bool result = command.ExecuteNonQuery() == 1;

            LSklad.closeConnection();

            if (result)
            {
                MessageBox.Show("Аккаунт был зарегистрирован!");
                this.Hide();
                Auth auth = new Auth();
                auth.Show();
            }
            else
                MessageBox.Show("Возникла ошибка регистрации!");
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
