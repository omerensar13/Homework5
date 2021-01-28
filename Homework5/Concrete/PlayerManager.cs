using Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Concrete
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Name + " " + player.Surname + " sistemden silindi");
        }

        public void Save(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
              Console.WriteLine(player.Name + " " + player.Surname + " sisteme kaydedildi");
            }
            else
            { 
            Console.WriteLine(player.Name + " " + player.Surname + " Doğrulama başarısız. Kullanıcı sisteme kaydedilemedi!");
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Name + " " + player.Surname + " sistemde güncellendi");
        }
    }
}
