using static System.Console;

public class Address {
	// Создать класс с именем Address.
	// В теле класса требуется создать поля: index, country, city, street, house, apartment.
	// Для каждого поля создать свойство с двумя методами доступа.
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

partial class Program {
	static void Task1() {
		WriteLine("1.");

		// Создать экземпляр класса Address.
		// В поля экземпляра записать информацию о почтовом адресе.
		Address address = new Address {
			Index = GetUInt32("Введіть невід'ємне число index: "),
			Country = GetString("Введіть country: "),
			City = GetString("Введіть city: "),
			Street = GetString("Введіть street: ")
		};
		uint house;
		do {
			house = GetUInt32("Введіть додатне число house: ");
		} while (house == 0);
		address.House = house;
		uint flat;
		do {
			flat = GetUInt32("Введіть додатне число apartment: ");
		} while (flat == 0);
		address.Flat = flat;

		// Выведите на экран значения полей, описывающих адрес.
		WriteLine("Тепер екземпляр класу Address має такі дані:");
		address.Show();
	}
}
