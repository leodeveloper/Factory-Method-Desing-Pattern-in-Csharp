using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ApplePhone : IPhone
    {
        public decimal GetPrice()
        {
            return 1000;
        }
    }

    public class SamSungPhone : IPhone
    {
        public decimal GetPrice()
        {
            return 600;
        }
    }
}
