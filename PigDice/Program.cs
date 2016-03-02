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
            Console.WriteLine("Welcome to pig dice!");

            Console.WriteLine("Press Enter key to roll your dice.");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Here's Your Number...");

            int die = randomNumber.Next(1, 6);

            Console.WriteLine(die);

            Console.ReadLine();

            var dieRoll = die;
            var turnTotal = (dieRoll + die);
            var gameTotal = (turnTotal + die);

            if (die < 2)
            {
                Console.WriteLine("You lose your turn");
            } 
            else
            {
                Console.WriteLine($"Your score is {turnTotal}. Your total score is {gameTotal}");
                Console.WriteLine("Press enter to roll again.");
            }
            Console.ReadLine();


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

