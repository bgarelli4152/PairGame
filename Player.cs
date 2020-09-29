using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PairGame
{
    class Player
    {
        public int lives;
        public int weaponRating;
        public string equiped;
        public int parts;

        public Player() //constructor
            {
            lives = 3;
            weaponRating = 0;
            equiped = "Fists";
            parts = 0;
            }
        public string[] arsenal = { "Fish", "Frying Pan", "Brick", "Crowbar", "Knife", "Sword", "Pistol", "Double-Barrelled Shotgun", "Minigun", "Infinity Gauntlet" };


        public void Equip() //chooses a random weapon, and updates player equiped and weaponRating
        {

            Random rnd = new Random();
            int i = rnd.Next(0, 8);
            if (weaponRating == 9) //ends equip if player has infinity guantlet equiped
            {
                return;

            }
            Console.WriteLine("You found a " + arsenal[i] + ". Would you like to equip it?"); //change index to test
            Console.WriteLine("Y/N?");
            string response = Console.ReadLine();


            bool validResponse = false;
            while (validResponse == false)
            {
                if (response == "Y" || response == "y")
                {
                    weaponRating = i; //change rating to test
                    equiped = arsenal[i];
                    Console.WriteLine("You equiped the " + arsenal[i]);
                    validResponse = true;
                }
                else if (response == "N" || response == "n")
                {
                    Console.WriteLine("You kept your " + equiped);
                    validResponse = true;

                }
                else
                {
                    Console.WriteLine("Invalid response. Please type y or n");
                    response = Console.ReadLine();
                }
            }
            
        }      
                
    }

}
