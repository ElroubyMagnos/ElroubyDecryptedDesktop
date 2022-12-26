               using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Crypto
{
    public static class Crypto
    {
        public static string GETLine(this string Data, string Line)
        {
            foreach (string Linex in Data.Split('\n'))
            {
                if (Linex.Split('=')[0] == Line)
                    return Linex.Split('=')[1];
            }

            return null;
        }
        public static string EncryptFile(this FileInfo F)
        {
            return File.ReadAllText(F.FullName).Encrypt();
        }
        public static string DecryptFile(this FileInfo F)
        {
            return File.ReadAllText(F.FullName).Decrypt();
        }
        public static string ImageToString(this Image Image)
        {
            return Convert.ToBase64String(Image.ToByteArray());
        }
        public static Image ToImage(this string Data)
        {
            return Image.FromStream(new MemoryStream(Convert.FromBase64String(Data)));
        }
        public static byte[] ToByteArray(this Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        #region Encryption

        static readonly string passPhrase = "rouby";        // can be any string
        static readonly string saltValue = "abedalla";        // can be any string
        static readonly string hashAlgorithm = "MD5";             // can be "MD5"
        static readonly int passwordIterations = 22;                  // can be any number
        static readonly string initVector = "~4B2z3D4e5F6x7H5"; // must be 16 bytes
        static readonly int keySize = 256;                // can be 192 or 128

        public static string Encrypt(this string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            byte[] rgbKey = new PasswordDeriveBytes(passPhrase, rgbSalt, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged managed = new RijndaelManaged
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform transform = managed.CreateEncryptor(rgbKey, bytes);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);
        }

        public static string Decrypt(this string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
            byte[] buffer = Convert.FromBase64String(data);
            byte[] rgbKey = new PasswordDeriveBytes(passPhrase, rgbSalt, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged managed = new RijndaelManaged
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform transform = managed.CreateDecryptor(rgbKey, bytes);
            MemoryStream stream = new MemoryStream(buffer);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer5 = new byte[buffer.Length];
            int count = stream2.Read(buffer5, 0, buffer5.Length);
            stream.Close();
            stream2.Close();
            return Encoding.UTF8.GetString(buffer5, 0, count);
        }
        #endregion
        #region Tenki
        public static string ToTenki(this string Text)
        {
            string Data = "&";
            foreach (char Char in Text) if (Tenki.ContainsKey(Char.ToString())) Data += Tenki[Char.ToString()] + "&";
            return Data;
        }
        public static string FromTenki(this string Text)
        {
            string Data = "";
            foreach (string row in Text.Split('&')) if (Tenki.ContainsValue(row)) Data += Tenki.FirstOrDefault(x => x.Value == row).Key;
            return Data;
        }
        #endregion
        public static int ToInt32(this string Text)
        {
            try { return int.Parse(Regex.Replace(Text, @"[^\d]", "")); } catch { }
            return 0;
        }
        public static readonly Dictionary<string, string> Tenki = new Dictionary<string, string>
        {
                { "1", "~" },
                { "2", "$" },
                { "3", "_" },
                { "4", "=" },
                { "5", "+" },
                { "6", "-" },
                { "7", "%" },
                { "8", "#" },
                { "9", "^" },
                { "0", "/" },
                {"a", "11"},
                {"b", "22"},
                {"c", "33"},
                {"d", "44"},
                {"e", "55"},
                {"f", "66"},
                {"g", "77"},
                {"h", "88"},
                {"i", "99"},
                {"j", "111"},
                {"k", "222"},
                {"l", "333"},
                {"m", "444"},
                {"n", "555"},
                {"o", "666"},
                {"p", "777"},
                {"q", "888"},
                {"r", "999"},
                {"s", "1111"},
                {"t", "2222"},
                {"u", "3333"},
                {"v", "4444"},
                {"w", "5555"},
                {"x", "6666"},
                {"y", "7777"},
                {"z", "8888"},
                {"A", "11c"},
                {"B", "22c"},
                {"C", "33c"},
                {"D", "44c"},
                {"E", "55c"},
                {"F", "66c"},
                {"G", "77c"},
                {"H", "88c"},
                {"I", "99c"},
                {"J", "111c"},
                {"K", "222c"},
                {"L", "333c"},
                {"M", "444c"},
                {"N", "555c"},
                {"O", "666c"},
                {"P", "777c"},
                {"Q", "888c"},
                {"R", "999c"},
                {"S", "1111c"},
                {"T", "2222c"},
                {"U", "3333c"},
                {"V", "4444c"},
                {"W", "5555c"},
                {"X", "6666c"},
                {"Y", "7777c"},
                {"Z", "8888c"}
        };
    }
}
