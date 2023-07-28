using static System.Console;

public class Address {
	// Create an Address class.
	// Define those fields in the class: index, country, city, street, house, apartment.
	// Create a property with get and set accessors for each field.
	public uint Index {
		get; set;
	}
	public string Country {
		get; set;
	}
	public string City {
		get; set;
	}
	public string Street {
		get; set;
	}
	public uint House {
		get; set;
	}
	public uint Flat {
		get; set;
	}

	public void Show() {
		WriteLine("index: " + Index);
		WriteLine("country: " + Country);
		WriteLine("city: " + City);
		WriteLine("street: " + Street);
		WriteLine("house: " + House);
		WriteLine("apartment: " + Flat);
	}
}
