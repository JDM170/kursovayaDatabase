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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.lSkladDataSet.Категория);
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchCategoriesButton_Click(object sender, EventArgs e)
        {
            if (SearchCategories.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchCategories.Text.ToLower()))
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

        private void InsButtonCategories_Click(object sender, EventArgs e)
        {
            InsCategory inscategory = new InsCategory();
            inscategory.ShowDialog();
            updateGridView();
        }

        private void DelButtonCategories_Click(object sender, EventArgs e)
        {
            DelCategory delcategory = new DelCategory();
            delcategory.ShowDialog();
            updateGridView();
        }
    }
}
