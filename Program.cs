using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int squared, cubed;
            
            Console.WriteLine("Learn your squares and cubes!");

                do
                {
                    Console.Write("Please enter an integer: ");
                    int input = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Number     Squared     Cubed");
                    for (int i = 1; i <= input; i++)
                    {
                        squared = i * i;
                        cubed = i * i * i;
                        Console.WriteLine("  {0}         {1}         {2}   ", i, squared, cubed);

                    }
                    Console.Write("Continue? (y/n) ");
                    response = Console.ReadLine().ToLower();
                }
                while (response == "y");
                if (response == "n")
                {
                Console.WriteLine("Peace out, yo");
                Console.ReadLine();
                }




        }
        //public static int SquaredCycle(int input, int i)
       // {
          //  for (int r = 1; r <= input; r++) ;

       // }

    }
}
