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

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
