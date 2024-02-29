using HW4;

var libBooks = new List<Book>()
{
    new Book("The Martian", "Andy Weir", "Science fiction", "Crown Publishing Group"),
    new Book("Ready Player One", "Ernest Cline", "Science fiction", "Crown Publishing Group"),
    new Book("Insurgent", "Veronica Roth", "Fantasy", "Katherine Tegen Books")
};

var bestLibrary = new Library("The Best library", libBooks);
var dune = new Book("Dune", "Frank Herbert", "Science fiction", "Chilton Books");

bestLibrary.AddBook(dune);
bestLibrary.AvailableBooks();
bestLibrary.GiveOutBook("Dune");

bestLibrary.AvailableBooks();
bestLibrary.GivenBooks();

dune.RenamePublisher("Self Published");

bestLibrary.ReturnBook("Dune");

bestLibrary.AvailableBooks();
bestLibrary.GivenBooks();

bestLibrary.FindBookByAuthor("Frank Herbert");
bestLibrary.FindBookByName("Player");
bestLibrary.FindBookByPublisher("Crown");