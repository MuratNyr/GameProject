using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("campaign discount added" + " " + campaign.CampaignName + " " + campaign.CampaignDiscount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("campaign discount deleted" + " " + campaign.CampaignName + " " + campaign.CampaignDiscount);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("campaign discount updated" + " " + campaign.CampaignName + " " + campaign.CampaignDiscount);
        }
    }
}
