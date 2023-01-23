using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class emp
    {
        private int id;
        private string empname;
        private double salary;
        
        private static int count = 5; // static variable or class variable 
        public emp(string empname, double salary)
        {
            this.empname = empname;
            this.salary = salary;
           
            
            id = count;
            count++;
        }

        public static int DisplayCount() // static method or class method   

            /*Static method is also called as  class method, which is used to display value of static variable */


        {
            return count;
        }

        

        public string Print() // concret or instance method
        {
            return $"\n Id : {id} ,\n Name : {empname},\n salary : {salary} ";
        }


    }
}
