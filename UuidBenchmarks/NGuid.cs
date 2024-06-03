namespace UuidBenchmarks;
public readonly struct NGuid 
    : IEquatable<NGuid>, IComparable<NGuid>, IEquatable<Guid>, IComparable<Guid>
{
    private readonly Guid _guid;
    private static NGuid _empty = new(Guid.Empty);

    public static NGuid Empty => _empty;

    public NGuid(Guid guid)
    {
        _guid = guid;
    }
    public static NGuid New7()
    {
        return new(global::NGuid.GuidHelpers.CreateVersion7());
    }

    public static NGuid FromGuid(Guid guid)
    {
        return new(guid);
    }

    public Guid ToGuid()
    {
        return _guid;
    }

    public override string ToString()
    {
        return _guid.ToString();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (obj is NGuid nGuid)
            return Equals(nGuid);
        else if (obj is Guid guid)
            return Equals(guid);
        return false;
    }

    public bool Equals(NGuid other)
    {
        return _guid.Equals(other._guid);
    }

    public bool Equals(Guid other)
    {
        return _guid.Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_guid);
    }

    public int CompareTo(NGuid other)
    {
        return _guid.CompareTo(other._guid);
    }

    public int CompareTo(Guid other)
    {
        return _guid.CompareTo(other);
    }

    public static bool operator ==(NGuid left, NGuid right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(NGuid left, NGuid right)
    {
        return !(left == right);
    }

    public static bool operator ==(NGuid left, Guid right)
    {
        return left.Equals(right);
    }

    public static bool operator ==(Guid left, NGuid right)
    {
        return right.Equals(left);
    }

    public static bool operator !=(NGuid left, Guid right)
    {
        return !(left == right);
    }

    public static bool operator !=(Guid left, NGuid right)
    {
        return !(left == right);
    }

    public static bool operator <(NGuid left, NGuid right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(NGuid left, NGuid right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(NGuid left, NGuid right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(NGuid left, NGuid right)
    {
        return left.CompareTo(right) >= 0;
    }

    public static bool operator <(NGuid left, Guid right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(NGuid left, Guid right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(NGuid left, Guid right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(NGuid left, Guid right)
    {
        return left.CompareTo(right) >= 0;
    }

    public static bool operator <(Guid left, NGuid right)
    {
        return right.CompareTo(left) > 0;
    }

    public static bool operator <=(Guid left, NGuid right)
    {
        return right.CompareTo(left) >= 0;
    }

    public static bool operator >(Guid left, NGuid right)
    {
        return right.CompareTo(left) < 0;
    }

    public static bool operator >=(Guid left, NGuid right)
    {
        return right.CompareTo(left) <= 0;
    }
}
