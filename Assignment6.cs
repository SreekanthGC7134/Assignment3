﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment6
    {
        public int id, m1, m2, m3, total;
        public string name;
        public void read()
        {
            Console.WriteLine("Enter Student Id : ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter mark1 : ");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark2 : ");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark3 : ");
            m3 = int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            total = m1 + m2 + m3;
        }
        public void display()
        {
            Console.WriteLine("Student id : " + id);
            Console.WriteLine("Student name : " + name);
            Console.WriteLine("mark1 : " + m1);
            Console.WriteLine("mark2 : " + m2);
            Console.WriteLine("mark3 : " + m3);
            Console.WriteLine("Total : " + total);
        }
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students : ");
            n = int.Parse(Console.ReadLine());
            Assignment6[] obj = new Assignment6[n];
            for (int i = 0; i < n; i++)
            {
                obj[i] = new Assignment6();
                obj[i].read();
                obj[i].calculate();
                obj[i].display();
            }
            Console.ReadLine();
        }
    }
}
