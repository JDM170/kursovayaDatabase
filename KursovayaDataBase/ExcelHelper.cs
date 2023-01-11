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

        internal bool Open(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    MessageBox.Show("Неудачное соединение с Excel! Обратитесь к администратору!");
                    return false;
                }
                workbook = excel.Workbooks.Open(filename);
                return true;
            }
            catch (Exception) {
                MessageBox.Show("Неудачное соединение с Excel! Обратитесь к администратору!");
                return false;
            }
        }

        internal void Save()
        {
            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory, "D:\\KursovayaDataBase (TESTING)  V 3\\KursovayaDataBase\\FactureTest.xlsx"));
        }
        internal void SaveNakladnaya()
        {
            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory, "D:\\KursovayaDataBase (TESTING)  V 3\\KursovayaDataBase\\nakladnayaTest.xlsx"));
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
