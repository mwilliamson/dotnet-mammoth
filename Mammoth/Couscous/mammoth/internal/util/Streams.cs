using Mammoth.Couscous.java.io;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Streams {
        internal static string toString(InputStream stream) {
            return new System.IO.StreamReader(stream.Stream, System.Text.Encoding.UTF8).ReadToEnd();
        }
    }
}
