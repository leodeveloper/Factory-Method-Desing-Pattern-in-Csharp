using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone iphone;

            iphone = FactoryPhone.GetPhone(EnumPhoneType.PhoneType.ApplePhone);
            Console.WriteLine(iphone.GetPrice());

            iphone = FactoryPhone.GetPhone(EnumPhoneType.PhoneType.SumSungPhone);
            Console.WriteLine(iphone.GetPrice());

            Console.ReadLine();
        }
    }
}
