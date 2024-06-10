using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;

namespace Mammoth.Couscous.java.util {
    internal class ArrayList<T> : List<T> {
        private readonly System.Collections.Generic.IList<T> _list;

        internal ArrayList() : this(new System.Collections.Generic.List<T>()) {
        }

        internal ArrayList(System.Collections.Generic.IList<T> list) {
            _list = list;
        }

        internal ArrayList(List<T> list) : this(new System.Collections.Generic.List<T>(FromJava.IterableToEnumerable(list))) {
        }

        public Iterator<T> iterator() {
            return ToJava.EnumeratorToIterator(_list.GetEnumerator());
        }

        public bool isEmpty() {
            return _list.Count == 0;
        }

        public int size() {
            return _list.Count;
        }

        public bool contains(object value) {
            return value is T && _list.Contains((T) value);
        }

        public T get(int index) {
            if (index < 0 || index >= _list.Count) {
                throw new IndexOutOfBoundsException();
            } else {
                return _list[index];
            }
        }

        public List<T> subList(int fromIndex, int toIndex) {
            var list = _list as System.Collections.Generic.List<T>;
            if (list == null) {
                throw new System.NotImplementedException();
            } else {
                return new ArrayList<T>(list.GetRange(fromIndex, toIndex - fromIndex));
            }
        }

        public void add(T value) {
            _list.Add(value);
        }

        public void addAll(List<T> other) {
            var iterator = other.iterator();
            while (iterator.hasNext()) {
                add(iterator.next());
            }
        }

        public T remove(int index) {
            T value = _list[index];
            _list.RemoveAt(index);
            return value;
        }

        public void set(int index, T value) {
            _list[index] = value;
        }

        public void clear() {
            _list.Clear();
        }
    }
}
