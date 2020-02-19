using System.IO;

namespace Extensions.BinaryWriterExtensions
{

    public static partial class BinaryWriterExtensions
    {

        public static BinaryWriter FluentDispose(this BinaryWriter binaryWriter)
        {
            binaryWriter.Dispose();
            return binaryWriter;
        }

    }

}