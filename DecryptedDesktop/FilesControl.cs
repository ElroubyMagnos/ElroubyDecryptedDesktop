using Crypto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DecryptedDesktop
{
    public static class FilesControl
    {
        public static bool IsImage(this string Extension)
        {
            return Extension == "jpg" || Extension == "png" || Extension == "bmp"
                || Extension == "gif" || Extension == "tga" || Extension == "pic"
                || Extension == "tiff";
        }
        public static string ReadImageOwner(this string Path)
        {
            string Data = File.ReadAllText(Path).Decrypt();
            return Data.Substring(Data.IndexOf("UN=") + "UN=".Length).Split('\n').First();
        }
        public static string ReadImageOwnerPassword(this string Path)
        {
            string Data = File.ReadAllText(Path).Decrypt();
            return Data.Substring(Data.IndexOf("PSS=") + "PSS=".Length).Split('\n').First();
        }
        public static string EncryptImage(this Image I)
        {
            return ($"UN={Main.User.Username}\nPSS={Main.User.Password}\nData=" + I.ImageToString()).Encrypt();
        }
        public static Image DecryptImage(this string Data)
        {
            string FirstDec = Data.Decrypt();
            string SecondDec = FirstDec.Substring(FirstDec.IndexOf("Data=") + "Data=".Length);

            return SecondDec.ToImage();
        }
        public static string ReadOwner(this string Path)
        {
            string TheString = File.ReadAllText(Path).Decrypt();

            return TheString.Substring(TheString.IndexOf("UN=") + "UN=".Length).Split('\n').First();
        }
        public static string ReadOwnerPassword(this string Path)
        {
            string TheString = File.ReadAllText(Path).Decrypt();

            return TheString.Substring(TheString.IndexOf("PSS=") + "PSS=".Length).Split('\n').First();
        }
        public static string EncFile(this byte[] TheFile)
        {
            return ($"UN={Main.User.Username}\nPSS={Main.User.Password}\nData=" + TheFile.ByteToString().Encrypt()).Encrypt();
        }

        public static byte[] DecFile(this string Data)
        {
            string FirstDec = Data.Decrypt();
            string SecondDec = FirstDec.Substring(FirstDec.IndexOf("Data=") + "Data=".Length);
            byte[] ThirdDec = SecondDec.Decrypt().StringToByte();

            return ThirdDec;
        }
        #region Encryption

        static readonly string passPhrase = Main.User.Username;        // can be any string
        static readonly string saltValue = Main.User.Password;        // can be any string
        static readonly string hashAlgorithm = "MD5";             // can be "MD5"
        static readonly int passwordIterations = 55;                  // can be any number
        static readonly string initVector = "~4B2z3D4e5F6x7H5"; // must be 16 bytes
        static readonly int keySize = 128;                // can be 192 or 128

        public static byte[] EncryptFile(this byte[] buffer)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
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
            return inArray;
        }

        public static byte[] DecryptFile(this byte[] buffer)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(initVector);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(saltValue);
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
            return buffer5;
        }
        #endregion
    }
}
