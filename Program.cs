using System;

namespace LineToPolyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int timeForOnePersonWaitingInMinutes = 10;
            int timeToWaitMinutes;
            int timeToWaitHours;
            int minutesInHour = 60;

            Console.WriteLine("Введите каолличество людей в очереди:");
            peopleInLine = int.Parse(Console.ReadLine());
            timeToWaitHours = peopleInLine * timeForOnePersonWaitingInMinutes / minutesInHour;
            timeToWaitMinutes = peopleInLine * timeForOnePersonWaitingInMinutes % minutesInHour;
            Console.WriteLine($"Ваше время ожидания в очереди {timeToWaitHours} часов и {timeToWaitMinutes} минут.");
            Console.ReadKey();
        }
    }
}
