using System;
using static System.Console;

public class Point {
	public int X {
		get;
	}
	public int Y {
		get;
	}
	public string Name {
		get;
	}

	public Point(int x, int y, string name) {
		X = x;
		Y = y;
		Name = name;
	}
}

public class Figure {
	readonly Point[] points;
	double perimeter;

	public Figure(Point a, Point b, Point c) {
		points = new[] { a, b, c };
		PerimeterCalculator();
	}
	public Figure(Point a, Point b, Point c, Point d) {
		points = new[] { a, b, c, d };
		PerimeterCalculator();
	}
	public Figure(Point a, Point b, Point c, Point d, Point e) {
		points = new[] { a, b, c, d, e };
		PerimeterCalculator();
	}

	double LengthSide(Point A, Point B) {
		double X_Offset = A.X - B.X;
		double Y_Offset = A.Y - B.Y;
		double Pythagorean = Math.Sqrt((X_Offset * X_Offset) + (Y_Offset * Y_Offset));
		return Pythagorean;
	}
	void PerimeterCalculator() {
		double p = 0;
		for (int i = 1; i < points.Length; i++) {
			p += LengthSide(points[i - 1], points[i]);
		}
		perimeter = p;
	}

	public void ShowNamePerimeter() {
		Write("Назва: ");
		for (int i = 0; i < points.Length; i++) {
			Write(points[i].Name);
		}
		WriteLine();
		WriteLine("Периметр: " + perimeter);
	}
}

partial class Program {
	static void Task4() {
		WriteLine("4.");

		WriteLine("Дано точки A(0,9), B(4,-2), C(-3, -5).");
		Point A = new Point(0, 9, "A");
		Point B = new Point(4, -2, "B");
		Point C = new Point(-3, -5, "C");
		Figure ABC = new Figure(A, B, C);
		WriteLine("Дано трикутник ABC.");
		ABC.ShowNamePerimeter();

		WriteLine();
	}
}
