using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;
using System.Linq;

namespace Mammoth.Couscous {
    internal static class HorribleHacks {
        internal static bool equals(this object first, object second) {
            return first.Equals(second);
        }
        
        internal static string getMessage(this System.Exception exception) {
            return exception.Message;
        }
    }
}
