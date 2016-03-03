using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PigDice
{
    class Program
    {
        public static string Player { get; private set; }
        static Random randomNumber = new Random();
        static void Main(string[] args)
        {
            int turnTotal = 0;
            int gameTotal = 0;
            TitleScreen();
            while (gameTotal < 100)
            {
                //Loop for Player Turn
                while (true)
                {
                    int die = randomNumber.Next(1, 7);
                    Console.WriteLine("You rolled a " + die);
                    if (die == 1)
                    {
                        turnTotal = 0;
                        Console.WriteLine("You lose your turn");
                        break;
                    }
                    //they rule 2- 6, we add to the turn total
                    turnTotal += die;
                    Console.WriteLine($"Your turn total score is {turnTotal}. you game total is {gameTotal}");
                    Console.WriteLine("Press Enter to roll again or (b) to bank and end turn.");// ask if bank or roll  
                    var userInput = Console.ReadLine();
                    if (userInput == "b")
                    {
                        break;
                    }
                }
                gameTotal += turnTotal;
                turnTotal = 0;
                if (gameTotal >= 100)
                {
                    Console.WriteLine("You win!!!!!!!!!!");
                }
            }

            Console.ReadLine();
        }
        private static void TitleScreen()
        {
            Console.WriteLine("Welcome to Pig Dice!");
            Console.WriteLine("Press Enter key to roll your dice.");
            Console.ReadLine();
            Console.Clear();
        }
        /* 
        //Console.WriteLine("Bank or roll again?");
        //Title Screen
        //While (gameTotal < 100) keep going
        //while true
        //player turn loop
        //roll dice
            //if 1 turnscore = 0 *break
            //go to next turn
            //else not 1 turnScore add DiceTotal to turnTotal
            //random numbers 1-6(CHECK)
        //Ask if bank or roll
            //if bank add turnTotal to bankTotal *break
        //if roll, continue
        //Show gameTotal score after each roll
        //add values to each number
        //Add up to 100
        //Over 100 loses turn
        //If (rolldice = true)
        //    diceroll randomly*/
        //int turn total = 0
        //int die = rollDice();
        //turnTotal =+ die
        //if die == 1 
        //turnTotal*/
    }
}


