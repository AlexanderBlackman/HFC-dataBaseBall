using System;
using System.Collections.Generic;


namespace HFC_dataBaseBall
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, RetiredPlayer> retiredYankees = new Dictionary<int, RetiredPlayer>()
            {
                { 3, new RetiredPlayer("Babe Ruth", 1948) },
                {4, new RetiredPlayer("Lou Gehrig", 1939) },
                {5, new RetiredPlayer("Joe DiMaggio", 1952)},
                {7, new RetiredPlayer("Mickey Mantle", 1969) },
                {8, new RetiredPlayer("Yogi Berra", 1972) },
            };

            foreach (int jerseyNumber in retiredYankees.Keys)
            {
                RetiredPlayer playa = retiredYankees[jerseyNumber];
                Console.WriteLine($"{playa.Name} #{jerseyNumber} retired in {playa.YearRetired}");
            }



        }
    }
}
