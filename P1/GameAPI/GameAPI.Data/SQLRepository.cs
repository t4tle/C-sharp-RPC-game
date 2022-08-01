using GameAPI.Model;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace GameAPI.Data
{
    public class SQLRepository : IRepository
    {
        //Feilds
        private readonly string _connectionString;
        private readonly ILogger<SQLRepository> _logger;

        // Constructor
        public SQLRepository(string connectionString, ILogger<SQLRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        // Methods
        public async Task<IEnumerable<score>> GetScoreAsync()
        {
            List<score> result = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            string cmdText = "SELECT name, wins, rounds FROM scoreboard;";

            using SqlCommand cmd = new(cmdText, connection);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                
                string name = reader.GetString(0);
                int wins = reader.GetInt32(1);
                int games = reader.GetInt32(2);
                //string? batch = reader.IsDBNull(2) ? "" : reader.GetString(2);

                score tmpScore = new score(name, wins, games);
                
                result.Add(tmpScore);
            }

            await connection.CloseAsync();

            _logger.LogInformation("Executed GetScoreAsync, returned {0} results", result.Count);

            return result;
        }

    }
}