using System;
using static System.Console;

public class User {
	public string Login {
		get; set;
	}
	public string Name {
		get; set;
	}
	public string LastName {
		get; set;
	}
	public uint Age {
		get; set;
	}

	public DateTime Date {
		get;
	}

	public User() {
		Date = DateTime.Now; // Дата анкети — поточний системний час.
	}

	public void ShowInfo() {
		WriteLine("Login: " + Login);
		WriteLine("Name: " + Name);
		WriteLine("Last Name: " + LastName);
		WriteLine("Age: " + Age);
		WriteLine("User Entry Date: " + Date.ToString("g"));
	}
}

partial class Program {
	static void Task5() {
		WriteLine("5.");

		User user = new User() {
			Login = "u1",
			Name = "Dave",
			LastName = "Simpkins",
			Age = 20,
		};
		user.ShowInfo();

		WriteLine();
	}
}
