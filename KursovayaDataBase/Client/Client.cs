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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void updateGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Улица". При необходимости она может быть перемещена или удалена.
            this.улицаTableAdapter.Fill(this.lSkladDataSet.Улица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.lSkladDataSet.Город);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lSkladDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.lSkladDataSet.Клиент);

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void SearchClientButton_Click(object sender, EventArgs e)
        {
            if (SearchClient.Text.Length != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchClient.Text.ToLower()))
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
                return;
            }
        }

        private void InsButtonClient_Click(object sender, EventArgs e)
        {
            InsClient insclient = new InsClient();
            insclient.ShowDialog();
            updateGridView();
        }

        private void DelButtonClient_Click(object sender, EventArgs e)
        {
            DelClient delclient = new DelClient();
            delclient.ShowDialog();
            updateGridView();
        }
    }
}
