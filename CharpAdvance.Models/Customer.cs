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

    internal void SetName(string name)
    {
        _name = name;
    }

    protected internal void SetNamePI(string name)
    {
        _name = name;
    }
}

public class ProtectedCustomer(string name) : Customer(name)
{
  public void SetNameProtected(string name)
  {
      // Cannot access the SetName method of Customer class as it is private
      // base.SetName(name);
      // Can access the SetNamePI method as it is protected internal
      SetNamePI(name);
      SetName(name); // This will work as SetName is internal in the same assembly
    }
}