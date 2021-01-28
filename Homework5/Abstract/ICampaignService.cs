using Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
