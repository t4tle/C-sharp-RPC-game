namespace GameAPI.App
{
    class ScoreDTO
    {
        // Fields
        public string name { get; set; }
        public int wins { get; set; }
        public int games { get; set; }

        // Constructor
        public ScoreDTO()
        {
        }

        public ScoreDTO( string name,int wins, int games )
        {
            this.name = name;
            
            this.wins = wins;
           
            this.games = games;
        }

        // Methods
        public override string ToString()
        {
            return $"{name} {wins} {games}";
        }

    }
}