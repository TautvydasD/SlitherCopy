using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities;
using Snek.Shared.Entities.Consumables;
using Snek.Shared.Board;

namespace Snek.Shared.Classes
{
    public class Control
    {
        //private Snake snake = new Snake();
        private List<ICommand> commands = new List<ICommand>();
        private int current = 0;

        public Control()
        {

        }
        public void UsePowerUp(Snek.Shared.Board.Snake snake, PowerUp powerUp)
        {
            ICommand command = new UsepowerUp(powerUp, snake);
            command.Use();
            commands.Add(command);
            current++;
        }


        public void Discard(int command)
        {
            if(command < current)
            {
                commands[command].Discard();
            }
        }
    }
}
