namespace Extensions;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetIntroductionPublic()
    {
        return $"PUBLIC INNER -  Hello from: {FirstName} {LastName}.";
    }
    
    private string GetIntroductionPrivate()
    {
        return $"PRIVATE INNER -  Hello from: {FirstName} {LastName}.";
    }
}