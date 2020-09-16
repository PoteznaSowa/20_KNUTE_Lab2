using System;

public class Converter {
	readonly double USD;
	readonly double EUR;
	readonly double RUB;

	public Converter(double usd, double eur, double rub) {
		USD = usd;
		EUR = eur;
		RUB = rub;
	}

	public double UahToUsd(double uah) => uah / USD;
	public double UahToEur(double uah) => uah / EUR;
	public double UahToRub(double uah) => uah / RUB;

	public double UsdToUah(double usd) => USD * usd;
	public double EurToUah(double eur) => EUR * eur;
	public double RubToUah(double rub) => RUB * rub;
}

partial class Program {
	const double UAH_USD = 27.91;
	const double UAH_EUR = 33.07;
	const double UAH_RUB = .37;

	static void Task6() {
		Console.WriteLine("6.");

		Converter converter = new Converter(UAH_USD, UAH_EUR, UAH_RUB);

		double money = 5000;    // Припустимо, у нас є 5000₴.
		Console.WriteLine("{0}₴ у різних валютах буде:", money);
		Console.WriteLine("{0:F2}$, {1:F2}€, {2:F2}₽", converter.UahToUsd(money), converter.UahToEur(money), converter.UahToRub(money));

		money = 1000;
		Console.WriteLine("{0}$ = {1}₴", money, converter.UsdToUah(money));
		Console.WriteLine("{0}€ = {1}₴", money, converter.EurToUah(money));
		Console.WriteLine("{0}₽ = {1}₴", money, converter.RubToUah(money));

		Console.WriteLine();
	}
}
