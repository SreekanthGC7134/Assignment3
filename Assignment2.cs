using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class poly
    {
        public void sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is " + c);
        }
        public void sum(double a, double b, double d)
        {
            double c = a + b + d;
            Console.WriteLine("The sum is " + c);
        }

    }
    public class Assignment2
    {
        static void Main(string[] args)
        {
            poly obj = new poly();
            obj.sum(10, 8);
            obj.sum(14.2, 21.6, 11.2);
            Console.ReadKey();


        }
    }
}
