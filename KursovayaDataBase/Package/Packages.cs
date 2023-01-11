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
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Вид_упаковки". При необходимости она может быть перемещена или удалена.
            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchPackagesButton_Click(object sender, EventArgs e)
        {
            if (SearchPackages.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchPackages.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                dataGridView1.ClearSelection();
            }
        }

        private void InsButtonPackages_Click(object sender, EventArgs e)
        {
            InsPackage inspackages = new InsPackage();
            inspackages.ShowDialog();
            updateGridView();
        }

        private void DelButtonPackages_Click(object sender, EventArgs e)
        {
            DelPackage delpackage = new DelPackage();
            delpackage.ShowDialog();
            updateGridView();
        }
    }
}
