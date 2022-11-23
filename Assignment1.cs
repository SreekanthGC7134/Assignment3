using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{ 
       class student
        {
            public int rollno;
            public string name;
            public student(int r, string n)
            {
                rollno = r;
                name = n;
            }
            public void Displaydetails()
            {
                Console.WriteLine("Rollno :" + rollno + " and Name : " + name);
            }
        }
    public  class Assignment1
    {

        static void Main(string[] args)
        {
            student obj1 = new student(1, "Sreekanth");
            student obj2 = new student(2, "Vinay");
            obj1.Displaydetails();
            obj2.Displaydetails();
            Console.ReadKey();
        }
    }
}
