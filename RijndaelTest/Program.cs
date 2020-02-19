using System;
using System.Linq;

using Cryptography.HomeWork4;

namespace RijndaelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new byte[16];
            var data = new byte[16];
            var rnd = new Random();
            rnd.NextBytes(key);
            rnd.NextBytes(data);
            var r = new Rijndael(RijndaelBlockSizes.BlockSize128, RijndaelKeySizes.KeySize128, 27, key);
            var encryptedData = r.Encrypt(data);
            var decryptedData = r.Decrypt(encryptedData);
            if (data.SequenceEqual(decryptedData))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Not passed!!11!1");
            }
        }
    }
}