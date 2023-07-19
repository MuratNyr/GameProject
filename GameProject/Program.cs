using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.NationalityId = "111111111111";
            customer.FirstName = "Murat";
            customer.LastName = "Nayir";
            customer.DateOfBirth = new DateTime(2002, 12, 21);

            Game game = new Game();
            game.Id = 1;
            game.GameName = "Counter Strike";
            game.GamePrice = 15;

            Campaign campaign = new Campaign();
            campaign.Id = 2;
            campaign.CampaignName = "Need For Speed";
            campaign.CampaignDiscount = 25;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            CampaignManager CampaignManager = new CampaignManager();
            CampaignManager.Add(campaign);

            Console.ReadLine();
        }
        
    }
}
