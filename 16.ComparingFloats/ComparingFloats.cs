using System;


namespace _16.ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var n1 = double.Parse(Console.ReadLine());
            if (Math.Abs(n-n1)<0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
