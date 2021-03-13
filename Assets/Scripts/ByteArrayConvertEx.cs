using System;

internal static class ByteArrayConvertEx
{
    public static uint ToUInt(this byte[] byteArray, int offset)
    {
        if (byteArray == null)
        {
            return 0;
        }

        return BitConverter.ToUInt32(byteArray, offset);
    }

    public static float[] ToVector3(this byte[] byteArray, int offset)
    {
        if (byteArray == null)
        {
            return new float[] {0.0F, 0.0F, 0.0F};
        }

        var x = BitConverter.ToSingle(byteArray, offset);
        var y = BitConverter.ToSingle(byteArray, offset + 4);
        var z = BitConverter.ToSingle(byteArray, offset + 8);
        return new float[] {x, y, z};
    }

    public static float[] ToQuaternion(this byte[] byteArray, int offset)
    {
        if (byteArray == null)
        {
            return new float[] {1.0F, 0.0F, 0.0F, 0.0F};
        }

        var w = BitConverter.ToSingle(byteArray, offset);
        var x = BitConverter.ToSingle(byteArray, offset + 4);
        var y = BitConverter.ToSingle(byteArray, offset + 8);
        var z = BitConverter.ToSingle(byteArray, offset + 12);
        return new float[] {w, x, y, z};
    }
}