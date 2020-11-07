using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities;
using Snek.Shared.Entities.Consumables;

namespace Snek.Shared.Classes
{
    class Control
    {
        //private Snake snake = new Snake();
        private List<ICommand> commands = new List<ICommand>();
        private int current = 0;


        public void UsePowerUp(Snake snake, PowerUp powerUp)
        {
            ICommand command = new UsepowerUp(powerUp, snake);
            command.Use();
            commands.Add(command);
            current++;
        }


        public void Discard()
        {

        }
    }
}
