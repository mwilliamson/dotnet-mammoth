using System.Collections.Generic;
using System.Linq;
using Mammoth.Couscous.java.lang;

namespace Mammoth.Couscous.java.util {
    internal abstract class AbstractMap<TKey, TValue> : Map<TKey, TValue> {
        public override bool Equals(object other) {
            var otherMap = other as Map;
            if (otherMap == null) {
                return false;
            } else {
                return Equals(otherMap);
            }
        }

        public bool Equals(Map other) {
            var first = AsUntypedDictionary();
            var second = other.AsUntypedDictionary();
            return
                first.Count == second.Count &&
                first.Keys.Cast<object>().All(key => second.Contains(key) && first[key].Equals(second[key]));
        }

        public override int GetHashCode() {
            throw new System.NotSupportedException();
        }

        public abstract void put(TKey key, TValue value);
        public abstract void putAll(Map<TKey, TValue> other);
        public abstract bool containsKey(TKey key);
        public abstract Set<Map__Entry<TKey, TValue>> entrySet();
        public abstract Collection<TValue> values();

        public abstract Optional<TValue> _lookup(TKey key);
        public abstract System.Collections.Generic.IDictionary<TKey, TValue> AsDictionary();
        public abstract System.Collections.IDictionary AsUntypedDictionary();
    }
}
