


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Hero
    {
        //PRIVATE PROPERTIE
        private int strength;
        private int speed;
        private int health;


        //PUBLIC PROPERTIES
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        //CONSTRUCTOR
        public Hero(string name)
        {
            generateAbilities();
        }


        //PRIVATE METHODS
        private void generateAbilities()
        {
            Random rnd = new Random();
            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);
        }

        private bool hitAttempt()
        {
            Random rnd = new Random();
            int hitAttemptNum = rnd.Next(0, 6);
            

            switch (hitAttemptNum)
            {
                case 0:
                    return true;                
                default:
                    return false;

            }

        }

        private int hitDamage()
        {
            Random rnd = new Random();
            int ranNum = rnd.Next(0, 6);

            int damageDegree = 0;
            damageDegree = strength * ranNum;

            

            return damageDegree;
        }

        //PUBLIC METHODS
        public void fight()
        {
            bool tureFalse = hitAttempt();

            if (tureFalse == true)
            {
                hitDamage();
             
            }

            Console.WriteLine("The hero damages {0}",   hitDamage());
        }


        //Method to disply Hero's Properties
        public void show()
        {
            Console.WriteLine("The Hero's Strength: {0}, Speed: {1}, Health: {2} ",strength, speed, health);

        }

    }
}

