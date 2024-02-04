namespace HW2Linq;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateOnly EmploymentDate { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - works from {EmploymentDate}";
    }
}