namespace Extensions;

public static class BlogExtensions
{
    public static string InsertSpaces(this string s)
    {
        return s.ToCharArray().Aggregate("", (current, c) => current + $"{c}_");
    }

    public static string SumWith(this int x, int y)
    {
        return $"Sum of {x} and {y} equals {x + y}";
    }
    public static string GetIntroduction(this Person person)
    {
        return $"EXT -  Hello from: {person.FirstName} {person.LastName}.";
    }
    
    public static string GetIntroductionPublic(this Person person)
    {
        return $"PUBLIC EXT -  Hello from: {person.FirstName} {person.LastName}.";
    }
    
    public static string GetIntroductionPrivate(this Person person)
    {
        return $"PRIVATE EXT -  Hello from: {person.FirstName} {person.LastName}.";
    }

    public static IEnumerable<T> Search<T>(this IEnumerable<T> source, Func<T, bool> isMatch)
    {
        return source.Where(isMatch);
    }
}