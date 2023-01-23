using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emp emp1 = new emp("Ram",15000);
            emp emp2 = new emp("shyam", 20000);

            Console.WriteLine(emp1.Print());
            Console.WriteLine(emp2.Print());

            Console.WriteLine($"\n \n Total objects of class {emp.DisplayCount()}"); 
            
            // static method is called using class name

        }

    }
}
