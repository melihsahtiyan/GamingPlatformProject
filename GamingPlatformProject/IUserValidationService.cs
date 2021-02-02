using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatformProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
