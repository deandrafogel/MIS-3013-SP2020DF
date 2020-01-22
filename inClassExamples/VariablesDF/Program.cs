//Deandra Fogel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ceate a string named FirstName
            string FirstName;





            //Assign a value to FirstName (Deandra)
            FirstName = "Deandra";

            //Create an int named FavNum and assign your favorite number to it
            int FavNum = 3;


            double crazyNumber = 7.76767 * FavNum;

            string lastName = "Fogel";

            string fullName = FirstName + " " + lastName;

            Console.WriteLine(fullName + "has the favorite number of" + FavNum 
                + "\n which equates to the number of" + crazyNumber);

            //Make it dynamic

            Console.WriteLine("Please enter your first name: >>");
            FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: >>");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your favorite number: >>");
            FavNum = Convert.ToInt32(FavNum);
            //favnum = Convert.ToInt32(Console.ReadLine());
            fullName = FirstName + " " + lastName;
            crazyNumber = 7.76767 * FavNum;



            Console.WriteLine(fullName + "has the favorite number of" + FavNum
                + "\n which equates to the number of" + crazyNumber);



            Console.ReadKey();
        }
    }
}
