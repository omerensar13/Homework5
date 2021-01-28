using Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface ISalesWithCampaignService
    {
        void Sell(Game game, Player player, Campaign campaign);
    }
}
