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

            Console.WriteLine("Введите каолличество людей в очереди:");
            peopleInLine = int.Parse(Console.ReadLine());
            timeToWaitHours = peopleInLine * timeForOnePersonWaitingInMinutes / 60;
            timeToWaitMinutes = peopleInLine * timeForOnePersonWaitingInMinutes % 60;
            Console.WriteLine($"Ваше время ожидания в очереди {timeToWaitHours} часов и {timeToWaitMinutes} минут.");
            Console.ReadKey();
        }
    }
}
