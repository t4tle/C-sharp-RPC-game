namespace GameAPI.Model
{
    public class score
    {
        // Fields
        public string Name { get; set; }
        public int Wins { get; set; }
        
        public int Games { get; set; } //? nullable

        // Constructor

        public score() { }

        public score( string name,int wins, int games )
        {
            Name = name;
            
            Wins = wins;
           
            Games = games;
        }

        // Methods
    }
}