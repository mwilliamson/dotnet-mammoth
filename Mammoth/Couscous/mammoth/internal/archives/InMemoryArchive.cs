using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using System.IO;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class InMemoryArchive {
        internal static Archive fromStream(InputStream stream) {
            var memoryStream = new MemoryStream();
            stream.Stream.CopyTo(memoryStream);
            return new ZippedArchive(memoryStream);
        }
    }
}
