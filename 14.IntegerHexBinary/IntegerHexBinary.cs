using System;


namespace _14.IntegerHexBinary
{
    public class IntegerHexBinary
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:X}",n);
            string binary = Convert.ToString(n,2);
            Console.WriteLine(binary);
        }
    }
}
