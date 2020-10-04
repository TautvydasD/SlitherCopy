using System;
using System.Collections.Generic;
using System.Text;
using Snake.Shared.Entities;

namespace Snake.Shared.Entities
{
    public class Lobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }

        public Lobby(int id, User owner, string name)
        {
            Id = id;
            Owner = owner;
            Name = name;
        }
    }
}
