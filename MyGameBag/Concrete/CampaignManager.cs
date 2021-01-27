using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBag
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
