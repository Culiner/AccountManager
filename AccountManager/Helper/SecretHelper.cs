using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AccountManager.Helper
{
    public static class SecretHelper
    {
        private const string Vector = "sjr%s$^12da_~";

        /// <summary>  
        /// AES加密  
        /// </summary>  
        /// <param name="data">被加密的明文</param>  
        /// <param name="key">密钥</param>  
        /// <param name="vector">向量</param>  
        /// <returns>密文</returns>  
        public static byte[] AesEncrypt(byte[] data, string key, string vector = Vector)
        {
            var bKey = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bKey.Length)), bKey, bKey.Length);
            var bVector = new byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(vector.PadRight(bVector.Length)), bVector, bVector.Length);
            byte[] cryptograph; // 加密后的密文  
            var aes = Rijndael.Create();
            try
            {
                // 开辟一块内存流  
                using (var memory = new MemoryStream())
                {
                    // 把内存流对象包装成加密流对象  
                    using (var encryptor = new CryptoStream(memory,
                     aes.CreateEncryptor(bKey, bVector),
                     CryptoStreamMode.Write))
                    {
                        // 明文数据写入加密流  
                        encryptor.Write(data, 0, data.Length);
                        encryptor.FlushFinalBlock();

                        cryptograph = memory.ToArray();
                    }
                }
            }
            catch (Exception)
            {
                cryptograph = null;
            }
            return cryptograph;
        }

        /// <summary>  
        /// AES解密  
        /// </summary>  
        /// <param name="data">被解密的密文</param>  
        /// <param name="key">密钥</param>  
        /// <param name="vector">向量</param>  
        /// <returns>明文</returns>  
        public static byte[] AesDecrypt(byte[] data, string key, string vector = Vector)
        {
            var bKey = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bKey.Length)), bKey, bKey.Length);
            var bVector = new byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(vector.PadRight(bVector.Length)), bVector, bVector.Length);

            byte[] original; // 解密后的明文  

            var aes = Rijndael.Create();
            try
            {
                // 开辟一块内存流，存储密文  
                using (var memory = new MemoryStream(data))
                {
                    // 把内存流对象包装成加密流对象  
                    using (var decryptor = new CryptoStream(memory,
                    aes.CreateDecryptor(bKey, bVector),
                    CryptoStreamMode.Read))
                    {
                        // 明文存储区  
                        using (var originalMemory = new MemoryStream())
                        {
                            var buffer = new byte[1024];
                            int readBytes;
                            while ((readBytes = decryptor.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                originalMemory.Write(buffer, 0, readBytes);
                            }

                            original = originalMemory.ToArray();
                        }
                    }
                }
            }
            catch (Exception)
            {
                original = null;
            }
            return original;
        }
    }
}
