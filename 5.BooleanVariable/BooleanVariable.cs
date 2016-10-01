using System;


namespace _5.BooleanVariable
{
   public class BooleanVariable
    {
       public static void Main(string[] args)
        {
            var bl = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(bl);
            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}
