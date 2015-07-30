//
//  RsaCryptoSecManager.cs
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
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace LibInCryptoSec2
{
    public class RsaCryptoSecManager
    {
        public RsaCryptoSecManager()
        {
        }

        #region RSA Encriptor and Decriptor

        #region RSA Parameter
        //Initialize the byte arrays to the public key information.
        private static byte[] s_byteRSAParameterModulus = {201,129,171,190,105,5,253,50,50,58,59,10,12,31,27,187,
                                                              41,216,185,121,159,57,189,231,244,75,36,52,100,43,33,
                                                              83,12,102,62,148,108,146,3,31,49,6,40,217,191,77,78,
                                                              46,115,60,35,142,118,16,127,150,213,223,58,212,126,
                                                              176,199,176,227,250,157,179,85,220,181,92,108,36,155,
                                                              187,96,143,123,41,240,136,72,145,173,1,251,49,255,60,
                                                              142,241,152,251,2,91,198,139,52,33,94,111,136,214,
                                                              225,246,27,151,59,211,220,57,95,53,232,43,180,107,90,
                                                              253,37,161,222,222,104,31,98,19};

        private static byte[] s_byteRSAParameterExponent = { 1, 0, 1 };

        //Initialize the byte arrays to the private key information.
        private static byte[] s_byteRSAParameterP = {246,77,170,166,240,61,168,194,122,183,102,100,52,80,235,76,
                                                        180,1,225,177,158,121,174,165,144,135,221,67,148,144,74,
                                                        245,58,226,8,33,5,136,134,136,25,51,215,0,131,47,7,247,129,
                                                        133,28,165,29,51,7,61,57,200,231,163,62,109,128,229};

        private static byte[] s_byteRSAParameterQ = {209,112,134,138,9,0,117,35,205,23,246,71,126,28,62,154,89,
                                                        170,253,233,102,109,147,78,229,255,61,245,59,165,252,184,
                                                        224,212,33,62,181,107,120,129,15,8,125,140,99,155,203,233,
                                                        153,34,90,77,212,69,147,172,193,241,90,74,122,144,63,151};

        private static byte[] s_byteRSAParameterDP = {98,210,160,176,224,93,108,243,178,247,24,239,5,138,158,14,
                                                         37,127,71,197,211,86,241,58,222,181,148,146,131,238,45,
                                                         21,29,174,9,34,238,172,107,133,249,206,177,234,51,184,80,
                                                         18,255,117,160,27,163,142,144,206,0,252,89,236,70,164,250,
                                                         253};

        private static byte[] s_byteRSAParameterDQ = {4,98,114,174,153,25,165,90,38,133,5,230,225,64,254,30,133,
                                                         26,11,78,195,146,47,175,75,41,88,198,181,132,248,17,118,
                                                         195,122,30,177,245,154,4,57,168,87,216,132,141,82,107,133,
                                                         133,46,150,202,134,218,92,151,130,209,253,21,43,199,233};

        private static byte[] s_byteRSAParameterInverseQ = {244,41,102,92,235,94,161,34,154,178,148,192,133,203,
                                                               34,144,59,232,36,53,165,101,172,40,155,203,112,163,
                                                               165,168,133,220,246,191,254,81,167,244,55,108,123,
                                                               235,219,164,8,26,158,241,137,214,49,62,220,178,243,
                                                               177,24,172,45,15,99,116,163,194};

        private static byte[] s_byteRSAParameterD = {104,253,226,97,116,209,69,10,185,118,243,186,25,116,191,251,
                                                        54,35,145,8,88,185,58,68,184,89,202,132,109,200,183,53,81,
                                                        89,152,179,183,26,32,252,72,139,224,15,12,137,23,250,69,
                                                        218,136,224,58,142,0,28,180,84,250,143,43,111,170,171,135,
                                                        183,200,5,232,130,77,130,166,13,176,172,215,219,83,161,217,
                                                        23,223,73,221,111,7,35,147,174,143,156,49,39,167,232,195,0,
                                                        251,248,198,216,160,133,139,134,203,185,139,115,8,97,13,95,
                                                        118,136,207,178,177,247,138,54,254,227,189,44,117,201};
        #endregion

        #region Private Class Functions
        /// <summary>
        /// RSAs the decrypt.
        /// </summary>
        /// <param name="strEncryptedData">The STR encrypted data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The decrypted string data.</returns>
        private static string RsaDecrypt(string strEncryptedData, RSAParameters rsaKeyInfo)
        {
            string strDecryptedData = String.Empty;

            try
            {
                // Input byte array
                byte[] arrRsadata = Convert.FromBase64String(strEncryptedData);

                //Set up the Decryptor object
                //Create a new instance of the RSACryptoServiceProvider class.
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                //Import key parameters into RSA.
                RSA.ImportParameters(rsaKeyInfo);

                // Decript data
                byte[] arrRsaDecryptedData = RSA.Decrypt(arrRsadata, false);

                // Read the Decrypted stream
                strDecryptedData = System.Text.Encoding.UTF8.GetString(arrRsaDecryptedData);

                // Release resources
                RSA.Clear();
            }
            catch (CryptographicException)
            {
                strDecryptedData = String.Empty;
                throw;
            }
            catch (Exception)
            {
                strDecryptedData = String.Empty;
                throw;
            }

            return strDecryptedData;
        }
        /// <summary>
        /// RSAs the decrypt.
        /// </summary>
        /// <param name="arrEncryptedData">The arr encrypted data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The decrypted byte array data.</returns>
        private static byte[] RsaDecrypt(byte[] arrEncryptedData, RSAParameters rsaKeyInfo)
        {
            byte[] arrDecryptedData = new byte[0];

            try
            {
                //Set up the Decryptor object
                //Create a new instance of the RSACryptoServiceProvider class.
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                //Import key parameters into RSA.
                RSA.ImportParameters(rsaKeyInfo);

                // Decript data
                arrDecryptedData = RSA.Decrypt(arrEncryptedData, false);

                // Release resources
                RSA.Clear();
            }
            catch (CryptographicException)
            {
                arrDecryptedData = new byte[0];
                //throw;
            }
            catch (Exception)
            {
                arrDecryptedData = new byte[0];
                //throw;
            }

            return arrDecryptedData;
        }
        /// <summary>
        /// RSAs the encrypt.
        /// </summary>
        /// <param name="strDataToEncrypt">The STR data to encrypt.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The encypted string data.</returns>
        private static string RsaEncrypt(string strDataToEncrypt, RSAParameters rsaKeyInfo)
        {
            string strEncryptedData = String.Empty;

            try
            {
                // Input byte array
                byte[] arrRsaDataToEncrypt = Encoding.UTF8.GetBytes(strDataToEncrypt);

                //Set up the Decryptor object
                //Create a new instance of the RSACryptoServiceProvider class.
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                //Import key parameters into RSA.
                RSA.ImportParameters(rsaKeyInfo);

                // Encrypt data
                byte[] arrRsaEncryptedData = RSA.Encrypt(arrRsaDataToEncrypt, false);

                // Read the Decrypted stream
                strEncryptedData = System.Convert.ToBase64String(arrRsaEncryptedData);

                // Release resources
                RSA.Clear();
            }
            catch (CryptographicException)
            {
                strEncryptedData = "";
                throw;
            }
            catch (Exception)
            {
                strEncryptedData = String.Empty;
                throw;
            }

            return strEncryptedData;
        }
        /// <summary>
        /// RSAs the encrypt.
        /// </summary>
        /// <param name="arrDataToEncrypt">The arr data to encrypt.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The encrypted byte array data.</returns>
        private static byte[] RsaEncrypt(byte[] arrDataToEncrypt, RSAParameters rsaKeyInfo)
        {
            byte[] arrEncryptedData = new byte[0];

            try
            {
                //Set up the Decryptor object
                //Create a new instance of the RSACryptoServiceProvider class.
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                //Import key parameters into RSA.
                RSA.ImportParameters(rsaKeyInfo);

                // Encrypt data
                arrEncryptedData = RSA.Encrypt(arrDataToEncrypt, false);

                // Release resources
                RSA.Clear();
            }
            catch (CryptographicException)
            {
                arrEncryptedData = new byte[0];
                throw;
            }
            catch (Exception)
            {
                arrEncryptedData = new byte[0];
                throw;
            }

            return arrEncryptedData;
        }
        #endregion

        /// <summary>
        /// Gets the RSA parameters.
        /// </summary>
        /// <param name="strContainerName">Name of the STR container.</param>
        /// <returns>RSA KEy parameters.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static RSAParameters GetRsaParameters(string strContainerName)
        {
            RSAParameters rsaKeyInfo;

            try
            {
                // Create the CspParameters object and set the key container 
                // name used to store the RSA key pair.
                CspParameters cp = new CspParameters();
                cp.KeyContainerName = strContainerName;

                // Create a new instance of RSACryptoServiceProvider that accesses
                // the key container MyKeyContainerName.
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

                //Save the public key information to an RSAParameters structure.
                rsaKeyInfo = rsa.ExportParameters(true);
            }
            catch (CryptographicException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return rsaKeyInfo;
        }

        /// <summary>
        /// RSAs the decrypt string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The decrypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "rsa"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static string RsaDecryptString(string strData, RSAParameters rsaKeyInfo)
        {
            return RsaDecrypt(strData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the decrypt string. Use for small string objects.
        /// </summary>
        /// <param name="strData">The ecripted STR data.</param>
        /// <returns>the cecripted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static string RsaDecryptString(string strData)
        {
            //Create a new instance of the RSAParameters structure.
            RSAParameters rsaKeyInfo = new RSAParameters();

            //Set RSAKeyInfo to the public key values. 
            rsaKeyInfo.Modulus = s_byteRSAParameterModulus;
            rsaKeyInfo.Exponent = s_byteRSAParameterExponent;

            //Set RSAKeyInfo to the private key values. 
            rsaKeyInfo.P = s_byteRSAParameterP;
            rsaKeyInfo.Q = s_byteRSAParameterQ;
            rsaKeyInfo.DP = s_byteRSAParameterDP;
            rsaKeyInfo.DQ = s_byteRSAParameterDQ;
            rsaKeyInfo.InverseQ = s_byteRSAParameterInverseQ;
            rsaKeyInfo.D = s_byteRSAParameterD;

            return RsaDecrypt(strData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the decrypt data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The decrypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "rsa"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static byte[] RsaDecryptData(byte[] arrData, RSAParameters rsaKeyInfo)
        {
            return RsaDecrypt(arrData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the decrypt data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static byte[] RsaDecryptData(byte[] arrData)
        {
            //Create a new instance of the RSAParameters structure.
            RSAParameters rsaKeyInfo = new RSAParameters();

            //Set RSAKeyInfo to the public key values. 
            rsaKeyInfo.Modulus = s_byteRSAParameterModulus;
            rsaKeyInfo.Exponent = s_byteRSAParameterExponent;

            //Set RSAKeyInfo to the private key values. 
            rsaKeyInfo.P = s_byteRSAParameterP;
            rsaKeyInfo.Q = s_byteRSAParameterQ;
            rsaKeyInfo.DP = s_byteRSAParameterDP;
            rsaKeyInfo.DQ = s_byteRSAParameterDQ;
            rsaKeyInfo.InverseQ = s_byteRSAParameterInverseQ;
            rsaKeyInfo.D = s_byteRSAParameterD;

            return RsaDecrypt(arrData, rsaKeyInfo);
        }

        /// <summary>
        /// RSAs the encript string.
        /// </summary>
        /// <param name="strData">The STR data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The encrypted string data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "rsa"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static string RsaEncryptString(string strData, RSAParameters rsaKeyInfo)
        {
            return RsaEncrypt(strData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the encript string. Use for small string objects.
        /// </summary>
        /// <param name="strData">The STR data for encription.</param>
        /// <returns>The encripted string.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "str"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static string RsaEncryptString(string strData)
        {
            //Create a new instance of the RSAParameters structure.
            RSAParameters rsaKeyInfo = new RSAParameters();

            //Set RSAKeyInfo to the public key values. 
            rsaKeyInfo.Modulus = s_byteRSAParameterModulus;
            rsaKeyInfo.Exponent = s_byteRSAParameterExponent;

            //Set RSAKeyInfo to the private key values. 
            rsaKeyInfo.P = s_byteRSAParameterP;
            rsaKeyInfo.Q = s_byteRSAParameterQ;
            rsaKeyInfo.DP = s_byteRSAParameterDP;
            rsaKeyInfo.DQ = s_byteRSAParameterDQ;
            rsaKeyInfo.InverseQ = s_byteRSAParameterInverseQ;
            rsaKeyInfo.D = s_byteRSAParameterD;

            return RsaEncrypt(strData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the encript data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <param name="rsaKeyInfo">The RSA key info.</param>
        /// <returns>The encypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "rsa"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static byte[] RsaEncryptData(byte[] arrData, RSAParameters rsaKeyInfo)
        {
            return RsaEncrypt(arrData, rsaKeyInfo);
        }
        /// <summary>
        /// RSAs the encript data.
        /// </summary>
        /// <param name="arrData">The arr data.</param>
        /// <returns>The encypted byte array data.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "arr"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rsa")]
        public static byte[] RsaEncryptData(byte[] arrData)
        {
            //Create a new instance of the RSAParameters structure.
            RSAParameters rsaKeyInfo = new RSAParameters();

            //Set RSAKeyInfo to the public key values. 
            rsaKeyInfo.Modulus = s_byteRSAParameterModulus;
            rsaKeyInfo.Exponent = s_byteRSAParameterExponent;

            //Set RSAKeyInfo to the private key values. 
            rsaKeyInfo.P = s_byteRSAParameterP;
            rsaKeyInfo.Q = s_byteRSAParameterQ;
            rsaKeyInfo.DP = s_byteRSAParameterDP;
            rsaKeyInfo.DQ = s_byteRSAParameterDQ;
            rsaKeyInfo.InverseQ = s_byteRSAParameterInverseQ;
            rsaKeyInfo.D = s_byteRSAParameterD;

            return RsaEncrypt(arrData, rsaKeyInfo);
        }
        #endregion
    }
}

