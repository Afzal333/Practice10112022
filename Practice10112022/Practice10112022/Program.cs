using System;

namespace Practice10112022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problem");
            Console.WriteLine("Enter Options"+"\n"+
                                "1.Even or Odd");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1: 
                    EvenorOdd evenorOdd = new EvenorOdd();
                    evenorOdd.EvenOdd();
                    break;
            }
        }
    }
}
