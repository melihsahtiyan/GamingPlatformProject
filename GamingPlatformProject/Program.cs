using System;
using MernisServiceReference;

namespace GamingPlatformProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer=new Gamer
            {
                FirstName = "Melih",
                LastName = "Sahtiyan",
                BirthYear = 2000,
                Id = 1,
                IdentityNumber = 12345678910
            };

            gamerManager.Add(gamer);
            Product product = new Product();
            Campaign campaign = new Campaign();
            campaign.ProductId = 1;
            campaign.ProductName = "Wallet key";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            product.ProductId = 1;
            product.ProductName ="Wallet key";
            product.Price = 20;
            ProductManager productManager = new ProductManager();
            productManager.Add(gamer);

        }
    }
}
