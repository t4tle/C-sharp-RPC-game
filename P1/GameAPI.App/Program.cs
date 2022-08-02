using System.Text.Json;

namespace GameAPI.App
{
    public class Program
    {
        // Fields
        
        //localhost:7024/api/Score";
        //myfirstdatabase-jboye.database.windows.net
        
        // Methods


        
        static async Task Main()
        {
            
            

            game sg = new game();

            await game.startgame();
   
        }

    }
    public class helper 
    {
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://localhost:7024/api/Score";

        public async Task score()
        {   
            Console.WriteLine("Scoreboard:");
            await Scoreboard();
        }
        static async Task Scoreboard()
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

//post request