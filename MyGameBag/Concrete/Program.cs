using System;

namespace MyGameBag
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new GamerAdult();
            person.Id = 5714063;
            person.Tc = "12345678910";
            person.Name = "Esma Nur";
            person.Surname = "KILIÇ";
            person.BirthOfYear = new DateTime(1999);

            IUsersService usersService = new PersonManager(new CheckPersonManager());
            usersService.Add(person);

            Campaign campaign = new Campaign();
            campaign.CampaignType = " Yılbaşı Özel Kampanyası";
            
            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);

            Gamers game = new Gamers();
            game.GameName = "";
            game.GamePrice = 50;
            game.Id = 2;

            IGamers gamers = new GamersManager();
            gamers.Sell(person, campaign, game);
               
        
        }

       


    }
}