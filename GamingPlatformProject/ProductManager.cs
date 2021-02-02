using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    class ProductManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Item is added to basket! Thank you " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Items deleted from your basket " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Basket have been updated " + gamer.FirstName);
        }
    }
}
