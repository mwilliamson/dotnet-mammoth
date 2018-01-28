using Mammoth.Couscous.java.lang;

namespace Mammoth.Couscous.java.util {
    interface List<T> : Collection<T> {
        T get(int index);
        List<T> subList(int fromIndex, int toIndex);
        T remove(int index);
        void set(int index, T value);
        void clear();
    }
}
