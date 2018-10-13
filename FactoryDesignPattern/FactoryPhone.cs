using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.EnumPhoneType;

namespace FactoryDesignPattern
{
    public class FactoryPhone
    {
        private static IPhone iPhone;
        public static IPhone GetPhone(PhoneType phoneType)
        {            
            if (phoneType == PhoneType.ApplePhone)
            {
                iPhone = new ApplePhone();
            }
            else if (phoneType == PhoneType.SumSungPhone)
            {
                iPhone= new SamSungPhone();
            }
            else
            {
                return null;
            }
            
            return iPhone;
        }
    }
}
