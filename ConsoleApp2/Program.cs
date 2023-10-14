using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            string name = "mohamed";
            bool check = false;
            char one ='m';
            double degree = 7.5;
            const string secondname = "samir";

            if (check == true) {
                Console.WriteLine("my name is: " + name);
                Console.WriteLine("my age is: " + age);
                Console.WriteLine("first character in my name is: " + one);
                Console.WriteLine("my second name is: " + secondname);
                Console.WriteLine("my degree is: " + degree);

                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
            else {
                Console.WriteLine("there is nothing *_*");
                Console.Beep();
                  }
            
        }
    }
}
