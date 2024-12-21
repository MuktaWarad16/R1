using System;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i == 1)
                {
                    Console.WriteLine("First element: " + i);
                }
            }

            Random random = new Random();
            int r = random.Next(1, 7);
            Console.WriteLine("Number between 1 and 6 is: " + r);



        }
        



    }
}
