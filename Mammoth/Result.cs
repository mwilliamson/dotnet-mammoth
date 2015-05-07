using System.Collections.Generic;

namespace Mammoth
{
    public class Result<T>
    {
        private readonly T _value;
        private readonly IList<Message> _messages;

        public Result(T value, IList<Message> messages)
        {
            _value = value;
            _messages = messages;
        }

        public T Value { get { return _value; } }
        public IList<Message> Messages { get { return _messages; } }
    }
}
