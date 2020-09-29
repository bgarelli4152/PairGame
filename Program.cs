using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairGame
{
    class Program
    {
        static int Fight(int player, int monster) //method to compare player and monster ratings
        {
            int result = 0;
            if (player > monster)
            {
                result = 1;
                Console.WriteLine("You slayed the monster!");
            }
            else if (player < monster)
            {
                result = 2;
                Console.WriteLine("The Monster wounded you!");
            }
            else
            {
                result = 0;
                Console.WriteLine("The monster dodges and runs away!");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Monster Destroyer! Press any key to continue");
            Console.ReadLine();
            Console.WriteLine("Your journey has begun!");
            Player player1 = new Player();

            while (player1.lives > 0) //runs as long as player has more than 0 lives
            {
                Monster enemy = new Monster();
                
                player1.Equip(); //equips weapon
                if (player1.weaponRating == 9) //checks if player has assembled the infinity gauntlet
                {
                    string choice;
                    Console.WriteLine("You have assembled the infinity guantlet! Will you snap your fingers?");
                    choice = Console.ReadLine();
                    bool isValid = false;
                    while (isValid == false)
                    {
                        if (choice == "y" || choice == "Y")
                        {

                            player1.lives = 0;
                            isValid = true;
                            Console.WriteLine("You snap your fingers, and everything is blinked out of existence. You regret spending your last remaining moments playing this game.");
                            break;
                        }
                        else if (choice == "n" || choice == "N")
                        {
                            player1.lives = 0;
                            isValid = true;
                            Console.WriteLine("Equiped with the infinity gauntlet, you rule over all creation with a shiny fist until the end of your days.");
                            break;
                        }
                    }
                }
                if (player1.lives == 0) { break; } //re-checks player lives
                Console.WriteLine("Press any key to continue your journey.");
                Console.ReadLine();
                enemy.Encounter(); //initiates encounter
                int fight1 = Fight(player1.weaponRating, enemy.monsterRating); //checks results of fight
                if (fight1 == 2)
                {
                    player1.lives -= 1;
                }
                else if (fight1 == 1)
                {
                    player1.parts += 1;
                    Console.WriteLine("You found an infinity stone!");
                }
                if (player1.parts == 5)
                {
                    player1.weaponRating = 9;
                }
                Console.WriteLine("Press any key to continue your journey.");
                Console.ReadLine();
            }

            Console.WriteLine("GAME OVER!!! Thanks for playing!");
            Console.ReadLine();
        }
    }
}
