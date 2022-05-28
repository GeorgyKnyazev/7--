using System;

namespace _7_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество человек в очереди: ");
            int numberOfPeopleInTheQueue = Convert.ToInt32(Console.ReadLine());
            int durationOfreception = 10;
            int waitingHours = (numberOfPeopleInTheQueue * durationOfreception) / 60;
            int minutesOfWaiting = (numberOfPeopleInTheQueue * durationOfreception) % 60;
            Console.WriteLine($"Вы должны стоять в очереди {waitingHours} часа и {minutesOfWaiting} минут");
        }
    }
}
