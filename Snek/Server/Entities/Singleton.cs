using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Snek.Shared.Entities;

namespace Snek.Server.Entities
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        public List<Lobby> lobbies { get; set; }
        public List<User> players { get; set; }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
