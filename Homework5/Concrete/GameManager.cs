using Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name +" sisteme eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " sistemden silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " güncellendi");
        }
    }
}
