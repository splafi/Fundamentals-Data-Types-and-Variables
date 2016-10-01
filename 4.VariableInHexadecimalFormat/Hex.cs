using System;


namespace _4.VariableInHexadecimalFormat
{
    class Hex
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var num1 = Convert.ToInt32(num, 16);
            Console.WriteLine(num1);
        }
    }
}
