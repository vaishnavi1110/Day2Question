using System;

namespace SampleDay2Question
{
    class Program
    {
        static void count_even(int min, int max)
        {


            int n = 2;
            for (int i = min; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
        static void Main(string[] args)
        {
            int min = 1, max = 7;


<<<<<<< HEAD
            count_even_odd(min, max);
            Console.WriteLine("Utkarsh");
            
=======
            count_even(min, max);
>>>>>>> c86fd6284d2d9792eeaa2e51f9ebc5b46b1a4ec0

        }
    }
}


