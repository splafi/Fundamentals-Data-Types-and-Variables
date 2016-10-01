using System;


namespace _8.EmployeeData
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var personalID = long.Parse(Console.ReadLine());
            var employeeNumber = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}\n Last name: {lastName}\n Age: {age}\n Gender: {gender}\n Personal ID: {personalID}\n Unique Employee number: {employeeNumber}");
        }
    }
}
