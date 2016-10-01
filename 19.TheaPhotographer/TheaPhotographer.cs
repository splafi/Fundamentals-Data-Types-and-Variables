using System;


namespace _19.TheaPhotographer
{
    public class TheaPhotographer
    {
        public static void Main(string[] args)
        {
            decimal pictures = decimal.Parse(Console.ReadLine());
            decimal filterTime = decimal.Parse(Console.ReadLine());
            decimal filterFactor = decimal.Parse(Console.ReadLine());
            decimal uploadTime = decimal.Parse(Console.ReadLine());
            decimal overallfilterTime = pictures * filterTime;
            decimal filteredpictures = Math.Ceiling((decimal)(filterFactor * pictures/100));
            decimal overallUploadTime = (decimal)(filteredpictures * uploadTime);
            int time = (int)(overallfilterTime + overallUploadTime);
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                timeSpan.Days,
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds);
        }
    }
}
