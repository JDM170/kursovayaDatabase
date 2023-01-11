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
    public partial class Cities : Form
    {
        public Cities()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet.Город);
        }

        private void Cities_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchCitiesButton_Click(object sender, EventArgs e)
        {
            if (SearchCities.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchCities.Text.ToLower()))
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

        private void InsButtonCities_Click(object sender, EventArgs e)
        {
            InsCity insсity = new InsCity();
            insсity.ShowDialog();
            updateGridView();
        }

        private void DelButtonCities_Click(object sender, EventArgs e)
        {
            DelCity delcity = new DelCity();
            delcity.ShowDialog();
            updateGridView();
        }
    }
}
