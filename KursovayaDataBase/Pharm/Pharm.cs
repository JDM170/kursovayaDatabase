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
using KursovayaDataBase.LSkladDataSetTableAdapters;

namespace KursovayaDataBase
{
    public partial class Pharm : Form
    {
        public Pharm()
        {
            InitializeComponent();
            
        }


        private void Pharm_Load(object sender, EventArgs e)

        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Вид_упаковки". При необходимости она может быть перемещена или удалена.
            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.lSkladDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Цена". При необходимости она может быть перемещена или удалена.
            this.ценаTableAdapter.Fill(this.lSkladDataSet.Цена);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();

        }

        private void InsButtonPharm_Click(object sender, EventArgs e)
        {
            InsPharm inspharm = new InsPharm();
            inspharm.Show();
           
        }

        private void DelButtonPharm_Click(object sender, EventArgs e)
        {
            DelPharm delpharm = new DelPharm();
            delpharm.Show();

        }


        private void SearchPharmButton_Click(object sender, EventArgs e)
        {
            if (SearchPharm.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;

                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchPharm.Text.ToLower()))

                            {
                                dataGridView2.Rows[i].Selected = true;

                                break;
                            }
                }
            }
            else
            {
                dataGridView2.ClearSelection();
                dataGridView3.ClearSelection();
                dataGridView4.ClearSelection();
                dataGridView5.ClearSelection();
                dataGridView6.ClearSelection();
                return;
            }
        }

        private void UpdPharmButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Refresh();

            this.вид_упаковкиTableAdapter.Fill(this.lSkladDataSet.Вид_упаковки);
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);
            this.производительTableAdapter.Fill(this.lSkladDataSet.Производитель);
            this.ценаTableAdapter.Fill(this.lSkladDataSet.Цена);
            this.лекарстваTableAdapter.Fill(this.lSkladDataSet.Лекарства);
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();
            MessageBox.Show("Страница обновлена!");
        }

    }
}
