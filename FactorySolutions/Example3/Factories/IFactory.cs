using System;
using System.Collections.Generic;
using System.Text;

namespace Example3.Factories
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }
}