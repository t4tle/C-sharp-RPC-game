using System;

namespace Practice
{

    class Program
    {
        // class has members, feilds or stste and members or behaviors

        //feilds

        //meathod
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a intiger:");

            string response = Console.ReadLine(); // read user input
            Calculator calc = new Calculator();



            // try catch is a graceful way to hanle exceptions dont let your application crash handle your esceptions
            try
            {
                int n;
                if(int.TryParse(response,out int n))  
                {
                    calc.Calculate(n);
                }              
                else
                {
                    Console.WriteLine("please enter a intiger:");
                }
                int number = int.Parse(response); 
                //int number = int.Parse(Console.ReadLine());  
                calc.Calculate(number);
            }
            catch(Exception ex )
            {
                Console.WriteLine("That aint a intiger");
                return;
            }
            

            
            
        }

        




    }
}