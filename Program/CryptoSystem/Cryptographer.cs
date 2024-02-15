using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_LR2_MODULES
{
    public class Cryptographer
    {
        public Cryptographer()
        {
            
        }

        /// <summary>
        /// Encrypts the specified data
        /// </summary>
        /// <param name="value">data that needs to be encrypted</param>
        /// <returns>encrypted data in string</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string value = "value";
        /// var result = new Cryptographer().Encrypt(value);
        /// </code>
        /// </example>
        public string Encrypt(string value) { throw new NotImplementedException(); }

        /// <summary>
        /// Decrypts the specified data
        /// </summary>
        /// <param name="value">data that needs to be decrypted</param>
        /// <returns>decrypted data in string</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string value = "value";
        /// var result = new Cryptographer().Decrypt(value);
        /// </code>
        /// </example>
        public string Decrypt(string value) { throw new NotImplementedException(); }

        /// <summary>
        /// Encrypts the specified data
        /// </summary>
        /// <param name="value">data that needs to be encrypted</param>
        /// <returns>encrypted data in bytes</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string value = "value";
        /// var result = new Cryptographer().Encrypt(value);
        /// </code>
        /// </example>
        public byte[] Encrypt(byte[] value) { throw new NotImplementedException(); }

        /// <summary>
        /// Decrypts the specified data
        /// </summary>
        /// <param name="value">data that needs to be decrypted</param>
        /// <returns>decrypted data in bytes</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// string value = "value";
        /// var result = new Cryptographer().Decrypt(value);
        /// </code>
        /// </example>
        public byte[] Decrypt(byte[] value) { throw new NotImplementedException(); }

        /// <summary>
        /// Get RSA KEY in string 
        /// </summary>
        /// <returns>rsa key</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var cr = new Cryptographer();
        /// string key = cr.GetRsaKey();
        /// </code>
        /// </example>
        public string GetRsaKey() { throw new NotImplementedException(); }

        /// <summary>
        /// Get Aes IV + KEY 
        /// </summary>
        /// <param name="encoding">specified encoding</param>
        /// <returns>Aes initial vector and key string IV + KEY in specified encoding</returns>
        /// <example>
        /// 
        /// Example of using a function:
        /// 
        /// <code>
        /// var cr = new Cryptographer();
        /// string key = cr.GetAesKey(Encoding.UTF8);
        /// </code>
        /// </example>
        public string GetAesKey(Encoding encoding) { throw new NotImplementedException(); }
    }
}
