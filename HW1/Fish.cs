namespace HW1;

public class Fish : IAnimal
{
    public string Name { get; set; } = "Name Unknown";
    public string OwnerName { get; set; } = "Owner name Unknown";
    public ushort Age { get; set; } = 0;

    public Fish()
    {
    }

    public Fish(string name, string ownerName, ushort age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("...");
    }
}