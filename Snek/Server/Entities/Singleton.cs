using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Snek.Shared.Entities;
using System.Media;

namespace Snek.Server.Entities
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        public List<Lobby> Lobbies { get; set; }
        public List<User> Players { get; set; }
        public int generatedRooms;
        public int generatedPlayers;

        public Singleton()
        {
            Lobbies = new List<Lobby>();
            generatedRooms = 0;
            generatedPlayers = 0;
            Players = new List<User>();

        }

        public void AddPlayer(User user)
        {
            if(generatedPlayers < 4)
            {
                generatedPlayers++;
                user.Index = generatedPlayers;
                Players.Add(user);
            }
        }
        public void DeletePlayer(User userD)
        {
            Players.RemoveAll(user => user.Username == userD.Username);
            generatedPlayers--;
        }

        public String DeletePlayerByConnectionId(String connectionId)
        {
            string userName = null;
            userName = Players.FirstOrDefault(entry => entry.ConnectionID == connectionId).Username;
            if (userName != null)
            {
                User user = new User(userName, connectionId);
                DeletePlayer(user);
            }
            return userName;
        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
