using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);
        
    }
}
