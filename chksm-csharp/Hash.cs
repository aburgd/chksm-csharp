using System;
using System.IO;
using System.Security.Cryptography;

namespace chksm_csharp
{
    public static class Hash
    {
        public static byte[] Sha1(string filename)
        {
            byte[] file = File.ReadAllBytes(filename);
            SHA1 hasher = SHA1.Create();
            byte[] sha1Sum = hasher.ComputeHash(file);
            hasher.Clear();
            return sha1Sum;
        }

        public static byte[] Md5(string filename)
        {
            byte[] file = File.ReadAllBytes(filename);
            MD5 hasher = MD5.Create();
            byte[] md5Sum = hasher.ComputeHash(file);
            hasher.Clear();
            return md5Sum;
        }

        public static byte[] Sha256(string filename)
        {
            byte[] file = File.ReadAllBytes(filename);
            SHA256 hasher = SHA256.Create();
            byte[] sha256Sum = hasher.ComputeHash(file);
            hasher.Clear();
            return sha256Sum;
        }

        public static string ToString(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", " "); ;
        }
    }
}
