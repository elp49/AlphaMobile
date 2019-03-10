using System;

namespace AlphaMobile
{

	abstract class Smartphone
	{
		public string Label { get; set; }
		public double Price { get; set; }

		public Smartphone() {
			Label = "Default Label";
		}

		public abstract string GetModel();

		public void Assemble(string location) {
			Console.WriteLine("{0} being assembled in {1}.", GetModel(), location);
		}

		public void SetLabel(string label) {
			Console.WriteLine("{0} being labeled as '{1}'.", GetModel(), label);
			Label = label;
		}

		public void SetPrice(double price) {
			if (price < 0) {
				throw new ArgumentException("Price cannot be negative.");
			}
			Console.WriteLine("{0} price being set to ${1}.", GetModel(), price);
			Price = price;
		}
	}


	class Smart4 : Smartphone
	{
		public override string GetModel() {
			return "Smart4";
		}
	}


	class Smart5 : Smartphone
	{
		public override string GetModel() {
			return "Smart5";
		}
	}


	class Smart6 : Smartphone
	{
		public override string GetModel() {
			return "Smart6";
		}
	}


	abstract class BaseSmartphoneFactory
	{
		public static BaseSmartphoneFactory GetSmartphoneFactory(string location) {
			switch (location.ToLower()) {
				case "singapore":
					return new SingaporeSmartphoneFactory();

				case "new york":
					return new NewYorkSmartphoneFactory();

				default:
					throw new ArgumentException(string.Format("{0} is not a valid location", location), "location");
			}
		}

		public abstract Smartphone CreateSmartphone(string type, string label, double price);
	}


	class SingaporeSmartphoneFactory : BaseSmartphoneFactory
	{
		public override Smartphone CreateSmartphone(string type, string label, double price) {
			Smartphone smartphone;
			switch (type.ToLower()) {
				case "smart4":
					smartphone = new Smart4();
					break;

				case "smart5":
					smartphone = new Smart5();
					break;

				case "smart6":
					throw new ArgumentException(string.Format("Singapore does not produce the {0} smartphone model.", type), "type");

				default:
					throw new ArgumentException(string.Format("{0} is not a valid type of smartphone", type), "type");
			}

			smartphone.Assemble("Singapore");
			smartphone.SetLabel(label);
			smartphone.SetPrice(price);
			return smartphone;
		}
	}


	class NewYorkSmartphoneFactory : BaseSmartphoneFactory
	{
		public override Smartphone CreateSmartphone(string type, string label, double price) {
			Smartphone smartphone;
			switch (type.ToLower()) {
				case "smart4":
					throw new ArgumentException(string.Format("New York does not produce the {0} smartphone model.", type), "type");

				case "smart5":
					smartphone = new Smart5();
					break;

				case "smart6":
					smartphone = new Smart6();
					break;

				default:
					throw new ArgumentException(string.Format("{0} is not a valid type of smartphone", type), "type");
			}

			smartphone.Assemble("New York");
			smartphone.SetLabel(label);
			smartphone.SetPrice(price);
			return smartphone;
		}
	}

}