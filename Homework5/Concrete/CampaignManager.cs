using Homework5.Abstract;
using Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası sisteme eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası sistemden silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası güncellendi");
        }
    }
}
