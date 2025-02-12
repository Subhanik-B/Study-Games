using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    internal class Teams
    {
        public int maxPlayers { get; set; }
        public String teamName { get; set; }

        Random random = new Random();
        public List<Player> players = new List<Player>();
        String[] randomNames = {"Bob Cheese", "Jarry Loaf", "Larry Fitzy", "Benchy Bonchy", "Kim Bim", "John Doe", "Billy Jackson", "Jason Rivera", "Romulus Kofulus", "The Monk", "Poe Edgar", "Nathaniel Eby", "Anothony Egolf", "Janky Mone", "Ferrial Perseus"};

        public double getOAverage()
        {
            double average = 0;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].Position < 11)
                {
                    average += players[i].Overall;
                }
            }
            return average;
        }

        public void setOGPlayers()
        {
            for (int i = 1; i < random.Next(3,6); i++)
            {
                Player a = new Player();
                a.player(randomNames[random.Next(0, randomNames.Count())], 2, random.NextDouble() + random.Next(1, 5));
                players.Add(a);
            }
        }

        public void setTeamName(String name)
        {
            teamName = name;
        }

        public void printTeamRoster()
        {
            Console.WriteLine("Team Name:");
            Console.WriteLine(teamName);
            Console.WriteLine("");
            Console.WriteLine("     Amount of Star Players:");
            Console.WriteLine("     " + players.Count());
            Console.WriteLine("");
            Console.WriteLine("     Player Names/Positions:");
            for (int i = 0; i < players.Count(); i++)
            {
                Console.WriteLine("     " + players[i].Name + " " + players[i].Overall);
            }
            Console.WriteLine("");
        }
    }
}
