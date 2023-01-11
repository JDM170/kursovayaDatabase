using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KursovayaDataBase
{
    class DataBase
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\LSklad.mdb";
        
        private OleDbConnection myConnection;

        public void Connect()
        {
            myConnection = new OleDbConnection(connectString);
        }

        public void openConnection()
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
                myConnection.Open();
        }

        public void closeConnection()
        {
            if (myConnection.State == System.Data.ConnectionState.Open)
                myConnection.Close();
        }

        public OleDbConnection getConnection()
        {
            return myConnection;
        }
    }
}
