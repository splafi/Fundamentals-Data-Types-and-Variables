using System;


namespace _18.DifferentIntegersSize
{
    public class DifferentIntegersSize
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine();
            try
            {
                if (long.Parse(n) >= 0)
                {
                    try
                    {
                        short s = short.Parse(n);
                        Console.WriteLine($"{s} can fit in:\n* short\n* int\n* uint\n* long");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            uint ui = uint.Parse(n);
                            Console.WriteLine($"{ui} can fit in:\n* int\n* uint\n* long");
                        }
                        catch (Exception)
                        {
                            try
                            {
                                int i = int.Parse(n);
                                Console.WriteLine($"{i} can fit in:\n* int\n* long");
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    long l = long.Parse(n);
                                    Console.WriteLine($"{l} can fit in:\n* long");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine($"{n} can't fit in any type");
                                }
                            }
                        }
                    }
                }
                else
                {
                    try
                    {
                        short s = short.Parse(n);
                        Console.WriteLine($"{s} can fit in:\n* short\n* int\n* long");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            int i = int.Parse(n);
                            Console.WriteLine($"{i} can fit in:\n* int\n* long");
                        }
                        catch (Exception)
                        {
                            try
                            {
                                long l = long.Parse(n);
                                Console.WriteLine($"{l} can fit in:\n* long");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine($"{n} can't fit in any type");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}
