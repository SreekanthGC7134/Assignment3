﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
     class Assignment5
    {
        class book
        {
            private int BOOKNO;
            private string BOOKTITLE;
            private float PRICE;

            public void INPUT()
            {
                Console.Write("Enter the Book.No : ");
                BOOKNO = int.Parse(Console.ReadLine());
                Console.Write("Enter the Book Title : ");
                BOOKTITLE = Console.ReadLine();
                Console.Write("Enter the Price : ");
                PRICE = int.Parse(Console.ReadLine());
            }

            public float TOTAL_COST(int n)
            {
                float TC = PRICE * n;
                return TC;
            }

            public void PURCHASE()
            {
                Console.Write("Enter the number of copies to be purchased: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost to be paid : " + TOTAL_COST(n));
            }

            public void display()
            {
                Console.WriteLine("Book.No : " + BOOKNO);
                Console.WriteLine("Book Title : " + BOOKTITLE);
                Console.WriteLine("Price : " + PRICE);
            }

            static void Main(string[] args)
            {
                book obj = new book();
                obj.INPUT();
                obj.PURCHASE();
                obj.display();
                Console.ReadLine();
            }
        }
    }
}
