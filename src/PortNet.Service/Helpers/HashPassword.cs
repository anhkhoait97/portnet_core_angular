﻿using System.Security.Cryptography;
using System.Text;

namespace PortNet.Service.Helpers
{
    public static class HashPassword
    {
        public static string GetSwcSHA1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }
    }
}