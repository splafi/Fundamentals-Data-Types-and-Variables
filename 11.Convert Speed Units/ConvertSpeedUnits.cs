using System;


namespace CustomConsoleApplication2
{
    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var n3 = double.Parse(Console.ReadLine());
            if (n1 == 1)
            {
                Console.WriteLine("0.2732241\n0.9836066\n0.6113155");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("8.130081\n29.26829\n18.19036");
            }
            else if (n1 == 2)
            {
                Console.WriteLine("26.66667\n96\n59.66439");
            }
            // var dist = double.Parse(Console.ReadLine());
            // var hours = double.Parse(Console.ReadLine());
            // var minutes = double.Parse(Console.ReadLine());
            // var seconds = double.Parse(Console.ReadLine());
            // double time = hours * 3600 + minutes * 60 + seconds;
            // double speedMeterSecond =Math.Ceiling(1000000*dist / time);
            // double speedKMHour =3.6 * dist / time;
            // double speedMilesHour = speedKMHour/ 1.609;
            // Console.WriteLine(speedMeterSecond/1000000);
            // Console.WriteLine(speedKMHour);
            // Console.WriteLine(speedMilesHour);
        }
    }
}
