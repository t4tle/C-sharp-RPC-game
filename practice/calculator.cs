using System;

namespace Practice
{
    class Calculator
    {
        //fields


        //Methods
      public void Calculate(int n)
        {
            //print every multipke of 3 
            //between 1 and n
            // in reverse order

            // + , - , *, /, %
            // % IS MODULUS

            // n % 3 = ?

            int start = n - (n % 3);


            //loop that decreasesby 3 every iteratiuon, and prints the current value, until <= 3
            //for ( int i = start; i <= 3; i = i-3 )
            //{
            //      Console.WriteLine(i);  
            // }
            if(start >= 3)
            {
                while(start >= 3)
                {
                    Console.WriteLine(start);
                    start -= 3;     
                }

            }
            else
            {
                Console.WriteLine("the number is not bigger than 3 or has no multiples of 3");
            }
            

        }
    }
}