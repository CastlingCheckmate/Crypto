using System.IO;

namespace Extensions.BinaryReaderExtensions
{

    public static partial class BinaryReaderExtensions
    {

        public static BinaryReader FluentClose(this BinaryReader binaryReader)
        {
            binaryReader.Close();
            return binaryReader;
        }

    }

}