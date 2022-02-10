# esercizi-informatica
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sSecretKey = "pippo123";
            string sEnc = EncryptString("pippo123", sSecretKey);
            string sDec = DecryptString(sEnc, sSecretKey);
            Console.ReadKey();
        }
        static string EncryptString(string data, string sKey)
        {
            MemoryStream msOutput = new MemoryStream();

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(msOutput,
               desencrypt,
               CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cryptostream);
            sw.WriteLine(data);
            sw.Close();
            cryptostream.Close();

            Console.WriteLine(Convert.ToBase64String(msOutput.ToArray()));
            return Convert.ToBase64String(msOutput.ToArray());
        }
        static string DecryptString(string data, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream encStream = new CryptoStream(ms, DES.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(encStream);

            string val = sr.ReadLine();

            sr.Close();
            encStream.Close();
            ms.Close();
            Console.WriteLine(val);
            return val;
        }
    }
}

