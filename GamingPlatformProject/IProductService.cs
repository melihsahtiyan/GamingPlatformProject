using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    interface IProductService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
