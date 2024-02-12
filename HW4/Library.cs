namespace HW4;

public class Library
{
    private List<Book> _books;

    public string Name { get; init; }
    public List<Book> Books => _books;


    public Library(string name, List<Book> booksList)
    {
        Name = name;
        _books = booksList;
    }

    public void ReceiveBook(Book book)
    {
        _books.Add(book);
    }

    public void GiveOutBook()
    {
    }

    public void FindBook(string keyword)
    {
        var result = new List<Book>();

        result = _books.Where(b => b.Name.ToLower().Contains(keyword.ToLower())).ToList();

        Console.WriteLine($"\nFound books wit keyword '{keyword}':{result?.Count ?? 0}");
        result?.ForEach(Console.WriteLine);
    }
}