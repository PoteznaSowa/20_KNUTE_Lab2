using static System.Console;

public class Rectangle {
	// Создать класс с именем Rectangle.

	// В теле класса создать два поля, описывающие длины сторон double side1, side2.
	readonly double side1, side2;

	// Создать пользовательский конструктор Rectangle(double side1, double side2),
	// в теле которого поля side1 и side2 инициализируются значениями аргументов.
	public Rectangle(double side1, double side2) {
		this.side1 = side1;
		this.side2 = side2;
		Area = AreaCalculator();
		Perimeter = PerimeterCalculator();
	}

	// Создать два метода, вычисляющие площадь прямоугольника — double AreaCalculator()
	// и периметр прямоугольника — double PerimeterCalculator().
	double AreaCalculator() => side1 * side2;
	double PerimeterCalculator() => 2 * (side1 + side2);

	// Создать два свойства double Area и double Perimeter с одним методом доступа get.
	public double Area {
		get;
	}
	public double Perimeter {
		get;
	}
}

partial class Program {
	static void Task2() {
		WriteLine("2.");

		// Написать программу, которая принимает от пользователя длины двух
		// сторон прямоугольника и выводит на экран периметр и площадь.
		double a, b;
		do {
			a = GetDoubleFloat("Введіть довжину сторони a прямокутника: ");
		} while (a <= 0);
		do {
			b = GetDoubleFloat("Введіть довжину сторони b прямокутника: ");
		} while (b <= 0);
		Rectangle rectangle = new Rectangle(a, b);
		WriteLine("Периметр цього прямокутника: " + rectangle.Perimeter);
		WriteLine("Площа цього прямокутника: " + rectangle.Area);

		WriteLine();
	}
}
