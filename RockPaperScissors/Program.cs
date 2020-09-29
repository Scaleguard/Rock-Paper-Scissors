using System;
using System.Dynamic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Alright then {name}, lets play Rock Paper Scissors, first 3 points win.");
            
            int count = 0;
            int count1 = 0;
            
            
            while (count != 3 && count1 != 3) 
            {
                string userchoice = Console.ReadLine().ToLower();
                Random rnd = new Random();
                int computerchoice = rnd.Next(1, 4);

                if (computerchoice == 1)
                {
                    if (userchoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock!");
                        Console.WriteLine("It's a tie!!!");
                    }
                    else if (userchoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper!");
                        Console.WriteLine("It's a tie!!!");
                    }
                    else if (userchoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors!");
                        Console.WriteLine("It's a tie!!!");
                    }
                    else
                    {
                        Console.WriteLine("I said rock paper scissors ya wanker! Either type what I asked or learn to write!");
                    }
                }
                else if (computerchoice == 2)
                {
                    if (userchoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper!");
                        Console.WriteLine("Ya lost sucker! Paper beats rock!");
                        count1 += 1;
                    }
                    else if (userchoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors!");
                        Console.WriteLine("I pronounce you, a loser! SCISSORS BEATS PAPER!!!");
                        count1 += 1;
                    }
                    else if (userchoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock!");
                        Console.WriteLine("You just got hammered by a computer, how does it feel? Rock beats scissors, your luck has all but run out.");
                        count1 += 1;
                    }
                    else
                    {
                        Console.WriteLine("Can you write or read? Just asking cause from what I just read it seems you CAN'T!!!");
                    }
                }
                else if (computerchoice == 3)
                {
                    if (userchoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors!");
                        Console.WriteLine("Well, you did it, you won! Feel proud of yourself?");
                        count += 1;
                    }
                    else if (userchoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock!");
                        Console.WriteLine("Whow, you've managed to beat me...how the fuck did that happen?");
                        count += 1;
                    }
                    else if (userchoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper!");
                        Console.WriteLine("I am mortified, how could I loose to a lowly human? I must be degrading...");
                        count += 1;
                    }
                    else
                    {
                        Console.WriteLine("Have you heard of what a word is? You probably haven't because you can't WRITE FOR SHIT!!!");
                    }
                    
                }
                Console.WriteLine($"User wins {count} times");
                Console.WriteLine($"Console wins {count1} times");
                

            }
            
            
            
            

        }
    }
}
