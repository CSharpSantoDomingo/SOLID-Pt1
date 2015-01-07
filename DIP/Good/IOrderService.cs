using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Common;

namespace DIP.Good
{
    public interface IOrderService
    {
        void MakeAOrder(Order order);
    }
}
