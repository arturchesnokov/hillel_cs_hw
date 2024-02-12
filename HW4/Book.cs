namespace HW4;

public class Book
{
    public string Name { get; private set; }
    public string Author { get; private set; }
    public string Genre { get; private set; }
    public string PublisherName { get; private set; }

    public Book(string name, string author, string genre, string publisherName)
    {
        Name = name;
        Author = author;
        Genre = genre;
        PublisherName = publisherName;
    }

    //move to the separate class?
    public void RenamePublisher(string newPublisherName)
    {
        PublisherName = newPublisherName;
    }

    public override string ToString()
    {
        return $"{Name} by {Author} - published by {PublisherName}";
    }
}