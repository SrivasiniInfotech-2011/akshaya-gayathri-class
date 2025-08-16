namespace CharpAdvance.Models;

public enum GenderType
{
    Male = 1,
    Female = 2
}

public class Customer(string name)
{
    private string _name = name;

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public int Id { get; set; }
    public string Email { get; init; } = string.Empty;
    public GenderType Gender { get; init; }
    public DateTime? DateOfBirth { get; init; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Email:{Email}, Date Of Birth: {DateOfBirth.GetValueOrDefault().ToString("dd-MM-yyyy")}";
    }
}