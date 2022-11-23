using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Consumer
    {
        private int consumer_Id;
        private string consumer_name;

        public Consumer(int id, string name)
        {
            consumer_Id = id;
            consumer_name = name;
        }

        public void Consumer_Display()
        {
            Console.WriteLine("Consumer Id : " + consumer_Id);
            Console.WriteLine("Consumer Name : " + consumer_name);
        }
    }

    class Consumption
    {
        private int unit_Previous;
        private int unit_Current;
        protected int unit_Consumed;

        public Consumption(int p, int c)
        {
            unit_Previous = p;
            unit_Current = c;
        }

        public void Consumption_Read()
        {
            Console.WriteLine("Enter Previous Unit : ");
            unit_Previous = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Unit : ");
            unit_Current = Convert.ToInt32(Console.ReadLine());
        }

        public int Consumption_Calculate()
        {
            return unit_Consumed = unit_Current - unit_Previous;

        }

        public void Consumption_Display()
        {
            Console.WriteLine("Units Consumed : " + unit_Consumed);
        }
    }

    class Bill : Consumer
    {
        private double amount;
        private double unit_Consumed;

        public Bill(int id, string name, int p, int c) : base(id, name)
        {
            Consumption con = new Consumption(p, c);
            con.Consumption_Read();
            con.Consumption_Calculate();
            con.Consumption_Display();
            Bill_Calculate();
            Bill_Display();
        }

        public double Bill_Calculate()
        {
            return amount = unit_Consumed * 0.5;

        }

        public void Bill_Display()
        {
            Console.WriteLine("Total Amount : " + amount);
        }
    }

    class assignment9
    {
        static void Main(string[] args)
        {
            Bill b = new Bill(1, "Sreekanth", 800, 4440);
            Console.ReadKey();
        }
    }
}
