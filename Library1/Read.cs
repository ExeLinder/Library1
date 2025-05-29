using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public partial class Engine
    {
        public  List<Person> Read()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=people.db");
            connection.Open();

            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "select * from person";

            SqliteDataReader reader = command.ExecuteReader();

            List<Person> list = new List<Person>();

            while (reader.Read())
            {
                Person person = new Person { id = reader.GetInt32(0), name = reader.GetString(1), age = reader.GetInt32(2) };

                list.Add(person);
            }

            reader.Close();

            connection.Close();

            return list;
        }

    }
}
