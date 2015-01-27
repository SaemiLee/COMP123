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
            this.name = name;
            this.generateAbilities();
        }
       
        
        //PRIVATE METHODS
        private void generateAbilities(){
            Random rnd = new Random();
            strength = rnd.Next(1,101);
            speed = rnd.Next(1,101);
            health = rnd.Next(1, 101);

        }

        private bool hitAttempt()
        {
            Random rnd = new Random();
            int hitAttemptNum = rnd.Next(1,6);
            switch (hitAttemptNum)
            {
                case 1:
                    return true;
                    break;
                
                default:
                    return false;
            }
        
        }

        private int hitDamage()
        {
            Random rnd = new Random();
            int ranNum = rnd.Next(1,7);
            
            int damageDegree = 0;
            damageDegree = strength * ranNum;

     
            return damageDegree;
        }

        //PUBLIC METHODS
        public void fight(){
            int damageDegree = 0;
            bool tureFalse = hitAttempt();
            if (tureFalse == true)
            {
               damageDegree = hitDamage();
            }

            Console.WriteLine("{0} damages {1}",name,damageDegree);
        }
      

        //Method to disply Hero's Properties
        public void show()
        {
            Console.WriteLine("{0}'s Strength: {1}, Speed: {2}, Health: {3} ", name,strength, speed, health);

        }

    }
}
