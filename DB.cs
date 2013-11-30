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

        public struct Link_BusTrack
        {
            public int f1;
            public int f2;
        }

        public struct Fields_Bus
        {
            public string f1;
            public string f2;
            public bool f3;
            public bool f4;
            public int f5;
        }

        public struct LinkDrtiverBus
        {
            public int f1;
            public int f2;
        }

        public struct LinkVacantion
        {
            public int f1;
            public int f2;
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

        public struct Fields_Track
        {
            public string f1;
            public string f2;
            public int f3;
            public bool f4;
            public DateTime f5;
            public bool f6;
        }

        public struct Fields_Worker
        {
            public string f1;
            public DateTime f2;
            public int f3;
            public string f4;
            public string f5;
            public string f6;
            public bool f7;
            public bool f8;
            public bool f9;
            public bool f10;
            public bool f11;
            public string f12;
        }

        public struct Fields_Vacation
        {
            public string f1;
            public string f2;
            public string f3;
            public string f4;
            public int f5;
            public bool f6;
        }

        public void Save(LinkDrtiverBus db)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddWB", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idW", db.f1);
                cmd.Parameters.AddWithValue("@idV", db.f2);

                RunQuery(con, cmd);
            }
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

                RunQuery(con, cmd);
            }
        }

        public void Save(Link_BusTrack bt)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddBusTrack", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idB", bt.f1);
                cmd.Parameters.AddWithValue("@idT", bt.f2);

                RunQuery(con, cmd);

            }
        }

        public void Save(LinkVacantion lv)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddWV", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idW", lv.f1);
                cmd.Parameters.AddWithValue("@idV", lv.f2);

                RunQuery(con, cmd);

            }
        }

        public void Save(Fields_Vacation fields)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddVacation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", fields.f1);
                cmd.Parameters.AddWithValue("@Description", fields.f2);
                cmd.Parameters.AddWithValue("@requirements", fields.f3);
                cmd.Parameters.AddWithValue("@FullD", fields.f4);
                cmd.Parameters.AddWithValue("@minMoney", fields.f5);
                cmd.Parameters.AddWithValue("@inOffice", fields.f6);

                RunQuery(con, cmd);

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

                RunQuery(con, cmd);

            }
        }

        public void Save(Fields_Worker fields)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddWorker", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fio", fields.f1);
                cmd.Parameters.AddWithValue("@years_old", fields.f2);
                cmd.Parameters.AddWithValue("@work_year", fields.f3);
                cmd.Parameters.AddWithValue("@tel", fields.f4);
                cmd.Parameters.AddWithValue("@family", fields.f5);
                cmd.Parameters.AddWithValue("@hobbies", fields.f6);
                cmd.Parameters.AddWithValue("@veteran", fields.f7);
                cmd.Parameters.AddWithValue("@one", fields.f8);
                cmd.Parameters.AddWithValue("@diss", fields.f9);
                cmd.Parameters.AddWithValue("@many", fields.f10);
                cmd.Parameters.AddWithValue("@car", fields.f11);
                cmd.Parameters.AddWithValue("@other", fields.f12);

                RunQuery(con, cmd);
            }
        }

        public void Save(Fields_Track fields)
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand("AddTrack", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Description", fields.f1);
                cmd.Parameters.AddWithValue("@stops", fields.f2);
                cmd.Parameters.AddWithValue("@time", fields.f3);
                cmd.Parameters.AddWithValue("@city", fields.f4);
                cmd.Parameters.AddWithValue("@timeCreate", fields.f5);
                cmd.Parameters.AddWithValue("@Done", fields.f6);

                RunQuery(con, cmd);

            }
        }

        private void RunQuery(OleDbConnection con, OleDbCommand cmd)
        {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

    }
}

