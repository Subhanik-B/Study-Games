// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;
using Beans;

List<Teams> teamList = new List<Teams>();

    String[] teamNames = { "Cordinals", "Seachickens", "Goats", "Gold Diggers", "Vipings", "Cubs", "Puckers", "Cats", "Cows", "Migits", "Seagulls", "Lieutenants", "Malcons", "Pampers", "Devils", "Privateers", "Radens", "Tokers", "Greens", "Thiefs", "Buffalos", "Dophons", "Revolutionists", "Planes", "Mexicans", "Hoofs", "Jagg", "Smallans", "Horses", "Taylor's City", "Defenders", "Slowers" };
    for (int i = 0; i < 32; i++)
    {
        Teams teamA = new Teams();
        teamA.setTeamName(teamNames[i]);
        teamA.setOGPlayers();
        teamList.Add(teamA);
    }


    Console.WriteLine("Please select a team");
    for (int i = 0; i < teamList.Count(); i++)
    {
        Console.WriteLine(teamList[i].teamName + "[" + (i + 1) + "]");
    }

    int a = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (a)
    {
        case 1:
            teamList[0].printTeamRoster();
            break;
        case 2:
            teamList[1].printTeamRoster();
            break;
        case 3:
            teamList[2].printTeamRoster();
            break;
        case 4:
            teamList[3].printTeamRoster();
            break;
        case 5:
            teamList[4].printTeamRoster();
            break;
        case 6:
            teamList[5].printTeamRoster();
            break;
        case 7:
            teamList[6].printTeamRoster();
            break;
        case 8:
            teamList[7].printTeamRoster();
            break;
        case 9:
            teamList[8].printTeamRoster();
            break;
        case 10:
            teamList[9].printTeamRoster();
            break;
        case 11:
            teamList[10].printTeamRoster();
            break;
        case 12:
            teamList[11].printTeamRoster();
            break;
        case 13:
            teamList[12].printTeamRoster();
            break;
        case 14:
            teamList[13].printTeamRoster();
            break;
        case 15:
            teamList[14].printTeamRoster();
            break;
        case 16:
            teamList[15].printTeamRoster();
            break;
        case 17:
            teamList[16].printTeamRoster();
            break;
        case 18:
            teamList[17].printTeamRoster();
            break;
        case 19:
            teamList[18].printTeamRoster();
            break;
        case 20:
            teamList[19].printTeamRoster();
            break;
        case 21:
            teamList[20].printTeamRoster();
            break;
        case 22:
            teamList[21].printTeamRoster();
            break;
        case 23:
            teamList[22].printTeamRoster();
            break;
        case 24:
            teamList[23].printTeamRoster();
            break;
        case 25:
            teamList[24].printTeamRoster();
            break;
        case 26:
            teamList[25].printTeamRoster();
            break;
        case 27:
            teamList[26].printTeamRoster();
            break;
        case 28:
            teamList[27].printTeamRoster();
            break;
        case 29:
            teamList[28].printTeamRoster();
            break;
        case 30:
            teamList[29].printTeamRoster();
            break;
        case 31:
            teamList[30].printTeamRoster();
            break;
        case 32:
            teamList[31].printTeamRoster();
            break;
    }
List<Teams> schedule = new List<Teams>();
generateSchedule(schedule, a-1);



 void generateSchedule(List<Teams> bob, int index)
{
    for (int i = 0; i < 18; i++)
    {
        Random random = new Random();
        int b = random.Next(0,31);
        if (b != index)
        {
            bob[index] = teamList[b];
        }
    }
}









