using System;

namespace GameAPI.App
{
    public class game
    {
        public static async Task startgame()
        {
            string inputPlayer, inputCPU;
            int randomInt;

            helper h = new helper();
            
            await h.score();

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;
                bool pwin ;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    

                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose ROCK");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose ROCK");
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose ROCK");
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry!\n\n");
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose PAPER");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose PAPER");
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose PAPER");
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry!\n\n");
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer chose SCISSORS");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer chose SCISSORS");
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer chose SCISSORS");
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                    return pwin = true;
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                    return pwin = false;
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                { 
                    Console.WriteLine("Invalid entry!\n\n");
                    break;
                }

            }
        }

    }
}