using PGPSnippet.Keys;
using PGPSnippet.PGPDecryption;
using PGPSnippet.PGPEncryption;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPSnippet
{
    class Program
    {

        public void KeyGeneration()
        {
            #region PublicKey and Private Key Generation

            PGPSnippet.KeyGeneration.KeysForPGPEncryptionDecryption.GenerateKey("kerrel", "pososi||CYKA", @"Keys\");
            Console.WriteLine("Keys Generated Successfully");

            #endregion
        }

    

        static void Main(string[] args)
        {

            Program objPGP = new Program();

            try
            {

                objPGP.KeyGeneration();
           //     objPGP.Encryption();
               // objPGP.Decryption();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Some thing went wrong\n");
                Console.WriteLine(ex.ToString());
                Console.Read();
            }
        }
    }
}
