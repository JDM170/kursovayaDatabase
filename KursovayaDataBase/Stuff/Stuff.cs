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
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.lSkladDataSet.Сотрудники);
        }

        private void Stuff_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchStuffButton_Click(object sender, EventArgs e)
        {
            if (SearchStuff.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchStuff.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                dataGridView1.ClearSelection();
                return;
            }
        }

        private void InsStuffButton_Click(object sender, EventArgs e)
        {
            InsStuff insstuff = new InsStuff();
            insstuff.ShowDialog();
            updateGridView();
        }

        private void DelStuffButton_Click(object sender, EventArgs e)
        {
            DelStuff delstuff = new DelStuff();
            delstuff.ShowDialog();
            updateGridView();
        }
    }
}
