using Mammoth.Couscous.java.lang;

namespace Mammoth.Couscous.java.util {
    internal interface Queue<T> : Iterable<T> {
        void add(T value);
        T remove();
    }
}
