using System.IO;
using System.Data.SQLite;

namespace Happy_Box
{
    public class Database
    {
        private const string DBName = "database.db";
        //private const string SQLScript = @"\database.sql";
        private static bool IsDbRecentlyCreated = false;

        public static void Up()
        {
            if (!File.Exists(Path.GetFullPath(DBName)))
            {
                SQLiteConnection.CreateFile(DBName);
                IsDbRecentlyCreated = true;
            }

            if (IsDbRecentlyCreated)
            {
                SQLiteConnection conn = Database.GetInstance();

                SQLiteCommand sqlite_cmd;

                string Createsql = "CREATE TABLE words (Id INTEGER PRIMARY KEY AUTOINCREMENT, Word VARCHAR(255) NOT NULL, Description VARCHAR(255) NOT NULL, Date DATE NOT NULL)";

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );

            db.Open();

            return db;
        }
    }

}