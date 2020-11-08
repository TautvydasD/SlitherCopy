﻿using Snek.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snek.Shared.Entities
{
    class Snake
    {
        public string Color { get; private set; }
        public int Length { get; private set; }
        public int Score { get; private set; }
    }
}
