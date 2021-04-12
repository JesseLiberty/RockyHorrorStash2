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
                new DateTime(0,0,0,10,0,0),
                new DateTime(0,0,0,13,0,0),
                new DateTime(0,0,0,16,0,0),
                new DateTime(0,0,0,19,0,0),
                new DateTime(0,0,0,22,0,0),
                new DateTime(0,0,0,0,0,1)
            };
        }
    }
}
