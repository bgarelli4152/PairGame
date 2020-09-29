using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PairGame
{
    class Player
    {
        public int lives;
        public int weaponRating;
        public string equiped;

        public Player() //constructor
            {
            lives = 5;
            weaponRating = 0;
            equiped = "Fists";
            }
        public string[] arsenal = { "Fish", "Frying Pan", "Brick", "Crowbar", "Knife", "Sword", "Pistol", "Double-Barrelled Shotgun", "Bomb", "Shield" };

        public void Equip()
        {
            //chooses a random weapon, and updates player equiped and weaponRating
            Random rnd = new Random();
            int i = rnd.Next(1, 10);
            
            Console.WriteLine("Would you like to equip " + arsenal[i] + "?");
            Console.WriteLine("Y/N?");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                weaponRating = i;
                equiped = arsenal[i];
                Console.WriteLine("You equiped the " + arsenal[i]);
            }
            else if (response == "N" || response == "n")
            {
                Console.WriteLine("You kept your " + equiped);
            }
            else
            {
                Console.WriteLine("Invalid response. Please type y or n");
            }
            
        }
    }

}
