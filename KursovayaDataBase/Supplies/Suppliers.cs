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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet1.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet1.Город);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet1.Улица". При необходимости она может быть перемещена или удалена.
            this.улицаTableAdapter.Fill(this.lSkladDataSet1.Улица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet1.Банки". При необходимости она может быть перемещена или удалена.
            this.банкиTableAdapter.Fill(this.lSkladDataSet1.Банки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet1.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lSkladDataSet1.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.lSkladDataSet.Поставщик);

        }

        private void SearchSuppliesButton_Click(object sender, EventArgs e)
        {
            if (SearchSupplies.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchSupplies.Text.ToLower()))

                            {
                                dataGridView1.Rows[i].Selected = true;

                                break;
                            }
                }
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                dataGridView3.ClearSelection();
                dataGridView4.ClearSelection();
                return;
            }
        }

        private void InsButtonSupplies_Click(object sender, EventArgs e)
        {
            InsSupplies inssupplies = new InsSupplies();
            inssupplies.Show();
        }

        private void DelButtonSupplies_Click(object sender, EventArgs e)
        {
            DelSupplies delsupplies = new DelSupplies();
            delsupplies.Show();
        }

    }
}
