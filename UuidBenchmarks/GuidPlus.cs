using GuidPlus;

namespace UuidBenchmarks;
public readonly struct GuidPlus
{
    private readonly Guid _guid;
    private static GuidPlus _empty = new(Guid.Empty);

    public static GuidPlus Empty => _empty;

    public GuidPlus(Guid guid)
    {
        _guid = guid;
    }
    public static GuidPlus New7()
    {
        return new(Guid7.NewGuid());
    }

    public static GuidPlus FromGuid(Guid guid)
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
}
