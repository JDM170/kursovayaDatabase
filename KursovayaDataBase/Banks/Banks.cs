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
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Банки". При необходимости она может быть перемещена или удалена.
            this.банкиTableAdapter.Fill(this.lSkladDataSet.Банки);
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchBanksButton_Click(object sender, EventArgs e)
        {
            if (SearchBanks.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchBanks.Text.ToLower()))
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

        private void InsButtonBanks_Click(object sender, EventArgs e)
        {
            InsBank insbank = new InsBank();
            insbank.ShowDialog();
            updateGridView();
        }

        private void DelButtonBanks_Click(object sender, EventArgs e)
        {
            DelBank delbank = new DelBank();
            delbank.ShowDialog();
            updateGridView();
        }
    }
}
