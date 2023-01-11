using KursovayaDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaDataBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void лекарстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pharm pharm = new Pharm();
            pharm.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers();
            sup.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stuff stuff = new Stuff();
            stuff.Show();
        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities cities = new Cities();
            cities.Show();
        }

        private void видыУпаковокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packages packages = new Packages();
            packages.Show();
        }

        private void категорииЛекарствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void банкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks banks = new Banks();
            banks.Show();
        }

        private void счетФактураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelFacture exfact = new ExcelFacture();
            exfact.Show();
        }

        private void накладныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelNakladnaya exnakl = new ExcelNakladnaya();
            exnakl.Show();
        }
    }
}
