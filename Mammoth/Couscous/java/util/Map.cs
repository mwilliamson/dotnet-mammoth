namespace Mammoth.Couscous.java.util {
    internal interface Map {
	System.Collections.IDictionary AsUntypedDictionary();
    }
    
    internal interface Map<K, V> : Map {
	void put(K key, V value);
	bool containsKey(K key);
	Set<Map__Entry<K, V>> entrySet();
	Collection<V> values();
	
        Optional<V> _lookup(K key);
	System.Collections.Generic.IDictionary<K, V> AsDictionary();
    }
    
    internal interface Map__Entry<K, V> {
	K getKey();
	V getValue();
    }
}
