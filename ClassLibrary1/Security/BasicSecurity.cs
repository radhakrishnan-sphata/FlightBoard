

using FlightBoard.Core.Services;
using System;
using System.Security.Cryptography;
using System.Text;

namespace FlightBoard.Core.Security
{
    public class BasicSecurity
    {
        public static string key = "fb$123";

        public static string Encrypt(string data)
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(BasicSecurity.key));
                cryptoServiceProvider.Key = hash;
                cryptoServiceProvider.Mode = CipherMode.ECB;
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                return Convert.ToBase64String(cryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
            }
            catch (Exception ex)
            {
                LoggerService.logger.Error(ex);
                throw ex;
            }
        }

        public static string Decrypt(string data)
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(BasicSecurity.key));
                cryptoServiceProvider.Key = hash;
                cryptoServiceProvider.Mode = CipherMode.ECB;
                byte[] inputBuffer = Convert.FromBase64String(data);
                return Encoding.ASCII.GetString(cryptoServiceProvider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            }
            catch (Exception ex)
            {
                LoggerService.logger.Error(ex);
                throw ex;
            }
        }

        public static string GeneratePassword()
        {
            try
            {
                string str1 = "abcdefghijklmnopqrstuvwxyz0123456789#+@&$ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string str2 = "";
                Random random = new Random();
                for (int index = 0; index <= 7; ++index)
                {
                    int startIndex = random.Next(0, str1.Length - 1);
                    str2 += str1.Substring(startIndex, 1);
                }
                return str2;
            }
            catch (Exception ex)
            {
                LoggerService.logger.Error(ex);
                throw ex;
            }
        }
    }
}
