using System;

namespace UuidBenchmarks;
public static class UuidNextExtensions
{
    private const long UnixEpochMilliseconds = 62_135_596_800_000;
    private const long TicksPerMillisecond = 10_000;

    //private static byte[] GetBytes(this UuidNext nguid)
    //{
    //    Span<byte> bytes = stackalloc byte[16];
    //    nguid.ToGuid().TryWriteBytes(bytes, bigEndian: true, out var _);

    //    var bytes = nguid.ToGuid().ToByteArray();
    //    if (BitConverter.IsLittleEndian)
    //    {  // little endian pretends the first 8 bytes are int, short, short
    //        (bytes[0], bytes[1], bytes[2], bytes[3]) = (bytes[3], bytes[2], bytes[1], bytes[0]);
    //        (bytes[4], bytes[5]) = (bytes[5], bytes[4]);
    //        (bytes[6], bytes[7]) = (bytes[7], bytes[6]);
    //    }
    //    return bytes;
    //}

    private static bool IsV7Internal(Span<byte> bytes)
    {
        return (bytes[6] & 0xF0) == 0x70;
    }

    public static bool IsV7(this UuidNext nguid)
    {
        //var (isV7, _) = nguid.IsV7Internal();
        Span<byte> bytes = stackalloc byte[16];
        nguid.ToGuid().TryWriteBytes(bytes, bigEndian: true, out var _);
        return IsV7Internal(bytes);
    }

    public static DateTime ToDateTime(this UuidNext nguid)
    {
        Span<byte> bytes = stackalloc byte[16];
        nguid.ToGuid().TryWriteBytes(bytes, bigEndian: true, out var _);
        var isV7 = IsV7Internal(bytes);
        if (!isV7) { throw new InvalidOperationException("UUID is not version 7."); }
        var unixMs = (long)bytes[0] << 40 | (long)bytes[1] << 32 | (long)bytes[2] << 24 | (long)bytes[3] << 16 | (long)bytes[4] << 8 | (long)bytes[5];
        var ticks = (UnixEpochMilliseconds + unixMs) * TicksPerMillisecond;
        return new DateTime(ticks, DateTimeKind.Utc);
    }

    public static DateTimeOffset ToDateTimeOffset(this UuidNext nguid)
    {
        Span<byte> bytes = stackalloc byte[16];
        nguid.ToGuid().TryWriteBytes(bytes, bigEndian: true, out var _);
        var isV7 = IsV7Internal(bytes);
        if (!isV7) { throw new InvalidOperationException("UUID is not version 7."); }
        var unixMs = (long)bytes[0] << 40 | (long)bytes[1] << 32 | (long)bytes[2] << 24 | (long)bytes[3] << 16 | (long)bytes[4] << 8 | (long)bytes[5];
        var ticks = (UnixEpochMilliseconds + unixMs) * TicksPerMillisecond;
        return new DateTimeOffset(ticks, TimeSpan.Zero);
    }
}
