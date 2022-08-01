using System.Text.Json;

namespace GameAPI.App
{
    class Program
    {
        // Fields
        
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://localhost:7024/api/Score"; //localhost:7024/api/Score";
        //myfirstdatabase-jboye.database.windows.net
        
        // Methods
        static async Task Main()
        {
            string response = await client.GetStringAsync(uri);


            List<ScoreDTO> scores = JsonSerializer.Deserialize<List<ScoreDTO>>(response);

            foreach (var item in scores)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}