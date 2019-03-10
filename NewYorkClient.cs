using System;

namespace AlphaMobile
{
	class NewYorkClient : Client
	{
		public static void Main(string[] args) {
			BaseSmartphoneFactory smartphoneFactory = BaseSmartphoneFactory.GetSmartphoneFactory("New York");
			Smartphone smart5 = smartphoneFactory.CreateSmartphone("smart5", "AlphaMobile Smart5", 599.99);
			Console.WriteLine("");
			Smartphone smart6 = smartphoneFactory.CreateSmartphone("smart6", "AlphaMobile Smart6", 699.99);
			Console.WriteLine("");
		}
	}
}
