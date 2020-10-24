using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Classes;

namespace Snek.Shared.Entities
{
    public class User
    {
        public string Username { get; private set; }
        public string Id { get; set; }
        public bool IsMyTurn { get; set; }
        public string ConnectionId { get; set; }

        public Coordinates Coordinates { get; set; }
        public User() { }
        public User(string name)
        {
            Id = Guid.NewGuid().ToString();
            Username = name;
            Coordinates = new Coordinates(RandomNumber(0, 9), RandomNumber(0, 9));
        }

        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
