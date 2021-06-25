using System;

namespace Winx
{
    class Program
    {
        static void Main(string[] args)
        {
            Fairy bloom = new Fairy() { Id = 1, Name = "Bloom", CountOfLife = 10, Power = 3000.00 };
            Fairy stella = new Fairy() { Id = 2, Name = "Stella", CountOfLife = 7, Power = 2500.00 };

            Console.WriteLine("Сила Блум больше чем у Стеллы: " + (bloom > stella));

            Fairy bloomStella = bloom + stella;
            Console.WriteLine($"Слияние двух персонажей:" +
                $"\n\tId: {bloomStella.Id}" +
                $"\n\tИмя: {bloomStella.Name}" +
                $"\n\tСила: {bloomStella.Power}" +
                $"\n\tКоличество жизней: {bloomStella.CountOfLife}");
        }
    }
}
