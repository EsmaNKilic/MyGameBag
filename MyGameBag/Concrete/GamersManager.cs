using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBag
{
    public class GamersManager : IGamers
    {
        public void Sell(Person person, Campaign campaign, Gamers game)
        {
            Console.WriteLine(person.Name + " kullanıcı" + game.GameName + " adlı oyunu satıyor" + campaign.CampaignType + " kampanyasından yararlanabilirsiniz");
        }
    }
}
