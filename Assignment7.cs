using System;

namespace Assignment3
{
    class PassRefer
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the Student id : ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark : ");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(PassRefer pr1, PassRefer pr2)
        {
            PassRefer temp = new PassRefer();
            temp = pr1;
            pr1 = pr2;
            pr2 = temp;
        }
        public void display()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Mark : " + mark);
        }
    }


    class Assignment7
    {
        static void Main(string[] args)
        {
            PassRefer pr1 = new PassRefer();
            PassRefer pr2 = new PassRefer();
            pr1.read();
            pr2.read();
            Console.WriteLine("Details Before Swapping : ");
            pr1.display();
            pr2.display();
            pr1.swap(pr1, pr2);
            Console.WriteLine("Details After Swapping : ");
            pr1.display();
            pr2.display();
            Console.ReadLine();
        }
    }
}
