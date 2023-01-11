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
//using System.Windows.Forms.Integration;


namespace KursovayaDataBase
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String pass = passField.Text;

            DataBase LSklad = new DataBase();

            LSklad.Connect();
            LSklad.openConnection();
          
            DataTable table = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Authorize` WHERE `login` = @uL AND `pass` = @uP", LSklad.getConnection());
            command.Parameters.Add("@uL", OleDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", OleDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизованы успешно!");
                this.Hide();
                Menu mainwindow = new Menu();
                mainwindow.Show();

            }
            else
                MessageBox.Show("Ошибка авторизации!");
            
            LSklad.closeConnection();
        }
            
        private void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
