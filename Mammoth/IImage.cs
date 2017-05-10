using System.IO;

namespace Mammoth {
    public interface IImage {
        string AltText { get; }
        string ContentType { get; }
        Stream GetStream();
    }
}
