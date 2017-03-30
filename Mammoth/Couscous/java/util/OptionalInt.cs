using Mammoth.Couscous.java.util.function;

namespace Mammoth.Couscous.java.util
{
    internal interface OptionalInt
	{
		bool isPresent();
		int getAsInt();
    }

	internal struct NoneInt : OptionalInt {
		internal static readonly NoneInt Instance = new NoneInt();
		
		public bool isPresent() {
			return false;
		}

		public int getAsInt() {
			throw new NoSuchElementException();
		}
	}

	internal struct SomeInt : OptionalInt {
		private readonly int _value;

		internal SomeInt(int value) {
			_value = value;
		}

		public bool isPresent() {
			return true;
		}

		public int getAsInt() {
			return _value;
		}
	}
}
