using Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.Name == "Namık" && player.Surname == "TAŞ" && player.NationalityId == "12345" && player.DateOfBirth == "19/11/2000")
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
