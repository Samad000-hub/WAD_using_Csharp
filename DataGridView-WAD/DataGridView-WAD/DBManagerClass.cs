using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_WAD
{
    class DBManagerClass
    {
        public static DataTable GetTestData()
        {
            // Create table with name 'Test'
            DataTable tbl = new DataTable("Test");

            //Make coulmn with name "ID"
            DataColumn dc = new DataColumn("ID", typeof(System.Int32));
            
            //  Add "ID" column
            tbl.Columns.Add(dc);

            //Make coulmn with name "Name"
            dc = new DataColumn("Name", typeof(System.String));

            //  Add "Name" column
            tbl.Columns.Add(dc);

            //Make coulmn with name "Age"
            dc = new DataColumn("Age", typeof(System.Int32));

            //  Add "Age" column
            tbl.Columns.Add(dc);


            // Create Row with name 'dr'
            DataRow dr = tbl.NewRow();

            //Add data in first row
            dr["ID"] =1;
            dr["Name"] ="Samad";
            dr["Age"] =20;

            //Add row in table
            tbl.Rows.Add(dr);

            // Create 2nd Row
            dr = tbl.NewRow();

            //Add data in second row
            dr["ID"] = 2;
            dr["Name"] = "Not Samad";
            dr["Age"] = 30;

            //Add row in table
            tbl.Rows.Add(dr);

            return tbl;
        }
    }
}
