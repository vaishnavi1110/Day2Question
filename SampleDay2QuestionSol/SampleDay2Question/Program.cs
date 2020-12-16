using System;

namespace SampleDay2Question
{
    class Program
    {
        static void count_even_odd(int min, int max)
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


            count_even_odd(min, max);
            Console.WriteLine("Utkarsh");
            

        }
    }
}


