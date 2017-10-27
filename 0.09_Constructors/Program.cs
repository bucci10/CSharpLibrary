using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ciprianStudent = new Student("Ciprian", "Bucci", 52, 5);


            ciprianStudent.FirstName = "Ciprian";
            ciprianStudent.LastName = "Bucci";
            ciprianStudent.Grade = 5;
            ciprianStudent.Age = 52;

            Student jon = new Student("jon", "williams", 20);

        }
    }
}
