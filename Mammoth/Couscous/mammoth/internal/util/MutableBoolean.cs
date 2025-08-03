namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class MutableBoolean {
        private bool value;

        public MutableBoolean(bool initialValue) {
            this.value = initialValue;
        }

        public bool get() {
            return value;
        }

        public void set(bool newValue) {
            this.value = newValue;
        }
    }
}
