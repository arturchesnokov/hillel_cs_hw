namespace HW4;

public class Library
{
    private List<Book> _books;
    private List<Book> _givenOutBooks = new List<Book>();

    public string Name { get; init; }
    public List<Book> Books => _books;


    public Library(string name, List<Book> booksList)
    {
        Name = name;
        _books = booksList;
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void GiveOutBook(string name)
    {
        var book = _books.FirstOrDefault(b => b.Name.ToLower().Contains(name.ToLower()));
        if (book != null)
        {
            _givenOutBooks.Add(book);
            _books.Remove(book);
        }
    }
    
    public void ReturnBook(string name)
    {
        var book = _givenOutBooks.FirstOrDefault(b => b.Name.ToLower().Contains(name.ToLower()));
        if (book != null)
        {
            _books.Add(book);
            _givenOutBooks.Remove(book);
        }
    }

    public void AvailableBooks()
    {
        Console.WriteLine($"\nBooks of {Name}:");
        _books.ForEach(Console.WriteLine);
    }
    
    public void GivenBooks()
    {
        Console.WriteLine($"\nBooks of {Name} in use:");
        _givenOutBooks.ForEach(Console.WriteLine);
    }

    public void FindBookByName(string name)
    {
        var result = new List<Book>();

        result = _books.Where(b => b.Name.ToLower().Contains(name.ToLower())).ToList();

        Console.WriteLine($"\nFound books with '{name}' in name:{result?.Count ?? 0}");
        result?.ForEach(Console.WriteLine);
    }

    public void FindBookByAuthor(string author)
    {
        var result = new List<Book>();

        result = _books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();

        Console.WriteLine($"\nFound books by author '{author}':{result?.Count ?? 0}");
        result?.ForEach(Console.WriteLine);
    }


    public void FindBookByPublisher(string publisher)
    {
        var result = new List<Book>();

        result = _books.Where(b => b.PublisherName.ToLower().Contains(publisher.ToLower())).ToList();

        Console.WriteLine($"\nFound books published by '{publisher}':{result?.Count ?? 0}");
        result?.ForEach(Console.WriteLine);
    }
}