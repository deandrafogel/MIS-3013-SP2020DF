using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTextBoxParticipation
{
    class Program
    {//Author: Deandra Fogel, Worked with Elizabeth Sparks and Riley Carr
        static void Main(string[] args)
        {
            TextBox FirstTextBox = new TextBox();
            FirstTextBox.BackColor = ConsoleColor.Blue;
            FirstTextBox.ForeColor = ConsoleColor.Magenta;
            FirstTextBox.Padding = 3;
            FirstTextBox.Text = "The sky is blue";

            TextBox SecondTextBox = new TextBox();
            SecondTextBox.BackColor = ConsoleColor.Red;
            SecondTextBox.ForeColor = ConsoleColor.Green;
            SecondTextBox.Padding = 10;
            SecondTextBox.Text = "Red and green are Christmas colors";

            FirstTextBox.DisplayText();
            SecondTextBox.DisplayText();

            Console.ReadKey();

        }
    }
}
