namespace HW2Linq;

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PublishingYear { get; set; }
    
    public override string ToString()
    {
        return $"{Name} by {Author} - published in {PublishingYear}";
    }
}