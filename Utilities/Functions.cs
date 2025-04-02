﻿using System.Security.Cryptography;
using System.Text;

namespace estore.Utilities
{
    public class Functions
    {
        public static int _UserID = 0;
        public static string _UserName = string.Empty;
        public static string _Email = string.Empty;
        public static string _Message = string.Empty;

        public static bool IsLogin()
        {
            if ((Functions._UserID <= 0) || string.IsNullOrEmpty(Functions._UserName) || string.IsNullOrEmpty(Functions._Email))
                    return false;
            return true;
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
                strBuilder.Append(result[i].ToString("x2"));
            return strBuilder.ToString();
        }


        public static string MD5Password(string? text)
        {
            string str = MD5Hash(text);
            for (int i = 0; i<=5; i++)
                str = MD5Hash(str + str);
            return str;
        }
    }
}
