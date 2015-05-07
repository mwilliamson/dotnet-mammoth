namespace Mammoth
{
    public class Message
    {
        public static Message Warning(string value)
        {
            return new Message(value);
        }

        private readonly string _value;

        private Message(string value)
        {
            _value = value;
        }

        public string Value { get { return _value; } }
    }
}
