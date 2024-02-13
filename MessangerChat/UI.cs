using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerChat
{
    public class UI
    {
        public static void UsersList()
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"SELECT * FROM Users;";
                using NpgsqlCommand cmd = new NpgsqlCommand(query,connection);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Console.WriteLine(result[1]);
                }

                Console.WriteLine("Choose username: ");

                connection.Close();
            }
        }
    }
}
