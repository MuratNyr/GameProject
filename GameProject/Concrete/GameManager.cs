using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("The game has been added to the library" + " " + game.GameName + " " + game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("The game has been deleted to the library" + " " + game.GameName + " " + game.GamePrice);
        }

        public void Sell(Game game)
        {
            Console.WriteLine("The game has been updated to the library" + " " + game.GameName + " " + game.GamePrice);
        }
    }
}
