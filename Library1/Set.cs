using Microsoft.Data.Sqlite;

namespace Library1
{
    public partial class Engine
    {
        public void SetPerson(string name, int age)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=people.db");
            connection.Open();
            string sql = "INSERT INTO person (name, age) VALUES ('" + name + "', " + age + ")";
            SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

