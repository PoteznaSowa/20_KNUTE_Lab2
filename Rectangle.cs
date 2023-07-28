using static System.Console;

public class Rectangle {
	// Create a Rectangle class.

	// Create two fields which define dimensions: double side1, side2.
	readonly double side1, side2;

	// Create a custom Rectangle(double side1, double side2) constructor which
	// initialises side1 and side2 fields using arguments.
	public Rectangle(double side1, double side2) {
		this.side1 = side1;
		this.side2 = side2;
		Area = AreaCalculator();
		Perimeter = PerimeterCalculator();
	}

	// Create two methods which calculate the rectangle's area and perimeter:
	// double AreaCalculator(), double PerimeterCalculator()
	double AreaCalculator() => side1 * side2;
	double PerimeterCalculator() => 2 * (side1 + side2);

	// Create two properties, double Area and double Perimeter, with a get accessor.
	public double Area {
		get;
	}
	public double Perimeter {
		get;
	}
}
