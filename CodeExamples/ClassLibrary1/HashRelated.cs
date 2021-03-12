using System;
using System.Security.Cryptography;
using System.Text;

public class HashRelated
{
    public static long Md5StringToHash(string value)
    {
        using (var md5 = MD5.Create())
        {
            // Get MD5 hash string
            var bytes = Encoding.UTF8.GetBytes(value);
            var hash = md5.ComputeHash(bytes);
            var hashString = BitConverter.ToString(hash);
            Console.WriteLine(hashString);
            Console.WriteLine();

            // Convert to ULong
            var result = BitConverter.ToUInt64(hash, 0);
            Console.WriteLine(result);
            Console.WriteLine();

            // Convert to value from 0 to 9.  Could be any integer.
            var limited = result % 10;
            Console.WriteLine(limited);
            Console.WriteLine();

            // CODE...
            var a = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
            var b = (long)(BitConverter.ToUInt64(hash, 0) % 10);
            Console.WriteLine(b);
            return b;
        }
    }
}
