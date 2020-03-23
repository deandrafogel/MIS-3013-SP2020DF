using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations
{
    class Program
    {//Deandra Fogel
        static void Main(string[] args)
        {
            string UserInput;
            string sound = "";
            Console.WriteLine("Please pick an animal: Cow, Cat, Dog, Pig");
            UserInput = Console.ReadLine();
            
            
            sound = Speak(UserInput);
            Console.WriteLine(sound);

        }
        static string Speak(string UserInput)
        

        {
            if (UserInput == "Cow")
            {
                sound = "Moo";
            }
            else if (UserInput == "Cat")
            {
                sound = "Meow";
            }
            else if (UserInput == "Dog")
            {
                sound = "Woof";
            }
            else if (UserInput == "Pig")
            {
                sound = "Oink";
            }
            else
            {
                sound = "Invalid input. Please try again.";
            }
            return sound;
        }
    }
}
