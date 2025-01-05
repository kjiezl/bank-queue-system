using System.Data.SQLite;

public static class DatabaseInitializer
{
    private const string ConnectionString = "Data Source=queue.db;Version=3;";

    public static void InitializeDatabase()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();

            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Queue (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                QueueNumber TEXT NOT NULL,
                ServiceType TEXT NOT NULL,
                TellerNumber INTEGER,
                Status TEXT DEFAULT 'Waiting',
                Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
            );";

            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}