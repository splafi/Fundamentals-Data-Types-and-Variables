using System;


namespace _17.PrintPartASCIITable
{
    public class PrintPartASCIITable
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            for (int i = n; i <= n1; i++)
            {
                char ansii = Convert.ToChar(i);
                Console.Write("{0} ",ansii);
            }
        }
    }
}
