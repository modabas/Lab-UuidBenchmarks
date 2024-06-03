using UUIDNext;

namespace UuidBenchmarks;
public readonly struct UuidNext 
    : IEquatable<UuidNext>, IComparable<UuidNext>, IEquatable<Guid>, IComparable<Guid>
{
    private readonly Guid _guid;
    private static UuidNext _empty = new(Guid.Empty);

    public static UuidNext Empty => _empty;

    public UuidNext(Guid guid)
    { 
        _guid = guid;
    }
    public static UuidNext New7()
    {
        return new(Uuid.NewDatabaseFriendly(Database.PostgreSql));
    }

    public static UuidNext FromGuid(Guid guid)
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
        if (obj is UuidNext nGuid)
            return Equals(nGuid);
        else if (obj is Guid guid)
            return Equals(guid);
        return false;
    }

    public bool Equals(UuidNext other)
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

    public int CompareTo(UuidNext other)
    {
        return _guid.CompareTo(other._guid);
    }

    public int CompareTo(Guid other)
    {
        return _guid.CompareTo(other);
    }

    public static bool operator ==(UuidNext left, UuidNext right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(UuidNext left, UuidNext right)
    {
        return !(left == right);
    }

    public static bool operator ==(UuidNext left, Guid right)
    {
        return left.Equals(right);
    }

    public static bool operator ==(Guid left, UuidNext right)
    {
        return right.Equals(left);
    }

    public static bool operator !=(UuidNext left, Guid right)
    {
        return !(left == right);
    }

    public static bool operator !=(Guid left, UuidNext right)
    {
        return !(left == right);
    }

    public static bool operator <(UuidNext left, UuidNext right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(UuidNext left, UuidNext right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(UuidNext left, UuidNext right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(UuidNext left, UuidNext right)
    {
        return left.CompareTo(right) >= 0;
    }

    public static bool operator <(UuidNext left, Guid right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(UuidNext left, Guid right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(UuidNext left, Guid right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(UuidNext left, Guid right)
    {
        return left.CompareTo(right) >= 0;
    }

    public static bool operator <(Guid left, UuidNext right)
    {
        return right.CompareTo(left) > 0;
    }

    public static bool operator <=(Guid left, UuidNext right)
    {
        return right.CompareTo(left) >= 0;
    }

    public static bool operator >(Guid left, UuidNext right)
    {
        return right.CompareTo(left) < 0;
    }

    public static bool operator >=(Guid left, UuidNext right)
    {
        return right.CompareTo(left) <= 0;
    }
}
