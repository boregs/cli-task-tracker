using System;

// i dont yet understand what this code really does, im only gonna merge branches when i understand 

/* https://nimaara.com/2018/10/10/generating-ids-in-csharp.html */

public class TaskIDGenerator

{
    private const string Encode_32_Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUV";

    private static readonly ThreadLocal<char[]> _charBufferThreadLocal =
        new ThreadLocal<char[]>(() => new char[13]);

    [ThreadStatic]
    private static char[] _charBufferThreadStatic;

    private static readonly ThreadLocal<char[]> _buffer =
    new ThreadLocal<char[]>(() => new char[13]);

    private static string GenerateId(long id)
    {
        char[] buffer = _buffer.Value;

        buffer[0] = Encode_32_Chars[(int)(id >> 60) & 31];
        buffer[1] = Encode_32_Chars[(int)(id >> 55) & 31];
        buffer[2] = Encode_32_Chars[(int)(id >> 50) & 31];
        buffer[3] = Encode_32_Chars[(int)(id >> 45) & 31];
        buffer[4] = Encode_32_Chars[(int)(id >> 40) & 31];
        buffer[5] = Encode_32_Chars[(int)(id >> 35) & 31];
        buffer[6] = Encode_32_Chars[(int)(id >> 30) & 31];
        buffer[7] = Encode_32_Chars[(int)(id >> 25) & 31];
        buffer[8] = Encode_32_Chars[(int)(id >> 20) & 31];
        buffer[9] = Encode_32_Chars[(int)(id >> 15) & 31];
        buffer[10] = Encode_32_Chars[(int)(id >> 10) & 31];
        buffer[11] = Encode_32_Chars[(int)(id >> 5) & 31];
        buffer[12] = Encode_32_Chars[(int)id & 31];

        return new string(buffer, 0, buffer.Length);
    }

}
