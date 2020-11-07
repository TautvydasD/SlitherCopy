using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared;
using Snek.Shared.Entities;

namespace Snek.Shared.Classes
{
    class UsepowerUp : ICommand
    {
        private PowerUp _powerUp;
        private Snake _snake;
        public UsepowerUp(PowerUp powerUp, Snake snake)
        {
            _powerUp = powerUp;
            _snake = snake;
        }
        public override void Discard()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            _snake.UsePowerUp(_powerUp.Name);
        }
    }
}
