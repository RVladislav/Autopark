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
        
        public void Save(Fields_Bus fields)
        {
           string cs = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\Database.accdb;Persist Security Info=True";

           using (OleDbConnection con = new OleDbConnection(cs))
            {
                OleDbCommand cmd = new OleDbCommand("AddBus", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@number", fields.f1);
                cmd.Parameters.AddWithValue("@mark", fields.f2);
                cmd.Parameters.AddWithValue("@tour", fields.f3);
                cmd.Parameters.AddWithValue("@new", fields.f4);
                cmd.Parameters.AddWithValue("@sits", fields.f5);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            } 
        }

    }
}

