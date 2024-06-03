using BenchmarkDotNet.Attributes;
using Medo;

namespace UuidBenchmarks;
[MemoryDiagnoser]
public class UuidBenchmarks
{
    private Guid _guid;
    private Ulid _ulid;
    private Uuid7 _medoUuid;
    private UuidNext _uuidNext;
    private NGuid _nguid;

    [GlobalSetup]
    public void Setup()
    {
        _guid = Guid.NewGuid();
        _ulid = Ulid.NewUlid();
        _medoUuid = Uuid7.NewUuid7();
        _uuidNext = UuidNext.New7();
        _nguid = NGuid.New7();
    }

    [Benchmark]
    public Ulid GenerateUlid()
    {
        return Ulid.NewUlid();
    }

    [Benchmark]
    public Guid UlidToGuid()
    {
        return _ulid.ToGuid();
    }

    [Benchmark]
    public Ulid ParseGuidToUlid()
    {
        return new Ulid(_guid);
    }

    [Benchmark]
    public Uuid7 GenerateMedoUuid()
    {
        return Uuid7.NewUuid7();
    }

    [Benchmark]
    public Guid MedoUuidToGuid()
    {
        return _medoUuid.ToGuid();
    }

    [Benchmark]
    public Uuid7 ParseGuidToMedoUuid()
    {
        return Uuid7.FromGuid(_guid);
    }

    [Benchmark]
    public UuidNext GenerateUuidNext()
    {
        return UuidNext.New7();
    }

    [Benchmark]
    public Guid UuidNextToGuid()
    {
        return _uuidNext.ToGuid();
    }

    [Benchmark]
    public UuidNext ParseGuidToUuidNext()
    {
        return UuidNext.FromGuid(_guid);
    }

    [Benchmark]
    public NGuid GenerateNGuid()
    {
        return NGuid.New7();
    }

    [Benchmark]
    public Guid NGuidToGuid()
    {
        return _nguid.ToGuid();
    }

    [Benchmark]
    public NGuid ParseGuidToNGuid()
    {
        return NGuid.FromGuid(_guid);
    }
}
