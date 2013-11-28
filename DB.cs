using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace Autopark
{
    class DB_functions
    {
        public struct Fields_Bus
        {
            public string f1;
            public string f2;
            public bool f3;
            public bool f4;
            public int f5;
        }
        
        public void Save()
        {
           string cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\Database.accdb;Persist Security Info=True";

           using (OleDbConnection con = new OleDbConnection(cs))
            {

                OleDbCommand cmd = new OleDbCommand("AddBus", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@number", "Q123QQ");
                cmd.Parameters.AddWithValue("@mark", "volvo");
                cmd.Parameters.AddWithValue("@tour", false);
                cmd.Parameters.AddWithValue("@new", false);
                cmd.Parameters.AddWithValue("@sits", 10);
                
                //SqlParameter outPar = new SqlParameter();
                //outPar.ParameterName = "@id";
                //outPar.SqlDbType = System.Data.SqlDbType.Int;
                //outPar.Direction = System.Data.ParameterDirection.Output;

                //cmd.Parameters.Add(outPar);
                //con.ConnectionString = connect.ConnectionString;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                //string id = outPar.Value.ToString();


                // INSERT INTO Bus ( [number], mark, tour, new, sits )
                //SELECT [@number], [@mark], [@tour], [@new], [@sits];
            } 
        }

    }
}

