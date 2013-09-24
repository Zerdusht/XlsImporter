using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace XlsImporter
{
    public static class AESEncryption
    {
        /**
            HashAlgorithm can be SHA1 or MD5.
            InitialVector should be a string of 16 ASCII characters.
            KeySize can be 128, 192, or 256.
            The Salt string really acts as a second password.
            PasswordIterations is the number of times the algorithm is run on the text.
         
         Kullanımı :
                string FinalValue=AESEncryption.Encrypt("My Text","My Password","Salt or Password2",
                                      "SHA1",2,"16CHARSLONG12345",256);
         */
        public static string Encrypt(string PlainText, string Password, string Salt, string HashAlgorithm, int PasswordIterations, string InitialVector, int KeySize)
        {
            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
            byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
            byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);
            PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
            byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
            RijndaelManaged SymmetricKey = new RijndaelManaged();
            SymmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform Encryptor = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes);
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] CipherTextBytes = memStream.ToArray();
            memStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(CipherTextBytes);
        }
        public static string Decrypt(string CipherText, string Password, string Salt, string HashAlgorithm, int PasswordIterations, string InitialVector, int KeySize)
        {
            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
            byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
            byte[] CipherTextBytes = Convert.FromBase64String(CipherText);
            PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
            byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
            RijndaelManaged SymmetricKey = new RijndaelManaged();
            SymmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform Decryptor = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes);
            MemoryStream memStream = new MemoryStream(CipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memStream, Decryptor, CryptoStreamMode.Read);
            byte[] PlainTextBytes = new byte[CipherTextBytes.Length];
            int ByteCount = cryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
            memStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(PlainTextBytes, 0, ByteCount);
        }
    }

    public static class BaseEncryption
    {
        public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream memStream = new MemoryStream();
            Rijndael rijNdael = Rijndael.Create();
            rijNdael.Key = Key;
            rijNdael.IV = IV;
            CryptoStream cryptoStream = new CryptoStream(memStream, rijNdael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(clearData, 0, clearData.Length);
            cryptoStream.Close();
            byte[] encryptedData = memStream.ToArray();
            return encryptedData;
        }
        public static string Encrypt(string clearText, string Password)
        {
            //string değeri byte değerine dönüştür
            byte[] clearBytes =
              System.Text.Encoding.Unicode.GetBytes(clearText);
            //Verilen password kullanılarak Key ve IV değerlerinin elde edileceği bir byte dizisi oluştur
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            //Key için 32 byte (the default Rijndael key length is 256bit = 32bytes)
            //IV için 16 byte (the default Rijndael IV length is 128bit = 16bytes)
            byte[] encryptedData = Encrypt(clearBytes,
                     pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(encryptedData);
        }
        public static void Encrypt(string fileIn, 
                string fileOut, string Password) 
        { 
            FileStream fsIn = new FileStream(fileIn, 
                FileMode.Open, FileAccess.Read); 
            FileStream fsOut = new FileStream(fileOut, 
                FileMode.OpenOrCreate, FileAccess.Write); 

            // Then we are going to derive a Key and an IV from the
            // Password and create an algorithm 

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

            Rijndael alg = Rijndael.Create(); 
            alg.Key = pdb.GetBytes(32); 
            alg.IV = pdb.GetBytes(16); 

            CryptoStream cs = new CryptoStream(fsOut, 
                alg.CreateEncryptor(), CryptoStreamMode.Write); 

            int bufferLen = 4096; 
            byte[] buffer = new byte[4096]; 
            int bytesRead; 

            do { 
                bytesRead = fsIn.Read(buffer, 0, bufferLen); 
                // encrypt it 
                cs.Write(buffer, 0, bytesRead); 
            } while(bytesRead != 0); 
            cs.Close(); 
            fsIn.Close();     
        }
        public static byte[] Decrypt(byte[] cipherData,
                                byte[] Key, byte[] IV)
        {
            MemoryStream memStream = new MemoryStream();
            Rijndael rijNdael = Rijndael.Create();
            rijNdael.Key = Key;
            rijNdael.IV = IV;
            CryptoStream cryptoStream = new CryptoStream(memStream, rijNdael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cipherData, 0, cipherData.Length);
            cryptoStream.Close();
            byte[] decryptedData = memStream.ToArray();
            return decryptedData;
        }
        public static string Decrypt(string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
            new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] decryptedData = Decrypt(cipherBytes,
            pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
        public static void Decrypt(string fileIn, 
                string fileOut, string Password) 
        { 
            FileStream fsIn = new FileStream(fileIn,
                        FileMode.Open, FileAccess.Read); 
            FileStream fsOut = new FileStream(fileOut,
                        FileMode.OpenOrCreate, FileAccess.Write); 
      
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 
            Rijndael alg = Rijndael.Create(); 

            alg.Key = pdb.GetBytes(32); 
            alg.IV = pdb.GetBytes(16); 

            CryptoStream cs = new CryptoStream(fsOut, 
                alg.CreateDecryptor(), CryptoStreamMode.Write); 
      
            int bufferLen = 4096; 
            byte[] buffer = new byte[4096]; 
            int bytesRead; 

            do { 
                bytesRead = fsIn.Read(buffer, 0, bufferLen); 
                // Decrypt it 
                cs.Write(buffer, 0, bytesRead); 
            } while(bytesRead != 0); 
            cs.Close(); // this will also close the unrelying fsOut stream 
            fsIn.Close();     
        }
    }
}
