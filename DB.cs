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
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\Database.accdb;Persist Security Info=True";

        public struct Fields_Bus
        {
            public string f1;
            public string f2;
            public bool f3;
            public bool f4;
            public int f5;
        }

        public struct Fields_Service
        {
            public int f0;
            public string f1;
            public bool f2;
            public bool f3;
            public bool f4;
            public bool f5;
            public bool f6;
            public bool f7;
            public bool f8;
            public int f9;
            public DateTime f10;
            public bool f11;
        }
        
        public void Save(Fields_Bus fields)
        {
           using (OleDbConnection con = new OleDbConnection(connectionString))
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

        public void Save(Fields_Service fields)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddService", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", fields.f0);
                cmd.Parameters.AddWithValue("@Description", fields.f1);
                cmd.Parameters.AddWithValue("@Whell", fields.f2);
                cmd.Parameters.AddWithValue("@Rudder", fields.f3);
                cmd.Parameters.AddWithValue("@stop", fields.f4);
                cmd.Parameters.AddWithValue("@motor", fields.f5);
                cmd.Parameters.AddWithValue("@exterior", fields.f6);
                cmd.Parameters.AddWithValue("@interior", fields.f7);
                cmd.Parameters.AddWithValue("@rust", fields.f8);
                cmd.Parameters.AddWithValue("@maxspeed", fields.f9);
                cmd.Parameters.AddWithValue("@Time", fields.f10);
                cmd.Parameters.AddWithValue("@Done", fields.f11);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();

            }
        }

    }
}

