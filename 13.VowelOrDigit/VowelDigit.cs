using System;


namespace _13.VowelOrDigit
{
    public class VowelDigit
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine();
            try
            {
                int num = int.Parse(n);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                if (n == "a" || n == "e" || n == "y" || n == "u" || n == "i" || n == "o" )
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }




            //int number;
            //bool num = Int32.TryParse(n, out number);
            //if (num)
            //{
            //    Console.WriteLine("digit");
            //}
            //else if(n=="g")
            //{
            //    Console.WriteLine("other");
            //}
            //else 
            //{
            //    Console.WriteLine("vowel");
            //}
        }
    }
}
