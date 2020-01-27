//Deandra Fogel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputandformattingandconvertingandconditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first name >>");
            string firstname = Console.ReadLine();



            Console.WriteLine("Please enter your favorite number >>");
            string favoritenumberAsstring = Console.ReadLine();
            int favoritenumber = Convert.ToInt32(favoritenumberAsstring);






            int favoritenumberTimes10 = 10 * favoritenumber;
            string message = firstname + " you have a favorite number of" + favoritenumber.ToString("N3") +
                             "and if you multiply that by 10 you get" + favoritenumberTimes10.ToString("N3");




            if (favoritenumber == 7 || favoritenumber== 3)
            {

                Console.WriteLine("How original are you?");




            }

            if(favoritenumber== 13)
            {
                Console.Write("WHAT? That is an unlucky #");

            }
            else
            {
                Console.WriteLine(message);

            }


            switch (favoritenumber)
            {
                case 7:
                    Console.WriteLine("How original are you?");
                    break;
                case 13:
                    Console.Write("WHAT? That is an unlucky #");
                    break;
                default:
                    Console.WriteLine(message);
                    break;





            }

            if (favoritenumber % 2 == 0)

            {
                Console.WriteLine("Your number is even");

            }

            else
            {

                Console.WriteLine("Your number is odd");


            }





            Console.ReadKey();




      






        }
    }
}
