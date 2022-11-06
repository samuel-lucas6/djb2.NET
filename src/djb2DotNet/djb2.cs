namespace djb2DotNet;

public static class djb2
{
    public static ulong ComputeHash(ReadOnlySpan<byte> message)
    {
        ulong hash = 5381;
        foreach (byte c in message) {
            hash = (hash << 5) + hash + c;
        }
        return hash;
    }
}