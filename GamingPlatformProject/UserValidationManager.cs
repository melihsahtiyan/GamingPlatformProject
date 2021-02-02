using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName == "Melih" 
                && gamer.LastName == "Sahtiyan" && gamer.IdentityNumber==12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
