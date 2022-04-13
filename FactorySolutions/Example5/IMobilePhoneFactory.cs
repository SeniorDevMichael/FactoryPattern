using Example5.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example5
{
    public interface IMobilePhoneFactory
    {
        IMobilePhone GetMobilePhone(MobilePhoneType type);
    }
}
