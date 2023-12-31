internal class Program
{
    private static void Main(string[] args)
    {
        Main();

        static void Main()
        {
            FullName nameA = new FullName("i", "wonder");
            FullName nameB = new FullName("john", "smith");
            
            bool compareResult = nameA.Equals(nameB);
            Console.WriteLine(compareResult);

            bool compareResult2 = nameA  == nameB;
            Console.WriteLine(compareResult2);
            
        }
    }
}

class FullName : IEquatable<FullName>
{
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }

    public bool Equals(FullName other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return string.Equals(FirstName, other.FirstName)
            && string.Equals(LastName, other.LastName);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((FullName) obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return ((FirstName != null ? FirstName.GetHashCode() : 0) * 397) 
                ^ (LastName != null ? LastName.GetHashCode() : 0);
        }
    }
}

