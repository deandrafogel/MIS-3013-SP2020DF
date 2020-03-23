using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation

{
    class Program
    {
        static void Main(string[] args)
        {

            //                  012
            string firstname = "Dee";
            string lastname = "Fogel";
            
           Console.WriteLine($"You have {firstname.Length.ToString("N0")}) characters in your first name");
            Console.WriteLine($"You have {lastname.Length.ToString("N0")}) characters in your first name");

            char firstInitial = firstname[0];
            char lastInitial = lastname[0];

            //Console.WriteLine(firstname.ToUpper()[0]);
            //Console.WriteLine(lastname.ToUpper()[0]);
            //Console.WriteLine(lastname.ToUpper()[0]);
            //Console.WriteLine(lastname.ToUpper()[0]);

            firstname = firstname.ToUpper();
            //output every character of firstname on a separate line with big letters    
            //for (int i = 0; i < firstname.Length; i++)
            //{
            // char currentletter = firstname[i];
            //  Console.WriteLine(currentletter);

            // }
           
            
            
            //Deandra Fogel
            //output reverse way
            string  name = firstname + " " + lastname;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.ReadKey();

            Console.WriteLine("Output every other letter of the firstname");
            for (int i = 0; i < firstname.Length; i = i +2)
            {
                char currentletter = firstname[i];
                Console.WriteLine(currentletter + " ");
            }






            Console.WriteLine($"Your intiials are {firstInitial}.{lastInitial}");
            Console.ReadKey();




        }



    }
}
