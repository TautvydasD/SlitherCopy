using System;
using System.Collections.Generic;
using System.Text;
using Snek.Shared.Entities;
using Snek.Shared.Entities.Consumables;
using Snek.Shared.Board;
using System.Linq;

namespace Snek.Shared.Classes
{
    public class Control
    {
        private Snake snake = new Snake();
        private List<IMemento> _mementos = new List<IMemento>();
        private int count = 0;

        public Control(Snake snake)
        {
            this.snake = snake;
        }

        public void Backup()
        {
            this._mementos.Add(this.snake.Save());
            count++;
        }

        public void UsePowerUp(Snake snake, PowerUp powerUp)
        {
            ICommand command = new UsepowerUp(powerUp, snake);
            Backup();
            command.Use();
        }

        public void UndoRandom()
        {
            Random rnd = new Random();
            Undo(rnd.Next(1, count));
        }

        /*public void Undo(int n)
        {
            if (count < n || count == 0 || n == 0)
            {
                return;
            }
            var memento = this._mementos.Last();
            this._mementos.Remove(memento);
            count--;
            n--;
            Console.WriteLine(count + " " + n);
            this.snake.Restore(memento);
            if (n == 0)
            {
                Backup();
            }
            Undo(n);
        }*/

        public void Undo(int n)
        {
            if (count < n || count == 0 || n == 0)
            {
                return;
            }
            Backup();
            n++;
            _mementos.Reverse();
            int i = 0;
            foreach (var memento in _mementos)
            {
                i++;
                if(i == n)
                {
                    this.snake.Restore(memento);
                    break;
                }
            }
            _mementos.Reverse();
        }
    }
}
