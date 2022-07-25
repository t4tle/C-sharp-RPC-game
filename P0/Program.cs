using System;
using System.Data.SqlClient;

namespace game
{
    class Program

    {
        static void Main()
        {   

            game sg = new game();

            game.startgame();
            

        }

         static void insert()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=School;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = @"INSERT INTO scoreboard (name, wins, rounds) VALUES (@name, @wins, @rounds)";
            
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", "Joseph");
            command.Parameters.AddWithValue("@wins", "3");
            command.Parameters.AddWithValue("@rounds", "5");

            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
