namespace HW2Linq;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
    public double Order { get; set; }
    
    public override string ToString()
    {
        return $"{FirstName} {LastName} - Ordered for ${Order}";
    }
    
}