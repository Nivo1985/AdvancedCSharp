namespace AnonymousTypes.Utils;

public static class TupleExtensions
{
    public static string ToOneString(this ValueTuple<int,string, string> input)
    {
        return $"ID: {input.Item1.ToString()}, Name: {input.Item2}, Number of Items: {input.Item3}";
    }
}