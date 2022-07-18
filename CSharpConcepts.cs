// we can include librries using statements

using System;

// a namespace is like a file cabanet that we can stole lots of stuff in
namespace CSharpConcepts
{


    // a class is made of members
    //these members are calles feilds and meathods
    //
    class Program
    {
        // as a language, C# dosent care about identification, only line ending and logicalm blocks
        
        // Access modifiers
        //private - limits acess to the class to the class itself
        //public - acess is limited to the class and all of its members
        //internal - acess is limited to the class and all its members, but not the class static members
        //protected - acess is limited to the class and all its members, but not the class static members
        
        // modifiers are used to control acess to members of a class
        //static

        // (Modifier) (Return type) (meathod name) (parameters)
        static void Main(string[] args)
        {
        //primitive data types
            //boolean - true false
            //char - single character
            //string - a sequence of character
    
        //collection
            //arrays - collection of items of the same type
            //list- a collection of diffrent types
            // dictionary - a collection of key/.value pairs
            //queues- a first in first out collection of items
            // Stacks - a last in first out collectrion
            Console.WriteLine("Hello World");

            //declaring variable
            // (type) (variable name) = (value);
            string s = "hello world";
            s = "whats good";

            Console.WriteLine(s);

            string s2;
            // initialize the value
            s2= "whats up";

            //numeric data type
            //int (4byte)
            //byte (1 byte) , short (2 byte), long (8 byte)

            //decimal tyupe
            // double(8 byte) float(4 byte)

            //Boolean type
            //true or false are keywords
            bool b = false;

            // logical operators
            b = true || true; // or - if one condition is true the results is positive /true1
            b = true && true; // and - if both conditions are ture the results is positive /true

            b = !b; // not - if the condition is true, the results is false, otherwise true

            // comparison operators
            b = (3 == 3); // equal to, results in a logical true/false (boolean) value
            b = (3 != 3); // not equal to, results in a logical true/false (boolean) value
            b = (3 > 3); // greater than, results in a logical true/false (boolean) value
            b = (3 < 3); // less than, results in a logical true/false (boolean) value
            b = (3 >= 3); // greater than or equal to, results in a logical true/false (boolean) value
            b = (3 <= 3); // less than or equal to, results in a logical true/false (boolean) value




            // conreol flow
            // conditiuonal statements

            //if
            //if (condition)

            if (3==3)
            {

            }
            // else if
            else if( 3 == 4)
            {

            }
            // else
            else
            {
                // take action
            }



            //switch
            // switch (eppression)
            switch (newint)
            {
                case 1:// if (newint ==1)
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default: // think else
                    Console.WriteLine("default");
                    break;

            }

            //
            
            // for loops, while loops
            
            //for (initialization; condition; incriment)
            for (int i = 0; i < newint; i++)
            {
                Concole.WriteLine(i);
            } 

            // WHile (condition) - a while loop continues until the condition is false

            while(newint < 10)
            {
                Concole.WriteLine(newint);
                newint++;
            }

            // do while- will run at least once even if the condition is false

            do
            {
                Concole.WriteLine(newint);
                newint++;
            }while(false);



            bool test = !(newint >=5) || (newint <=10);

            if(test)
            {

            }
            AddValues(newint, 2)

        }


        private int AddValues (int a , int b)
        {
            //variable scope =
            int answer = a + b;
            return answer;
        }

        // Object oriented programming/principoles
        // encapsulation- riches bad gumball machine or limit access to outside parties (users other systems, other classes)to only the parts they need to know about

        // Abstraction - hiding the deatils of how somthing works. Think black box
        
        // Inheritance -  Creating new classes from ewxisting vclasses. can be discribes a "is-A" Relationship
            // a child/sub/ derived class "is a" parent /Super/base class a dog is a animal
            //in herited class will recieve all the members (feilds and meathods) of the parent class.
            //
            //          animal                             animal       tree
            //          /   \                               \           /
            //         dog  cat                                    Lichen
            //          |                                       True multiple in heritance is a no go
            //          gearman shepard                         but we can fake it with interfaces
            //
        //Polymorphism - taking on many forms, Through meathod overloading and overiding
            // overloading - same meathod name but diffrent parameters
                //example: AddValues(int a , int b)
                //example: AddValues(int a , int b, int c)
                //example: AddValues(double a , int b)
            //overriding - same meathod as the parent, but diffrent functionality




    }

}