namespace Overloading.Shared;

public class ExampleData : IEquatable<ExampleData>, IComparable<ExampleData>, IComparable
{
    public int CompareTo(ExampleData? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return Value.CompareTo(other.Value);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is ExampleData other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(ExampleData)}");
    }

    public static bool operator <(ExampleData? left, ExampleData? right)
    {
        return Comparer<ExampleData>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(ExampleData? left, ExampleData? right)
    {
        return Comparer<ExampleData>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(ExampleData? left, ExampleData? right)
    {
        return Comparer<ExampleData>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(ExampleData? left, ExampleData? right)
    {
        return Comparer<ExampleData>.Default.Compare(left, right) >= 0;
    }

    public bool Equals(ExampleData? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id && Value == other.Value && Name == other.Name;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ExampleData)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Value, Name);
    }

    public static bool operator ==(ExampleData? left, ExampleData? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ExampleData? left, ExampleData? right)
    {
        return !Equals(left, right);
    }

    public static ExampleData operator +(ExampleData? left, ExampleData? right)
    {
        if (ReferenceEquals(null, left))
            left = new ExampleData();
        if (ReferenceEquals(null, right))
            right = new ExampleData();

        return new ExampleData()
        {
            Id = left.Id,
            Value = left.Value + right.Value,
            Name = left.Name + " " + right.Name
        };
    }
    
    public static int operator -(ExampleData? left, ExampleData? right)
    {
        if (ReferenceEquals(null, left))
            left = new ExampleData();
        if (ReferenceEquals(null, right))
            right = new ExampleData();

        return left.Value - right.Value;
    }

    public static implicit operator int(ExampleData exampleData)
    {
        return exampleData.Value;
    }

    public static explicit operator ExampleData(string name)
    {
        return new()
        {
            Id = -1,
            Value = -1,
            Name = name
        };
    }
    
    public int Id { get; set; }
    public int Value { get; set; }
    public string Name { get; set; }
}