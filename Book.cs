using System;
using static System.Console;

public class Book {
	public Title title;
	public Author author;
	public Content content;

	public Book(string title, string author, string content) {
		this.title = new Title(title);
		this.author = new Author(author);
		this.content = new Content(content);
	}
}
public class Title {
	readonly string value;

	public Title(string value) {
		this.value = value;
	}

	public void Show() {
		Write("Title: ");

		// Вивести на екран назву книги зеленим кольором.
		ForegroundColor = ConsoleColor.Green;
		WriteLine(value);
		ResetColor();
	}
}
public class Author {
	readonly string value;
	public Author(string value) {
		this.value = value;
	}

	public void Show() {
		Write("Author: ");
		ForegroundColor = ConsoleColor.Cyan;
		WriteLine(value);
		ResetColor();
	}
}
public class Content {
	readonly string value;
	public Content(string value) {
		this.value = value;
	}

	public void Show() {
		Write("Content: ");
		ForegroundColor = ConsoleColor.Red;
		WriteLine(value);
		ResetColor();
	}
}

partial class Program {
	static void Task3() {
		WriteLine("3.");

		string title = GetString("Введіть назву книги: ");
		string author = GetString("Вкажіть автора книги: ");
		string content = GetString("Введіть зміст книги: ");
		Book book = new Book(title, author, content);
		book.title.Show();
		book.author.Show();
		book.content.Show();

		WriteLine();
	}
}
