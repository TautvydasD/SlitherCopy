using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities;

namespace Snek.Shared.Classes
{
    public class Games
    {
        public string Id { get; set; }
        public User Player1 { get; set; }
        public User Player2 { get; set; }
        public string Winner { get; set; }
        public bool GameOver { get; set; }
        public bool IsStarted => !string.IsNullOrEmpty(Player1?.Username ?? "") && !string.IsNullOrEmpty(Player2?.Username ?? "");
        public string StatusText
        {
            get
            {
                if (string.IsNullOrEmpty(Player1?.Username) || string.IsNullOrEmpty(Player2?.Username))
                {
                    return "Waiting for player";
                }
                if (GameOver)
                {
                    return $"The winner is {Winner}";
                }
                if (Player1.IsMyTurn)
                {
                    return $"{Player1.Username} turn";
                }
                if (Player2.IsMyTurn)
                {
                    return $"{Player2.Username} turn";
                }
                return string.Empty;
            }

        }
        public Games(bool empty = true)
        {
            Id = Guid.NewGuid().ToString();
            if (empty)
            {
                Player1 = new User("");
                Player2 = new User("");
            }
        }

        public Games()
        {
            Player1 = new User("");
            Player2 = new User("");
        }

        public void AddPlayer(string name, bool isPlayer1 = true)
        {
            if (isPlayer1)
            {
                Player1 = new User(name);
            }
            else
            {
                Player2 = new User(name);
            }
        }

        public User GetPlayer(string id) => Player1.Id == id ? Player1 : Player2;

        public User GetPlayerByName(string name)
        {
            if (Player1.Username == name)
            {
                return Player1;
            }
            if (Player2.Username == name)
            {
                return Player2;
            }
            return null;
        }

        public bool SpotAvailable => string.IsNullOrEmpty(Player2?.Username);

        public void Start()
        {
        }
    }
}
