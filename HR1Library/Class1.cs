using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HR1Library
{
    public class Player
    {
        private int _playerid;

        public int PlayerID
        {
            get { return _playerid; }
            set { _playerid = value; }
        }

        private string _playername;

        public string  PlayerName
        {
            get { return _playername; }
            set { _playername = value; }
        }

        private int _playerage;

        public int PlayerAge
        {
            get { return _playerage; }
            set { _playerage = value; }
        }

       


    }

    interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);

        List<Player> GetAllPlayers();
    }

    public class OneDayTeam :Player, ITeam
    {

        public static List<Player> oneDayteam = new List<Player>();


        public OneDayTeam()
        {
            oneDayteam.Capacity = 11;
        }
        public void Add(Player player)
        {
        
         oneDayteam.Add(player);
            
        }

        public List<Player> GetAllPlayers()
        { 
        
           return oneDayteam;    
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;

            foreach (var item in oneDayteam)
            {
                if (item.PlayerID == playerId)
                {
                    player = item;

                    break;
                }
            }
            return player;


        }

        public Player GetPlayerByName(string playerName)
        {
            

            Player player = null;

            foreach (var item in oneDayteam)
            {
                if (item.PlayerName == playerName)
                {
                    player = item;

                    break;
                }
            }
            return player;
        }

        public void Remove( int playerId )
        {

            Player player = null;

            foreach (var item in oneDayteam)
            {
                if (item.PlayerID == playerId)
                {
                    Console.WriteLine("Player is Removed successfully");
                    player = item;
                }
            }
            oneDayteam.Remove(player);
        }
    }
}
