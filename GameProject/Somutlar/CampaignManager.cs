using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kapmanyası Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kampanyası Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Kampanyası Güncellendi");
        }
    }
}
