// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Beans;

List<Teams> teamList = new List<Teams>();
String[] teamNames = {"Cordinals", "Seachickens", "Goats", "Gold Diggers", "Vipings", "Cubs", "Puckers", "Cats", "Cows", "Migits", "Seagulls", "Lieutenants", "Malcons", "Pampers", "Devils", "Privateers", "Radens", "Tokers", "Greens", "Thiefs", "Buffalos", "Dophons", "Revolutionists", "Planes", "Mexicans", "Hoofs", "Jagg", "Smallans", "Horses", "Taylor's City", "Defenders", "Slowers"};
for (int i = 0; i < 32; i++)
{
    Teams teamA = new Teams();
    teamA.setTeamName(teamNames[i]);
    teamA.setOGPlayers();
    teamList.Add(teamA);
}


    Console.WriteLine("Current teams are:");
    for (int i = 0; i < teamList.Count(); i++)
    {
        teamList[i].printTeamRoster();
    }




