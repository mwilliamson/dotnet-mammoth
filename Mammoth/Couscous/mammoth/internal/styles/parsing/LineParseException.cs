using Mammoth.Couscous.java.lang;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class LineParseException : RuntimeException {
        internal static LineParseException lineParseException<T>(Token<T> token, string message) {
            return new LineParseException(token.getCharacterIndex(), message);
        }
        
        private readonly int _characterIndex;
        
        internal LineParseException(int characterIndex, string message) : base(message) {
            _characterIndex = characterIndex;
        }
        
        internal int getCharacterIndex() {
            return _characterIndex;
        }
    }
}
