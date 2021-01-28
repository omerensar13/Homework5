using Homework5.Concrete;
using Homework5.Entities;
using Homework5.Abstract;
using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Save(new Player { Id = 1, Name = "Namık", Surname = "TAŞ", NationalityId = "12345", DateOfBirth = "19/11/2000" });
            playerManager.Save(new Player { Id = 2, Name = "Ali", Surname = "CACIK", NationalityId = "48115", DateOfBirth = "19/11/2012" });
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game {Id = 1, Name = "GTA", Price = 89});
            gameManager.Add(new Game {Id = 2, Name = "HITMAN", Price = 120});
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, Name = "Bahar Kampanyası", Instructions = "Ürünlerde %40 indirim" });
            campaignManager.Add(new Campaign { Id = 2, Name = "Güz Kampanyası", Instructions = "Ürünlerde %20 indirim" });
            Player player1 = new Player();
            player1.Id = 3;
            player1.Name = "Mehmet";
            player1.Surname = "KAYA";
            player1.NationalityId = "12334324";
            player1.DateOfBirth = "12/04/2003";
            Game game1 = new Game();
            game1.Id = 3;
            game1.Name = "SKYRIM";
            game1.Price = 50;
            Campaign campaign1 = new Campaign();
            campaign1.Id = 3;
            campaign1.Name = "Kış indirimleri";
            campaign1.Instructions = "Ürünlerde %30 indirim";
            SalesManager salesManager = new SalesManager();
            SalesWithCampaignManeger salesWithCampaignManeger = new SalesWithCampaignManeger();
            salesManager.Sell(game1, player1);
            salesWithCampaignManeger.Sell(game1, player1, campaign1);

        }

    }
}
