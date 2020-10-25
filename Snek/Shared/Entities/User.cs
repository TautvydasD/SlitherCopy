﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string ConnectionID { get; set; }

        public User(string username, string connectionID)
        {
            Username = username;
            ConnectionID = connectionID;
        }

        public User()
        {

        }
    }
}
