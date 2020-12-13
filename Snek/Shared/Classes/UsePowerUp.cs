using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared;
using Snek.Shared.Entities;
using Snek.Shared.Board;

namespace Snek.Shared.Classes
{
    class UsepowerUp : ICommand
    {
        private PowerUp _powerUp;
        private Snek.Shared.Board.Snake _snake;
        public UsepowerUp(PowerUp powerUp, Snek.Shared.Board.Snake snake)
        {
            _powerUp = powerUp;
            _snake = snake;
        }

        public override void Use()
        {
            _snake.UsePowerUp(_powerUp);
        }
    }
}
