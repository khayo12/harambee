using Harambee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harambee.Interfaces
{
    public interface IBasketLogic
    {
        bool CheckBunndle(Basket basket);
        double CheckValue(Basket basket);
    }
}
