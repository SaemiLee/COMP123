/****************************************************************************************************
 * Author's Name : Saemi Lee
 * 
 * Date last modified : 01/30/2015
 * 
 * Program description : This program generates randomly the hero's strength , speed, 
 * and health who is input from user, and estimates hit damage by the hero.
 * 
 *  Revision History  :
 *  Date        Author  Ref Revision (Date in MMDDYYYY format)
 *  01262015    Saemi   2   
 *****************************************************************************************************/

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
