using System.Collections.Generic;
using System.Linq;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.java.lang;

namespace Mammoth.Couscous.java.util {
    internal class HashMap<TKey, TValue> : AbstractMap<TKey, TValue> {
        private readonly Dictionary<TKey, TValue> _dictionary;
        
        internal HashMap() : this(new Dictionary<TKey, TValue>()) {
        }
        
        internal HashMap(Dictionary<TKey, TValue> dictionary) {
            _dictionary = dictionary;
        }
        
        internal HashMap(Map<TKey, TValue> map) : this(new Dictionary<TKey, TValue>(map.AsDictionary())) {
        }
        
        public override void put(TKey key, TValue value) {
            _dictionary[key] = value;
        }
        
        public override bool containsKey(TKey key) {
            return _dictionary.ContainsKey(key);
        }
        
        public override Set<Map__Entry<TKey, TValue>> entrySet() {
            return new EntrySet(_dictionary);
        }
        
        public override Collection<TValue> values() {
            return ToJava.CollectionToCollection(_dictionary.Values);
        }
        
        public override Optional<TValue> _lookup(TKey key) {
            if (_dictionary.ContainsKey(key)) {
                return new Some<TValue>(_dictionary[key]);
            } else {
                return None<TValue>.Instance;
            }
        }
        
        public override IDictionary<TKey, TValue> AsDictionary() {
            return _dictionary;
        }
        
        public override System.Collections.IDictionary AsUntypedDictionary() {
            return _dictionary;
        }
        
        internal class EntrySet : Set<Map__Entry<TKey, TValue>> {
            private readonly IDictionary<TKey, TValue> _dictionary;
            
            internal EntrySet(IDictionary<TKey, TValue> dictionary) {
                _dictionary = dictionary;
            }
            
            public Iterator<Map__Entry<TKey, TValue>> iterator() {
                return ToJava.EnumeratorToIterator(_dictionary.Select(entry => Maps.entry(entry.Key, entry.Value)).GetEnumerator());
            }
            
            public bool isEmpty() {
                return _dictionary.Count == 0;
            }
            
            public int size() {
                return _dictionary.Count;
            }
            
            public bool contains(object value) {
                return value is TKey && _dictionary.ContainsKey((TKey) value);
            }
            
            public void add(Map__Entry<TKey, TValue> value) {
                throw new UnsupportedOperationException();
            }
        }
    }
}
