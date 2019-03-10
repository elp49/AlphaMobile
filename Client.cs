using System;

namespace AlphaMobile
{
	public class Client
	{

		public static void Main(string[] args) {
			BaseSmartphoneFactory smartphoneFactory = new SmartphoneFactory();
			Smartphone smart4 = smartphoneFactory.CreateSmartphone("smart4", "AlphaMobile Smart4", 499.99);
			Console.WriteLine("");
			Smartphone smart5 = smartphoneFactory.CreateSmartphone("smart5", "AlphaMobile Smart5", 599.99);
			Console.WriteLine("");
			Smartphone smart6 = smartphoneFactory.CreateSmartphone("smart6", "AlphaMobile Smart6", 699.99);
			Console.WriteLine("");
		}
	}
}
