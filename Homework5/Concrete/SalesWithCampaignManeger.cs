using Homework5.Abstract;
using Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class SalesWithCampaignManeger : ISalesWithCampaignService
    {
        public void Sell(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(player.Name + " " + player.Surname + " kullanıcısı " +campaign.Name + " kampanyası ile " + game.Name + " oyununu satın aldı");
        }
    }
}
