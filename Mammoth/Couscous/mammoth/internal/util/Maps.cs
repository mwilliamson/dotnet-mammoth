using System.Linq;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util
{
    internal static class Maps
    {
        internal static Map<K, V> map<K, V>() {
            return ToJava.DictionaryToMap(new System.Collections.Generic.Dictionary<K, V>());
        }
        
        internal static Map<K, V> map<K, V>(K key1, V value1) {
            return ToJava.DictionaryToMap(new System.Collections.Generic.Dictionary<K, V> {
                {key1, value1}
            });
        }
        
        internal static Map<K, V> map<K, V>(K key1, V value1, K key2, V value2) {
            return ToJava.DictionaryToMap(new System.Collections.Generic.Dictionary<K, V> {
                {key1, value1},
                {key2, value2}
            });
        }
        
        internal static Map<K, V> map<K, V>(K key1, V value1, K key2, V value2, K key3, V value3) {
            return ToJava.DictionaryToMap(new System.Collections.Generic.Dictionary<K, V> {
                {key1, value1},
                {key2, value2},
                {key3, value3}
            });
        }
        
        internal static Map<K, V> toMap<T, K, V>(Iterable<T> iterable, Function<T, Map__Entry<K, V>> function) {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .Select(function.apply)
                .GroupBy(entry => entry.getKey())
                .ToDictionary(group => group.Key, group => group.First().getValue());
            return ToJava.DictionaryToMap(dictionary);
            
        }
        
        internal static Map<K, T> toMapWithKey<T, K>(Iterable<T> iterable, Function<T, K> function) {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .ToDictionary(function.apply);
            return ToJava.DictionaryToMap(dictionary);
        }

        internal static Map<K, java.util.List<T>> toMultiMapWithKey<T, K>(Iterable<T> iterable, Function<T, K> function) {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .GroupBy(value => function.apply(value))
                .ToDictionary(
                    grouping => grouping.Key,
                    grouping => ToJava.ListToList(grouping.ToList()));
            return ToJava.DictionaryToMap(dictionary);
        }
    
        internal static Map<K, java.util.List<V>> toMultiMap<T, K, V>(Iterable<T> iterable, Function<T, Map__Entry<K, V>> function) {
            var dictionary = FromJava.IterableToEnumerable(iterable)
                .Select(element => function.apply(element))
                .GroupBy(entry => entry.getKey())
                .ToDictionary(
                    grouping => grouping.Key,
                    grouping => ToJava.ListToList(grouping.Select(entry => entry.getValue()).ToList()));
            return ToJava.DictionaryToMap(dictionary);
        }
        
        internal static Optional<V> lookup<K, V>(Map<K, V> map, K key) {
            return map._lookup(key);
        }
        
        internal static Map<K2, V> eagerMapKeys<K1, K2, V>(Map<K1, V> map, Function<K1, K2> function) {
            var dictionary = FromJava.MapToDictionary(map)
                .ToDictionary(
                    entry => function.apply(entry.Key),
                    entry => entry.Value);
            return ToJava.DictionaryToMap(dictionary);
        }
        
        internal static Map<K, V2> eagerMapValues<K, V1, V2>(Map<K, V1> map, Function<V1, V2> function) {
            var dictionary = FromJava.MapToDictionary(map)
                .ToDictionary(
                    entry => entry.Key,
                    entry => function.apply(entry.Value));
            return ToJava.DictionaryToMap(dictionary);
        }
        
        internal static Map__Entry<K, V> entry<K, V>(K key, V value) {
            return new Entry<K, V>(key, value);
        }
        
        private class Entry<K, V> : Map__Entry<K, V> {
            private readonly K _key;
            private readonly V _value;
            
            internal Entry(K key, V value) {
                this._key = key;
                this._value = value;
            }
            
            public K getKey() {
                return _key;
            }
            
            public V getValue() {
                return _value;
            }
            
            public override bool Equals(object otherObj) {
                var other = otherObj as Entry<K, V>;
                if (other == null) {
                    return false;
                } else if (object.ReferenceEquals(this, other)) {
                    return true;
                } else {
                    return _key.Equals(other._key) && _value.Equals(other._value);
                }
            }

            public override int GetHashCode() {
                return _key.GetHashCode() * 17 + _value.GetHashCode();
            }
        }
        
        internal static Builder<K, V> builder<K, V>() {
            return new Builder<K, V>();
        }
        
        internal class Builder<K, V> {
            private readonly System.Collections.Generic.Dictionary<K, V> _values = new System.Collections.Generic.Dictionary<K, V>();
            
            internal Builder<K, V> put(K key, V value) {
                _values[key] = value;
                return this;
            }
            
            internal Map<K, V> build() {
                return ToJava.DictionaryToMap(_values);
            }
        }
        
        internal static Map<K, V> mutableMap<K, V>(K key1, V value1) {
            var map = new HashMap<K, V>();
            map.put(key1, value1);
            return map;
        }
    }
}
