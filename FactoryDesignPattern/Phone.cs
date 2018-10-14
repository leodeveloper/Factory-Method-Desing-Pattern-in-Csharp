using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.EnumPhoneType;

namespace FactoryDesignPattern


{
    public class ApplePhone : IPhone
    {
        public PhoneType Type { get { return PhoneType.ApplePhone; } }

        public decimal GetPrice()
        {
            return 1000;
        }
    }

    public class SamSungPhone : IPhone
    {
        public PhoneType Type { get { return PhoneType.SumSungPhone; } }
        public decimal GetPrice()
        {
            return 600;
        }
    }
}
