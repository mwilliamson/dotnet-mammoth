using System.Text.RegularExpressions;

namespace Mammoth.Couscous.java.util.regex {
    internal class Pattern {
        internal static Pattern compile(string pattern) {
            return new Pattern(pattern, new Regex(pattern));
        }
        
        private readonly string _pattern;
        private readonly Regex _regex;
        
        internal Pattern(string pattern, Regex regex) {
            _pattern = pattern;
            _regex = regex;
        }
        
        internal string pattern() {
            return _pattern;
        }
        
        internal Matcher matcher(string value) {
            return new Matcher(_regex, value);
        }
    }
}
