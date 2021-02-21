using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface IGameCampaignManager
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
