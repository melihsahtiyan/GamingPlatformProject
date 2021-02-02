using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.ProductName + " have a new discount, prices updated!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is finished, " + campaign.ProductName + " came back to old price...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign have updated, " + campaign.ProductName + "");
        }
    }
}
