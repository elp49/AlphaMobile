using System;

namespace AlphaMobile
{
	class SingaporeClient : Client
	{
		public static void Main(string[] args) {
			BaseSmartphoneFactory smartphoneFactory = BaseSmartphoneFactory.GetSmartphoneFactory("Singapore");
			Smartphone smart4 = smartphoneFactory.CreateSmartphone("smart4", "AlphaMobile Smart4", 499.99);
			Console.WriteLine("");
			Smartphone smart5 = smartphoneFactory.CreateSmartphone("smart5", "AlphaMobile Smart5", 599.99);
			Console.WriteLine("");
		}
	}
}
