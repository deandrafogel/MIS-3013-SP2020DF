using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Student
{
    class WPFStudent
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        public WPFStudent()
        {
            StudentID = StudentID;
            FirstName = "";
            LastName = "";
            FavoriteColor = "";
        }

        public override string ToString()
        {
            return "Student:" + FirstName + ", " + LastName + ", " + StudentID + ", " + FavoriteColor;
                
        }
        
    }
}
