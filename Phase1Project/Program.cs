using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR1Library;


namespace Phase1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Play:
                Console.WriteLine("Menu \nEnter 1:To Add Player 2:To Remove Player by Id " +
               "3:Get Player By Id 4:Get Player by Name 5:Get All Players:");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                
                    OneDayTeam team = new OneDayTeam();
                    if (OneDayTeam.oneDayteam.Count != OneDayTeam.oneDayteam.Capacity)
                    {
                        Console.Write("Enter the Player Id:");
                        team.PlayerID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Player Name:");
                        team.PlayerName = Console.ReadLine();
                        Console.Write("Enter the Player Age:");
                        team.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        team.Add(team);
                    }
                    else
                    {
                        Console.WriteLine("Can't add more than 11 players:");
                        goto Play;
                    }
                    break;
                case 2:
                    OneDayTeam t = new OneDayTeam();
                    Console.Write("Enter the Player Id to Remove:");
                    int r = Convert.ToInt32(Console.ReadLine());
                    t.Remove(r);
                    break;
                case 3:
                    OneDayTeam fn = new OneDayTeam();
                    Console.Write("Enter the Player Id to find:");
                    int pi = Convert.ToInt32(Console.ReadLine());
                    Player player = fn.GetPlayerById(pi);
                    Console.WriteLine(player.PlayerID);
                    Console.WriteLine(player.PlayerName);
                    Console.WriteLine(player.PlayerAge);
                    break;
                case 4:
                    OneDayTeam fa = new OneDayTeam();
                    Console.Write("Enter the Player Name to find:");
                    string pn = Console.ReadLine();
                    Player P= fa.GetPlayerByName(pn);
                    Console.WriteLine(P.PlayerID);
                    Console.WriteLine(P.PlayerName);
                    Console.WriteLine(P.PlayerAge);
                    break;
                case 5:
                    Console.WriteLine("List all the Players");
                    List<Player> list = new List<Player>();
                    OneDayTeam n = new OneDayTeam();
                    list = n.GetAllPlayers();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.PlayerID);
                        Console.WriteLine(item.PlayerName);
                        Console.WriteLine(item.PlayerAge);
                    }
                    break;


            }
            Console.WriteLine("Do you want to Continue (yes/no)?:");
            string s = Console.ReadLine();
            if (s == "yes")
            {
                goto Play;
            }




            Console.ReadLine();


           
        }
    }
}
