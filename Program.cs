using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAssignments
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your surname");
            string surName = Console.ReadLine();

            string fullName = firstName + " " + surName;
            string helloName = $"Hello , {firstName} {surName}";

            Console.WriteLine(fullName);
            Console.WriteLine(helloName);
            //Console.ReadLine(); Without Readline the above codes doesn't work
            Console.ReadLine();


        }
    }
}
