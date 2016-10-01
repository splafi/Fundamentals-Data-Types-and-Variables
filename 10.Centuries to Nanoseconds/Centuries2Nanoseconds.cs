using System;
using System.Numerics;


namespace CustomConsoleApplication1
{
    public class Centuries2Nanoseconds
    {
        public static void Main(string[] args)
        {
            var centuries = byte.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(365.2422*years);
            long hours = (long)24*days;
            BigInteger minutes = BigInteger.Multiply(hours,60);
            BigInteger seconds = BigInteger.Multiply(minutes,60);
            BigInteger milliseconds = BigInteger.Multiply(seconds, 1000);
            BigInteger microseconds = BigInteger.Multiply(milliseconds, 1000);
            BigInteger nanoseconds = BigInteger.Multiply(milliseconds, 1000000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
