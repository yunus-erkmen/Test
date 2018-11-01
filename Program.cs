using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.I.Works
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
        }

        private static void GetData()
        {
            
            string path = @"C:\Users\erkme\Desktop\exhibitA-input.xlsx";
            OleDbConnection con = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=" + path + ";Extended Properties=Excel 12.0;");

            con.Open();
            StringBuilder stbQuery = new StringBuilder();
            stbQuery.Append("SELECT * FROM [exhibitA-input$]");
            OleDbDataAdapter adp = new OleDbDataAdapter(stbQuery.ToString(), con);
            DataSet dsXLS = new DataSet();
            adp.Fill(dsXLS);
            
            //DataView dvEmp = new DataView(dsXLS.Tables[0]);
            con.Close();
            
        }





    }
}
