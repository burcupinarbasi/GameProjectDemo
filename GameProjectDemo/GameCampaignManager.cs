using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameCampaignManager : IGameCampaignManager
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
