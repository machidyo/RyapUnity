using System;

internal static class ByteArrayConvertEx
{
    public static float[] ToQuaternion(this byte[] byteArray, int offset)
    {
        if (byteArray == null)
        {
            return new[] {1.0F, 0.0F, 0.0F, 0.0F};
        }

        var w = BitConverter.ToSingle(byteArray, offset);
        var x = BitConverter.ToSingle(byteArray, offset + 4);
        var y = BitConverter.ToSingle(byteArray, offset + 8);
        var z = BitConverter.ToSingle(byteArray, offset + 12);
        return new[] {w, x, y, z};
    }
}