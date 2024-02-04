namespace HW2Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Mark { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - Mark: {Mark}";
    }
}