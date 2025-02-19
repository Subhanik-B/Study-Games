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
            int playersCounted = 0;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].Position < 11)
                {
                    average += players[i].Overall;
                    playersCounted++;
                }
            }
            return average / playersCounted;
        }
        public double getDAverage()
        {
            double average = 0;
            int playersCounted = 0;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].Position >= 11)
                {
                    average += players[i].Overall;
                    playersCounted++;
                }
            }
            return average / playersCounted;
        }

        public void setOGPlayers()
        {
            for (int i = 0; i < random.Next(3,6); i++)
            {
                Player a = new Player();
                a.player(randomNames[random.Next(0, randomNames.Count())], random.Next(0,23), random.NextDouble() + random.Next(1, 5));
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
            Console.WriteLine(teamName + "\n");
            Console.WriteLine("     Amount of Star Players:");
            Console.WriteLine("     " + players.Count() + "\n");
            Console.WriteLine("     Player Names/Positions:");
            for (int i = 0; i < players.Count(); i++)
            {
                Console.WriteLine("     " + players[i].Name + " " + players[i].Overall + " " + players[i].Position);
            }
            Console.WriteLine("");
        }
    }
}
