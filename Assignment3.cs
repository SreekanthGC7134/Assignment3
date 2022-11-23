using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
     class Assignment3
    {
        public static void Main(string[] args)
        {
            string word = "Its A wonderfull Experience for me";
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                }

            }

            Console.WriteLine("String :" + word);
            Console.Write("No.of spaces :" + count);
            Console.ReadLine();
        }
    }

}
