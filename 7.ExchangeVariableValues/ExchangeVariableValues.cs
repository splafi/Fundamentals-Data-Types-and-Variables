using System;


namespace _7.ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\n a = {a}\n b = {b}");
            Console.WriteLine($"After:\n a = {b}\n b = {a}");
        }
    }
}
