//
//  DesCryptoSecManager.cs
//
//  Author:
//       Tonči Sviličić <tonci.svilicic@in2.hr>
//
//  Copyright (c) 2012 Tonči Sviličić
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LibInCryptoSec2
{
	public class DesCryptoSecManager
	{
        #region Class Constructor
        private DesCryptoSecManager ()
		{
		}
        #endregion
	
        #region DES3 Encriptor and Decriptor

        #region DES3 Parameter
        private readonly static string s_strDes3IV = @"y+nmm9T9b6M=";
        private readonly static string s_strDes3Key = @"DZutNWp8frfhbNG5wr3p+n+L5oy6nwTr";
		#endregion

        #region Private Class Functions
        /// <summary>
        /// Des3s the decrypt string.
        /// </summary>
        /// <param name="strEncryptedData">The encrypted string data.</param>
        /// <param name="des3CryptServiceProvider">The des3 crypt service provider.</param>
        /// <returns>The decypted string data</returns>
        private static string Des3Decrypt(string strEncryptedData, TripleDESCryptoServiceProvider des3CryptServiceProvider)
        {
            string strDecryptedData = String.Empty;

            try
            {
                byte[] arrDes3Data = Convert.FromBase64String(strEncryptedData);

                using(var strDataReader = new MemoryStream(arrDes3Data.Length))
                using(var cryptoStream = new CryptoStream(strDataReader, des3CryptServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    strDataReader.Write(arrDes3Data, 0, arrDes3Data.Length);
                    strDataReader.Position = 0;

                    strDecryptedData = new StreamReader(cryptoStream).ReadToEnd();

                    strDataReader.Close();
                    cryptoStream.Close();
                }
            }
            catch(Exception)
            {
                strDecryptedData = String.Empty;
                throw;
            }

            return strDecryptedData;
        }
        /// <summary>
        /// DES3 the decrypt byte array.
        /// </summary>
        /// <param name="arrEncryptedData">The arr encrypted data.</param>
        /// <param name="des3CryptServiceProvider">The des3 crypt service provider.</param>
        /// <returns>The decypted byte array data.</returns>
        private static byte[] Des3Decrypt(byte[] arrEncryptedData, TripleDESCryptoServiceProvider des3CryptServiceProvider)
        {
            byte[] arrDecryptedData = new byte[0];

            try
            {
                using(var strDataReader = new MemoryStream(arrEncryptedData.Length))
                using(var cryptoStream = new CryptoStream(strDataReader, des3CryptServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    strDataReader.Write(arrEncryptedData, 0, arrEncryptedData.Length);
                    strDataReader.Position = 0;

                    string strDecryptedData = new StreamReader(cryptoStream).ReadToEnd();
                    arrDecryptedData = ASCIIEncoding.ASCII.GetBytes(strDecryptedData);

                    strDataReader.Close();
                    cryptoStream.Close();
                }
            }
            catch(Exception)
            {
                arrDecryptedData = new byte[0];
                throw;
            }

            return arrDecryptedData;
        }
        /// <summary>
        /// DES3 the encrypt.
        /// </summary>
        /// <param name="strDataToEncrypt">The STR data to encrypt.</param>
        /// <param name="des3CryptServiceProvider">The des3 crypt service provider.</param>
        /// <returns>The encrypted string data.</returns>
        private static string Des3Encrypt(string strDataToEncrypt, TripleDESCryptoServiceProvider des3CryptServiceProvider)
        {
            string strEncryptedData = String.Empty;

            try
            {
                byte[] arrDes3Data = Encoding.UTF8.GetBytes(strDataToEncrypt);

                using(var strDataReader = new MemoryStream(4096))
                using(var cryptoStream = new CryptoStream(strDataReader, des3CryptServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(arrDes3Data, 0, arrDes3Data.Length);
                    cryptoStream.FlushFinalBlock();

                    byte[] bResult = new byte[strDataReader.Position];
                    strDataReader.Position = 0;
                    strDataReader.Read(bResult, 0, bResult.Length);

                    strEncryptedData = Convert.ToBase64String(bResult);

                    strDataReader.Close();
                    cryptoStream.Close();
                }
            }
            catch(Exception)
            {
                strEncryptedData = String.Empty;
                throw;
            }

            return strEncryptedData;
        }
        /// <summary>
        /// DES3 the encrypt.
        /// </summary>
        /// <param name="arrDataToEncrypt">The arr data to encrypt.</param>
        /// <param name="des3CryptServiceProvider">The des3 crypt service provider.</param>
        /// <returns>The encrypted string data.</returns>
        private static byte[] Des3Encrypt(byte[] arrDataToEncrypt, TripleDESCryptoServiceProvider des3CryptServiceProvider)
        {
            byte[] arrEncryptedData = new byte[0];

            try
            {
                using(var strDataReader = new MemoryStream(4096))
                using(var cryptoStream = new CryptoStream(strDataReader, des3CryptServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(arrDataToEncrypt, 0, arrDataToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    arrEncryptedData = new byte[strDataReader.Position];
                    strDataReader.Position = 0;
                    strDataReader.Read(arrEncryptedData, 0, arrEncryptedData.Length);

                    strDataReader.Close();
                    cryptoStream.Close();
                }
            }
            catch(Exception)
            {
                arrEncryptedData = new byte[0];
                throw;
            }

            return arrEncryptedData;
        }
        #endregion

        /// <summary>
        /// DES3 the decrypt string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="strDes3IV">The STR des3 IV.</param>
        /// <param name="strDes3Key">The STR des3 key.</param>
        /// <returns>The DES3 decypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3DecryptData(string strData, string strDes3IV, string strDes3Key)
		{
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = Convert.FromBase64String(strDes3IV),
                Key = Convert.FromBase64String(strDes3Key)
            };

            return Des3Decrypt(strData, des3CryptServiceProvider);
		}
        /// <summary>
        /// DES3 the decrypt string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="arrDes3IV">The arr des3 IV.</param>
        /// <param name="arrDes3Key">The arr des3 key.</param>
        /// <returns>The DES3 decypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3DecryptData(string strData, byte[] arrDes3IV, byte[] arrDes3Key)
        {
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = arrDes3IV,
                Key = arrDes3Key
            };

            return Des3Decrypt(strData, des3CryptServiceProvider);
        }
        /// <summary>
        /// DES3 decrypt data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="strDes3IV">The STR des3 IV.</param>
        /// <param name="strDes3Key">The STR des3 key.</param>
        /// <returns>The decypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static byte[] Des3DecryptData(byte[] arrData, string strDes3IV, string strDes3Key)
        {
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = Convert.FromBase64String(strDes3IV),
                Key = Convert.FromBase64String(strDes3Key)
            };

            return Des3Decrypt(arrData, des3CryptServiceProvider);
        }
        /// <summary>
        /// DES3 decrypt data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="arrDes3IV">The arr des3 IV.</param>
        /// <param name="arrDes3Key">The arr des3 key.</param>
        /// <returns>The decypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr")]
        public static byte[] Des3DecryptData(byte[] arrData, byte[] arrDes3IV, byte[] arrDes3Key)
        {
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = arrDes3IV,
                Key = arrDes3Key
            };

            return Des3Decrypt(arrData, des3CryptServiceProvider);
        }
        /// <summary>
        /// DEs the c3 decrypt string. Use for small string objects.
        /// </summary>
        /// <param name="strData">The encriptes STR data.</param>
        /// <returns>The decripted string.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3DecryptData(string strData)
		{
			return Des3DecryptData(strData, s_strDes3IV, s_strDes3Key);
		}
        /// <summary>
        /// DEs the c3 decrypt data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <returns>The decypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr")]
        public static byte[] Des3DecryptData(byte[] arrData)
		{
			return Des3DecryptData(arrData, s_strDes3IV, s_strDes3Key);
		}

        /// <summary>
        /// DES3 the encript string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="strDes3IV">The STR des3 IV.</param>
        /// <param name="strDes3Key">The STR des3 key.</param>
        /// <returns>The encrypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3EncryptData(string strData, string strDes3IV, string strDes3Key)
		{
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider() 
            {
                IV = Convert.FromBase64String(strDes3IV),
                Key = Convert.FromBase64String(strDes3Key)
            };

            return Des3Encrypt(strData, des3CryptServiceProvider);
		}
        /// <summary>
        /// Des3s the encrypt string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="arrDes3IV">The arr des3 IV.</param>
        /// <param name="arrDes3Key">The arr des3 key.</param>
        /// <returns>The encrypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3EncryptData(string strData, byte[] arrDes3IV, byte[] arrDes3Key)
        {
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = arrDes3IV,
                Key = arrDes3Key
            };

            return Des3Encrypt(strData, des3CryptServiceProvider);
        }
        /// <summary>
        /// DES3 encript data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="strDes3IV">The STR des3 IV.</param>
        /// <param name="strDes3Key">The STR des3 key.</param>
        /// <returns>The encryted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static byte[] Des3EncryptData(byte[] arrData, string strDes3IV, string strDes3Key)
		{
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider() 
            {
                IV = Convert.FromBase64String(strDes3IV),
                Key = Convert.FromBase64String(strDes3Key)
            };

            return Des3Encrypt(arrData, des3CryptServiceProvider);
		}
        /// <summary>
        /// DES3 encript data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="arrDes3IV">The arr des3 IV.</param>
        /// <param name="arrDes3Key">The arr des3 key.</param>
        /// <returns>The encryted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), 
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr")]
        public static byte[] Des3EncryptData(byte[] arrData, byte[] arrDes3IV, byte[] arrDes3Key)
        {
            var des3CryptServiceProvider = new TripleDESCryptoServiceProvider()
            {
                IV = arrDes3IV,
                Key = arrDes3Key
            };

            return Des3Encrypt(arrData, des3CryptServiceProvider);
        }
        /// <summary>
        /// DEs the c3 encript string. Use for small string objects.
        /// </summary>
        /// <param name="strData">The STR data for encription.</param>
        /// <returns>The encripted string.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str")]
        public static string Des3EncryptData(string strData)
        {
            return Des3EncryptData(strData, s_strDes3IV, s_strDes3Key);
        }
        /// <summary>
        /// DEs the c3 encript data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <returns>The encryted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr")]
        public static byte[] Des3EncryptData(byte[] arrData)
		{
			return Des3EncryptData(arrData, s_strDes3IV, s_strDes3Key);
		}
		#endregion	
	}
}

