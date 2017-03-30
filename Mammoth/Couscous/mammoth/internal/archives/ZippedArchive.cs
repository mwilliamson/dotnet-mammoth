using System.IO.Compression;
using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZippedArchive : Archive {
        private readonly ZipArchive _zipFile;
        
        internal ZippedArchive(File file) {
            _zipFile = ZipFile.OpenRead(file.Path);
        }

        internal ZippedArchive(System.IO.Stream stream) {
            _zipFile = new ZipArchive(stream);
        }
        
        public Optional<InputStream> tryGetInputStream(string name) {
            var entry = _zipFile.GetEntry(name);
            if (entry == null) {
                return Optional.empty<InputStream>();
            } else {
                return Optional.of(ToJava.StreamToInputStream(entry.Open()));
            }
        }
        
        public void close() {
            _zipFile.Dispose();
        }
    }
}
