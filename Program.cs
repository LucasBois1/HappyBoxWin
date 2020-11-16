using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Happy_Box
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Tuple<string, string> CheckId (int id)
        {
            SQLiteConnection conn = Database.GetInstance();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT Word, Description FROM words WHERE id=" +id+";";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string word = sqlite_datareader.GetString(0);
                string desc = sqlite_datareader.GetString(1);
                Tuple<string, string> t = new Tuple<string, string>(word, desc);

                conn.Close();
                return t;
            }
            conn.Close();
            return null;
        }

        public static void InsertWord ( String word, String description)
        {

            if (word != "" && description != "")
            {
                SQLiteConnection conn = Database.GetInstance();

                SQLiteCommand sqlite_cmd;

                DateTime dateNow = DateTime.Now;

                String date = dateNow.Year+"/"+dateNow.Month+"/"+dateNow.Day;

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO words (Word, Description, Date) VALUES ('" + word + "', '" + description + "', '" + date + "')";
                sqlite_cmd.ExecuteNonQuery();

                MessageBox.Show("Word Added Succesfully", "HappyBox");

                conn.Close();
            }
            else
                MessageBox.Show("Fields cannot be empty", "HappyBox");
        }

        public static void RemoveWord ( int id )
        {
            SQLiteConnection conn = Database.GetInstance();

            SQLiteCommand sqlite_cmd;

            string Createsql = $"DELETE FROM words WHERE Id = {id}";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static string GetTotallyRandomWord()
        {
            Random rnd = new Random();
            int rndId;
            int maxId = new Int32();

            String word = System.String.Empty;

            SQLiteConnection conn = Database.GetInstance();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT MAX(Id) FROM words";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            
            while (sqlite_datareader.Read())
            {
                maxId = sqlite_datareader.GetInt32(0);
            }

            rndId = rnd.Next(1, maxId);

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Word FROM words WHERE Id = {rndId}";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                word = sqlite_datareader.GetString(0);
            }
            conn.Close();

            return word;
        }

        public static string GetLastWeekRandomWord()
        {
            Random rnd = new Random();
            int rndId;
            int maxId = new Int32();

            String word = System.String.Empty;

            SQLiteConnection conn = Database.GetInstance();

            DateTime dateNow = DateTime.Now;

            String LastWeekDate = dateNow.ToString();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT MAX(Id) FROM words WHERE Date = {LastWeekDate}";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                maxId = sqlite_datareader.GetInt32(0);
            }

            rndId = rnd.Next(1, maxId);

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Word FROM words WHERE Id = {rndId}";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                word = sqlite_datareader.GetString(0);
            }
            conn.Close();

            return word;
        }

        public static string GetDescription ( String word )
        {
            String description = System.String.Empty;

            SQLiteConnection conn = Database.GetInstance();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Description FROM words WHERE Word = '{word}'";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                description = sqlite_datareader.GetString(0);
            }

            return description;
        }

        public static void RefreshDataGrid ( DataGridView Dgv )
        {

            int lastId = Dgv.Rows.Count;

            String Id, Word;
            
            SQLiteConnection conn = Database.GetInstance();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Id, Word FROM words WHERE Id > '{lastId}'";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                Id = sqlite_datareader.GetInt32(0).ToString();
                Word = sqlite_datareader.GetString(1);
                string[] row = {Id, Word};
                Dgv.Rows.Add(row);
            }
            
        }
    }
}
