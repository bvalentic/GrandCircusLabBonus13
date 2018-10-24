using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLabBonus13
{
    class Program
    {
        static void Main(string[] args)
        {/*creates array of pre-made characters in different classes and returns a list
         * of stats for each one
         * also includes an option for user to create a character 
         */

            GameCharacter[] gameCharacters = new GameCharacter[]
            {//list of pre-made characters
                new Warrior("Steph Curry", 14, 10, "basketball"),
                new Wizard("John Wall", 7, 15, 3),
                new Warrior("The Infraggable Krunk", 18, 3, "unarmed"),
                new Wizard("Trogdor the Burninator", 17, 11, 1),
                new Wizard("Tim", 3, 12, 5)
            };
            Console.WriteLine("Welcome to D&D&D - Dungeons and Dragons and Dev.Build(2.0)!\n");
            ListCharacters(gameCharacters);

            //if you want to take a crack at creating a character, uncomment the section below
            //otherwise the existing code should be sufficient for this lab

            //Console.Write("Would you like to create a character? (y/n) ");
            //bool charBool = Validator.CheckYes(Console.ReadLine(), "Please enter yes or no: ");
            //if (charBool)
            //{
            //    CreateCharacter();
            //}
            //Console.WriteLine("\nThanks for playing!");

            Console.ReadKey();
        }

        public static void ListCharacters(GameCharacter[] gameCaracters)
        {//prints out each character in the list
            Console.WriteLine("This is a list of pre-created characters:");
            foreach (GameCharacter character in gameCaracters)
            {
                character.Play();
                Console.WriteLine();
            }
        }

        /*the classes and methods below here are extra work on my part
        * I was attempting to allow the user to create a character
        * it works for the most part but I'm not sure how to get the
        * character to be returned without writing separate methods
        * to return the class type for both classes (and any classes
        * which might be added later)
        * also it's very lengthy and tedious which makes me think I'm doing it wrong
        */

        public class Validator
        {
            public static int CheckNum(string inputString, string errorMessage, int maxNum, int minNum)
            {//checks input string is of required type (in this case, non-zero positive doubles)
                int input;
                while ((!(int.TryParse(inputString, out input))) || int.Parse(inputString) < minNum || int.Parse(inputString) > maxNum)
                {//only positive non-zero numbers allowed
                    Console.Write($"I'm sorry, that's not a valid input. {errorMessage}");
                    inputString = Console.ReadLine();
                }
                return input; 
            }
            public static bool CheckYes(string inputString, string errorMessage)
            {
                bool correctInput = true;
                do
                {
                    if (inputString.ToLower() == "y" || inputString.ToLower() == "yes")
                    {
                        return true;
                    }
                    else if (inputString.ToLower() == "n" || inputString.ToLower() == "no")
                    {
                        return false;
                    }
                    else
                    {
                        Console.Write($"I'm sorry, I didn't understand. {errorMessage}");
                        inputString = Console.ReadLine();
                    }
                } while (!correctInput);
                return true;
            }
        }

        public static void CreateCharacter()
        {
            Console.Write("Enter your character's name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine(@"Choose your character class:
1 -- warrior
2 -- wizard");
            int classNum = Program.Validator.CheckNum(Console.ReadLine(), "Please enter 1 or 2: ", 2, 1);
            
            Console.WriteLine(@"Would you like to manually or randomly assign stats?
1 -- manual
2 -- random");
            int statNum = Program.Validator.CheckNum(Console.ReadLine(), "Please enter 1 or 2: ", 2, 1);

            int statStr;
            int statInt;

            if (statNum == 1)
            {
                Console.Write("Enter a number 1-18 for character's strength: ");
                statStr = Program.Validator.CheckNum(Console.ReadLine(),
                    "Please enter a number between 1 and 18: ", 18, 1);
                Console.Write("Enter a number 1-18 for character's intelligence: ");
                statInt = Program.Validator.CheckNum(Console.ReadLine(),
                    "Please enter a number between 1 and 18: ", 18, 1);
            }
            else
            {//rolls three six-sided dice 
             //(this is how you get your stats in D&D so I'm told)
                Random rnd = new Random();
                statStr = rnd.Next(6) + rnd.Next(6) + rnd.Next(6);
                statInt = rnd.Next(6) + rnd.Next(6) + rnd.Next(6);
            }
            if (classNum == 1)
            {//create warrior
                Console.Write("Please enter your weapon type: ");
                string inputWeapon = Console.ReadLine();
                Console.WriteLine("Thank you! We have received the following input:\n");
                Warrior newWarrior = new Warrior(inputName, statStr, statInt, inputWeapon);
                newWarrior.Play();
            }
            else
            {//create wizard
                Console.Write("Please enter your starting number of spells (less than 100): ");
                int numSpell = Validator.CheckNum(Console.ReadLine(), 
                    "Please enter a positive whole number less than 100: ", 99, 0);
                Console.WriteLine("Thank you! We have received the following input:\n");
                Wizard newWizard = new Wizard(inputName, statStr, statInt, numSpell);
                newWizard.Play();
            }            
        }
    }
}
