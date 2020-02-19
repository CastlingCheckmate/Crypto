using Cryptography.HomeWork4;

using HomeWork4.Enumerations;

namespace HomeWork4.Models
{

    internal struct CipherOperationParameters
    {
        public CipherOperations CipherOperation;
        public string InputFileName;
        public string OutputFileName;
        public RijndaelBlockSizes BlockSize;
        public RijndaelKeySizes KeySize;
        public SymmetricCipherModes CipherMode;
        public byte[] Key;
        public byte[] IV;
        public byte IrreduciblePolynomial;
    }

}