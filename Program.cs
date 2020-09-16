using System;
using static System.Console;

partial class Program {
	static void Task8() {

	}

	static string GetString(string prompt) {
		Write(prompt);
		return ReadLine();
	}
	static double GetDoubleFloat(string prompt) {
		double input;
		do {
			Write(prompt);
		} while (!double.TryParse(ReadLine(), out input));
		return input;
	}
	/*static int GetInt32(string prompt) {
		int input;
		do {
			Write(prompt);
		} while (!int.TryParse(ReadLine(), out input));
		return input;
	}*/
	static uint GetUInt32(string prompt) {
		uint input;
		do {
			Write(prompt);
		} while (!uint.TryParse(ReadLine(), out input));
		return input;
	}
	enum Task { // Внутрішні назви задач.
		Address = 1,
		Rectangle = 2,
		Book = 3,
		Figure = 4,
		User = 5,
		Converter = 6,
		Employee = 7,
		Invoice = 8
	}
	static void Main(string[] args) {
		OutputEncoding = System.Text.Encoding.UTF8;
		InputEncoding = System.Text.Encoding.Unicode;
		Console.Title = "Лабораторна робота 2";

		int TaskNum = 0;
		if (args.Length != 0) {
			int.TryParse(args[0], out TaskNum);
		}
		switch ((Task)TaskNum) {
		case Task.Address:
			Task1();
			break;
		case Task.Rectangle:
			Task2();
			break;
		case Task.Book:
			Task3();
			break;
		case Task.Figure:
			Task4();
			break;
		case Task.User:
			Task5();
			break;
		case Task.Converter:
			Task6();
			break;
		case Task.Employee:
			Task7();
			break;
		case Task.Invoice:
			Task8();
			break;
		default:
			Task1();
			Task2();
			Task3();
			Task4();
			Task5();
			Task6();
			Task7();
			Task8();
			break;
		}

		WriteLine("Роботу програми завершено. Натисніть Enter...");
		while (ReadKey().Key != ConsoleKey.Enter) {
		}
	}
}
