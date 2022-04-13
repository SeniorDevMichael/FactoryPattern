using Example2.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example2
{
    public class CommonFactory
    {
		public static IProviderService GetServiceFactory(string factory_name)
		{
			try
			{
				var myObject = Activator.CreateInstance("Example2", "Example2.Factories.All." + factory_name);
				var unwrapObject = myObject.Unwrap();

				return unwrapObject as IProviderService;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
