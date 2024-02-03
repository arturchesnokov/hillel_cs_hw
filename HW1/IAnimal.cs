namespace HW1;

public interface IAnimal
{
    string Name { get; set; }
    string OwnerName { get; set; }

    void SayHello()
    {
        Console.WriteLine("I am default implementation");
    }
}