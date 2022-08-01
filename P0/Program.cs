using System;
using System.Data.SqlClient;

namespace game
{
    class Program

    {
        static void scoreboard()
        {
            string path = @"c:\Revature\ConnectionStrings\1db.txt";

            string connectionString = File.ReadAllText(path);
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM scoreboard", connection);
            using SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Console.WriteLine("Name:{0} Wins:{1} Games:{2} ", reader[0], reader[1], reader[2]);
            }
            reader.Close();
            connection.Close();
        }
        static void Main()
        {   
            scoreboard();
            game sg = new game();

            game.startgame();
            
            

        }
       
         static void insert()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=School;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = @"INSERT INTO scoreboard (name, wins, rounds) VALUES (@name, @wins, @rounds)";
            
            using SqlCommand cmd = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", "Joseph");
            command.Parameters.AddWithValue("@wins", "3");
            command.Parameters.AddWithValue("@rounds", "5");

            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
