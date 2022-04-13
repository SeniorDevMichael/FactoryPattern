using Example5.Factories;
using System;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilePhoneFactory = new MobilePhoneFactory();

            IMobilePhone mobilePhoneApple = mobilePhoneFactory.GetMobilePhone(MobilePhoneType.Apple);
            mobilePhoneApple.DisplayInfo();

            IMobilePhone mobilePhoneSamsung = mobilePhoneFactory.GetMobilePhone(MobilePhoneType.Samsung);
            mobilePhoneSamsung.DisplayInfo();

            Console.ReadLine();
        }
    }
}
