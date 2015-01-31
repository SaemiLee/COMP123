/* SaemiLee
 * 01/26/2015
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hero's name: ");
            string name = Console.ReadLine();
            Hero aHero = new Hero(name);            
            aHero.show();
            aHero.fight();

            Console.WriteLine("Enter the any key to exit");
            Console.ReadKey();
           
        }
    }
}
