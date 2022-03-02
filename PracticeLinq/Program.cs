using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();
            videoGames.Add("Super Mario 64");
            videoGames.Add("Banjo Kazooie");
            videoGames.Add("Gears of War");
            videoGames.Add("Pokemon Red");
            videoGames.Add("Crash Bandicoot: Warped");
            videoGames.Add("Star Wars Episode I: Racer");
            videoGames.Add("Halo 2");
            videoGames.Add("Pikmin");
            videoGames.Add("Paper Mario");
            videoGames.Add("Star Wars: Battlefront II");
            videoGames.Add("Kirby Super Star");
            videoGames.Add("Mario Kart 64");
            videoGames.Add("Super Smash Bros. Brawl");
            videoGames.Add("Galaxian");

            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
