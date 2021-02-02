using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("You have signed up. Welcome " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Validation failure. Registary failed...");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Your account have been deleted. Goodbye " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Your account is updated " + gamer.FirstName);
        }
    }
}
