using System.IO;

namespace Extensions.BinaryReaderExtensions
{

    public static partial class BinaryReaderExtensions
    {

        public static BinaryReader FluentDispose(this BinaryReader binaryReader)
        {
            binaryReader.Dispose();
            return binaryReader;
        }

    }

}