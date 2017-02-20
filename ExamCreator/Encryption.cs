using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ExamCreator
{
    class Encryption
    {
        public static string Hash(string text, string hashAlgorithm, byte[] saltBytes)
        {
            //Generates a salt if not specified.
            if (saltBytes == null)
            {
                //Sets the limits for the salt size.
                int minSalt = 4;
                int maxSalt = 8;

                //Randomly generates a number for the size of the salt.
                Random rn = new Random();
                int saltSize = rn.Next(minSalt, maxSalt);

                //Creayes an array that holds the salt.
                saltBytes = new byte[saltSize];

                //Initialises a random number generator.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);//Fill the salt a cryptographically strong byte values.
            }
            //Converts the plain text into a byte array.
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            //Array that holds the plain text and the salt.
            byte[] textAndSalt = new byte[textBytes.Length + saltBytes.Length];

            //Copies the text bytes into the array.
            for (int i = 0; i < textBytes.Length; i++)
            {
                textAndSalt[i] = textBytes[i];
            }

            //Copies the salt bytes into the array.
            for (int i = 0; i < saltBytes.Length; i++)
            {
                textAndSalt[textBytes.Length + i] = saltBytes[i];
            }

            HashAlgorithm hash;
            //Makes sure the hash algorithm is specified.
            if (hashAlgorithm == null)
            {
                hashAlgorithm = "";
            }

            //Initialises the appropiate hashing algorithim class.
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA384":
                    {
                        hash = new SHA384Managed();
                        break;
                    }
                case "SHA512":
                    {
                        hash = new SHA512Managed();
                        break;
                    }
                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            //Compute the hash value of the text with appended salt.
            byte[] hashBytes = hash.ComputeHash(textAndSalt);
            //Creates an array to hold hash and original salt bytes.
            byte[] hashAndSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashAndSaltBytes[i] = hashBytes[i];
            }

            //Appends the salt bytes to the result
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashAndSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            //Convert result into a base4 encoded string.
            string hashValue = Convert.ToBase64String(hashAndSaltBytes);
            return hashValue;//Returns the result.
        }

        public static bool HashVerify(string text, string hashAlgo, string hashVal)
        {
            //Convert base4 encoded value into an array.
            byte[] hashAndSalt = Convert.FromBase64String(hashVal);
            //Determines the size of the hash in bits and bytes.
            int hashSizeBits;
            int hashSizeBytes;

            //Makes sure that the hashing algorithm name is specified.
            if (hashAlgo == null)
            {
                hashAlgo = "";
            }

            //Size of hash is determined based on the specified algorithm.
            switch (hashAlgo.ToUpper())
            {
                case "SHA384":
                    {
                        hashSizeBits = 384;
                        break;
                    }
                case "SHA512":
                    {
                        hashSizeBits = 512;
                        break;
                    }
                default:
                    {
                        hashSizeBits = 128;
                        break;
                    }
            }

            //Converts the size of the hash from bit to bytes.
            hashSizeBytes = hashSizeBits / 8;

            //Makes sure that the specified hash value is long enough.
            if (hashAndSalt.Length < hashSizeBytes)
            {
                return false;
            }

            //Byte array that holds the original salt bytes retrieved from the hash.
            byte[] saltBytes = new byte[hashAndSalt.Length - hashSizeBytes];

            //Copies the salt from the end of the hash to the new array.
            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashAndSalt[hashSizeBytes + i];
            }

            //Creates a new hash string.
            string hashString = Hash(text, hashAlgo, saltBytes);
            //If the new string matches the specified hashString, the the plain text value must be correct.
            return (hashVal == hashString);
        }
    }
}
