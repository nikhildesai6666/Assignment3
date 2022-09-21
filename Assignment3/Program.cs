using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mark of math subject");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a mark of chemistry subject");
            int s2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter a mark of physics subject");
            int s3 = Convert.ToInt32(Console.ReadLine());

            int total = s1 + s2 + s3;
            Console.WriteLine($" Total is {total}");

            int per = total / 3;
            Console.WriteLine($" percentage is {per}");

            if (per >= 80)
            {
                Console.WriteLine("student in grade A");
            }
            else if (per <= 80 && per >= 70)
            {
                Console.WriteLine("student in grade B");
            }
            else if (per <= 70 && per >=60)
            {
                Console.WriteLine("student in grade C");
            }
            else if (per < 60)
            {
                Console.WriteLine("student in grade D");
            }


         }
    }
}
