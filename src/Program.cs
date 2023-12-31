internal class Program
{
    private static void Main(string[] args)
    {
        Main();

        static void Main()
        {
            var fullName = new FullName("smith", "john");
            Console.WriteLine(fullName.LastName);

        }
    }
}

class FullName
{
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }
}

