using Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sell(Game game, Player player)
        {
            Console.WriteLine(player.Name + " " + player.Surname + " kullanıcısı " + game.Name + " oyununu satın aldı");
        }
    }
}
