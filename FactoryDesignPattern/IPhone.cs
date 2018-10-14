using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.EnumPhoneType;

namespace FactoryDesignPattern
{
    public interface IPhone
    {
        PhoneType Type { get; }
        decimal GetPrice();
    }
}
