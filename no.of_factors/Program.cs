using System;

namespace no.of_factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a Number to find it's factors ! ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            for(int i = 1; i<num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                    cnt++;
                   
                }
            }
            Console.WriteLine("Total Factors = " + cnt);
        }
    }
}
