using Mammoth.Couscous.java.util;
using System;

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util
{
	internal static class Queues {
		internal static Queue<T> stack<T>()	 {
			return new Stack<T>();
		}
	}
	
	internal class Stack<T> : Queue<T> {
		private readonly System.Collections.Generic.IList<T> _stack = new System.Collections.Generic.List<T>();
		
		public Iterator<T> iterator() {
			return ToJava.EnumeratorToIterator(_stack.GetEnumerator());
		}
		
		public void add(T value) {
			_stack.Add(value);
		}
		
		public T remove() {
			var index = _stack.Count - 1;
			var value = _stack[index];
			_stack.RemoveAt(index);
			return value;
		}
	}
}

