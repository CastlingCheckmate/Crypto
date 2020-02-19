using System.IO;

namespace Extensions.BinaryWriterExtensions
{

    public static partial class BinaryWriterExtensions
    {

        public static BinaryWriter FluentClose(this BinaryWriter binaryWriter)
        {
            binaryWriter.Close();
            return binaryWriter;
        }

    }

}