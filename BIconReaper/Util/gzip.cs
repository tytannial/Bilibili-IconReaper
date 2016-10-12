using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace BIconReaper.Util
{
    class gzip
    {
        public static MemoryStream DecompressStream(Stream inputStream)
        {
            var outputStream = new MemoryStream();

            using (var gzip = new GZipStream(inputStream, CompressionMode.Decompress))
            {
                gzip.CopyTo(outputStream);

                gzip.Close();
                inputStream.Close();

                // After writing to the MemoryStream, the position will be the size
                // of the decompressed file, we should reset it back to zero before returning.
                outputStream.Position = 0;
                return outputStream;
            }
        }
    }
}
