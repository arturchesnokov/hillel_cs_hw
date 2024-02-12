using HW4;

var libBooks = new List<Book>()
{
    new Book("Dune", "Frank Herbert", "Science fiction", "Chilton Books"),
    new Book("The Martian", "Andy Weir", "Science fiction", "Crown Publishing Group"),
    new Book("Ready Player One", "Ernest Cline", "Science fiction", "Crown Publishing Group"),
    new Book("Insurgent", "Veronica Roth", "Fantasy", "Katherine Tegen Books")
};

var bestLibrary = new Library("The Best library", libBooks);

Console.WriteLine($"Books of {bestLibrary.Name}:");
bestLibrary.Books.ForEach(Console.WriteLine);

bestLibrary.FindBook("player");

