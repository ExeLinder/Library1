using Microsoft.Data.Sqlite;

namespace Library1
{
    public partial class Engine
    {
        public void SetPerson(Person person)
        {
            SqliteConnection connection = new SqliteConnection("Data Source=people.db");
            connection.Open();
            string sql = "INSERT INTO person (name, age) VALUES ('" + person.name + "', " + person.age + ")";
            SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

