using System;

public class Invoice {
	public readonly int account;
	public readonly string customer;
	public readonly string provider;

	public Invoice(int account, string customer, string provider) {
		this.account = account;
		this.customer = customer;
		this.provider = provider;
	}

	public string Article {
		get; set;
	}
	public int Quantity {
		get; set;
	}

	public void ShowValue(uint price) {
		double value = (double)price * Quantity;
		Console.WriteLine("Вартість товару {0} у кількості {1}:", Article, Quantity);
		Console.WriteLine("з ПДВ: {0:F2}", value * 1.2);    // ПДВ: 20%
		Console.WriteLine("без ПДВ: {0:F2}", value / 1.2);
	}
}

partial class Program {
	static void Task8() {
		Console.WriteLine("8.");

		Invoice invoice = new Invoice(0, "Давид Сімпкінс", "Київхліб") {
			Article = "Хліб український",
			Quantity = 5
		};
		invoice.ShowValue(11);

		Console.WriteLine();
	}
}
