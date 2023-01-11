using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace KursovayaDataBase
{
    internal class ExcelHelper : IDisposable
    {
        private Microsoft.Office.Interop.Excel.Application excel;
        private Workbook workbook;

        public ExcelHelper()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
        }

        internal bool Open(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    MessageBox.Show("Неудачное соединение с Excel! Обратитесь к администратору!");
                    return false;
                }
                workbook = excel.Workbooks.Open(filepath);
                return true;
            }
            catch (Exception) {
                MessageBox.Show("Неудачное соединение с Excel! Обратитесь к администратору!");
                return false;
            }
        }

        internal void Save(string filepath)
        {
            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory, filepath));
        }

        internal bool Set(string column, int row, string data)
        {
            try
            {
                ((Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception) {
                MessageBox.Show("Проблемы с работой в Excel! Обратитесь к администратору!");
            }

            return false;
        }

        public void Dispose()
        {
            try
            {
                excel.Workbooks.Close();
            }
            catch (Exception) {
                MessageBox.Show("Проблемы с работой в Excel! Обратитесь к администратору!");
            };

        }
    }
}
