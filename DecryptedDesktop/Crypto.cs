               using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

namespace Crypto
{
    public static class Crypto
    {
        public static string ByteToString(this byte[] AllBytes)
        {
            return Encoding.UTF8.GetString(AllBytes);
        }
        public static byte[] StringToByte(this string Text)
        {
            return Encoding.UTF8.GetBytes(Text);
        }
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
        public static int ToInt32(this string Text)
        {
            try { return int.Parse(Regex.Replace(Text, @"[^\d]", "")); } catch { }
            return 0;
        }
    }
}
