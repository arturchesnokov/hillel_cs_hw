namespace HW1;

public class Parrot : IAnimal
{
    public string Name { get; set; } = "Name Unknown";
    public string OwnerName { get; set; } = "Owner name Unknown";
    public ushort Age { get; set; } = 0;

    public Parrot()
    {
    }

    public Parrot(string name, string ownerName, ushort age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}