using Mammoth.Couscous.java.util.function;

namespace Mammoth.Couscous.java.util
{
    internal interface Optional<T>
	{
		bool isPresent();
		Optional<U> map<U>(Function<T, U> function);
		Optional<U> flatMap<U>(Function<T, Optional<U>> function);
		Optional<T> filter(Predicate<T> predicate);
		T orElse(T value);
		T orElseGet(Supplier<T> supplier);
		T orElseThrow<TException>(Supplier<TException> exceptionSupplier) where TException : System.Exception;
		T get();
		void ifPresent(Consumer<T> consumer);
    }
    
    internal interface None {
	}

	internal struct None<T> : None, Optional<T> {
		internal static readonly None<T> Instance = new None<T>();
		
        public override bool Equals(object other) {
			return other is None;
        }
        
        public override int GetHashCode() {
			return 0;
		}
		
		public bool isPresent() {
			return false;
		}

		public Optional<U> map<U>(Function<T, U> function) {
			return new None<U>();
		}

		public Optional<U> flatMap<U>(Function<T, Optional<U>> function) {
			return new None<U>();
		}
		
		public Optional<T> filter(Predicate<T> predicate) {
			return this;
		}

		public T orElse(T value) {
			return value;
		}
		
		public T orElseGet(Supplier<T> supplier) {
			return supplier.get();
		}
		
		public T orElseThrow<TException>(Supplier<TException> exceptionSupplier) where TException : System.Exception {
			throw exceptionSupplier.get();
		}

		public T get() {
			throw new NoSuchElementException();
		}
		
		public void ifPresent(Consumer<T> consumer) {
		}
	}
	
	internal interface Some {
		object getObject();
	}

	internal struct Some<T> : Some, Optional<T> {
		private readonly T _value;

		internal Some(T value) {
			_value = value;
		}
		
        public override bool Equals(object other) {
			var otherSome = other as Some;
			if (otherSome == null) {
				return false;
			} else {
				return _value.Equals(otherSome.getObject());
			}
        }
        
        public override int GetHashCode() {
			return _value.GetHashCode();
		}

		public bool isPresent() {
			return true;
		}

		public Optional<U> map<U>(Function<T, U> function) {
			return new Some<U>(function.apply(_value));
		}

		public Optional<U> flatMap<U>(Function<T, Optional<U>> function) {
			return function.apply(_value);
		}
		
		public Optional<T> filter(Predicate<T> predicate) {
			if (predicate.test(_value)) {
				return this;
			} else {
				return None<T>.Instance;
			}
		}

		public T orElse(T value) {
			return _value;
		}
		
		public T orElseGet(Supplier<T> supplier) {
			return _value;
		}
		
		public T orElseThrow<TException>(Supplier<TException> exceptionSupplier) where TException : System.Exception {
			return _value;
		}

		public T get() {
			return _value;
		}

		public object getObject() {
			return _value;
		}
		
		public void ifPresent(Consumer<T> consumer) {
			consumer.accept(_value);
		}
	}

    internal static class Optional
    {
		internal static Optional<T> empty<T>()
        {
			return None<T>.Instance;
        }
        
        internal static Optional<T> of<T>(T value)
        {
			return new Some<T> (value);
        }
    }
}
