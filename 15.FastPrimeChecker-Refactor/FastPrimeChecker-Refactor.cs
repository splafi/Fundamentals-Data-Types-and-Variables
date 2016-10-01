using System;


namespace _15.FastPrimeChecker_Refactor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isTrue = true;
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    if (i % y == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
