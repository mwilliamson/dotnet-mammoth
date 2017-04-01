using System.Text.RegularExpressions;

namespace Mammoth.Couscous.java.util.regex {
    internal class Matcher {
        private readonly Regex _regex;
        private readonly string _value;
        private int _regionStart = 0;
        private Match _lastMatch = null;
        
        internal Matcher(Regex regex, string value) {
            _regex = regex;
            _value = value;
        }
        
        internal bool lookingAt() {
            var match = _regex.Match(_value, _regionStart);
            if (match.Success && match.Index == _regionStart) {
                _lastMatch = match;
                return true;
            } else {
                return false;
            }
        }
        
        internal bool find() {
            var match = _regex.Match(_value, _regionStart);
            if (match.Success) {
                _lastMatch = match;
                _regionStart = end();
                return true;
            } else {
                return false;
            }
        }
        
        internal string group() {
            return group(0);
        }
        
        internal string group(int groupIndex) {
            return _lastMatch.Groups[groupIndex].Value;
        }
        
        internal int groupCount() {
            return _lastMatch.Groups.Count - 1;
        }
        
        internal int start() {
            return _lastMatch.Index;
        }
        
        internal int end() {
            return _lastMatch.Index + _lastMatch.Length;
        }
        
        internal int regionStart() {
            return _regionStart;
        }
        
        internal void region(int start, int end) {
            if (end == _value.Length) {
                _regionStart = start;
            } else {
                throw new System.NotSupportedException();
            }
        }
    }
}
