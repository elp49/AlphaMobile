using System;

namespace AlphaMobile
{
	abstract class Client
	{
		public static void Main(string[] args) {
			BaseSmartphoneFactory smartphoneFactorySG = BaseSmartphoneFactory.GetSmartphoneFactory("Singapore");
			Smartphone smart4SG = smartphoneFactorySG.CreateSmartphone("smart4", "AlphaMobile Smart4", 499.99);
			Console.WriteLine();
			Smartphone smart5SG = smartphoneFactorySG.CreateSmartphone("smart5", "AlphaMobile Smart5", 599.99);
			Console.WriteLine();

			BaseSmartphoneFactory smartphoneFactoryNY = BaseSmartphoneFactory.GetSmartphoneFactory("New York");
			Smartphone smart5NY = smartphoneFactoryNY.CreateSmartphone("smart5", "AlphaMobile Smart5", 599.99);
			Console.WriteLine();
			Smartphone smart6NY = smartphoneFactoryNY.CreateSmartphone("smart6", "AlphaMobile Smart6", 699.99);
			Console.WriteLine();
		}
	}
}
