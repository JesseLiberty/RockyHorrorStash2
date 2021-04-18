using System;
using System.Collections.Generic;

namespace RockyHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            var showing = new Showing();
            showing.Location = "Brattle";
            showing.NumberOfSeats = 250;
            showing.ShowTimes = new List<DateTime>
            {
                new DateTime(2021,4,13,10,0,0),
                new DateTime(2021,4,13,13,0,0),
                new DateTime(2021,4,13,16,0,0),
                new DateTime(2021,4,13,19,0,0),
                new DateTime(2021,4,13,22,0,0),
                new DateTime(2021,4,13,0,0,1)
            };

            Console.WriteLine($"{showing.Location} has {showing.NumberOfSeats} and there is a show at {showing.ShowTimes[3]}");
        }
    }
}
