using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTextBoxParticipation
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public TextBox()
        {
           
        }
        public void DisplayText()
        {
            Console.ForegroundColor = this.ForeColor;
            Console.BackgroundColor = this.BackColor;
            string TextTyped = new string(' ', this.Padding) + this.Text + new string(' ', this.Padding);
            Console.WriteLine(TextTyped);

        }



    }
}
