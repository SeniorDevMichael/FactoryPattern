using Example5.Factories;
using Example5.Factories.All;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example5
{
    public class MobilePhoneFactory : IMobilePhoneFactory
    {
        public IMobilePhone GetMobilePhone(MobilePhoneType type)
        {
            IMobilePhone mobilePhone = null;

            switch (type)
            {
                case MobilePhoneType.Apple:
                    mobilePhone = new Apple();
                    break;
                case MobilePhoneType.Samsung:
                    mobilePhone = new Samsung();
                    break;
            }

            return mobilePhone;
        }
    }
}
