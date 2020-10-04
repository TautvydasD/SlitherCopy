using System;
using System.Collections.Generic;
using System.Text;
using Snake.Shared.Entities;

namespace Snake.Server.Entities
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();
        public List<Lobby> lobbies { get; set; }
        public List<User> players { get; set; }

        public Singleton() //dunno if public 
        {
            lobbies = new List<Lobby>();
            players = new List<User>();
        }

        public bool CreateLobby()
        {
            Lobby newLobby = new Lobby(1, )
        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
