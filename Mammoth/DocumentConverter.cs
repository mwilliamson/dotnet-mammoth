using System;
using System.Collections.Generic;
using System.IO;
using Mammoth.Couscous;
using Mammoth.Couscous.org.zwobble.mammoth.@internal;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;

namespace Mammoth {
    public class DocumentConverter {
        private readonly DocumentToHtmlOptions options;

        public DocumentConverter() : this(DocumentToHtmlOptions._DEFAULT) {
        }

        private DocumentConverter(DocumentToHtmlOptions options) {
            this.options = options;
        }

        public DocumentConverter IdPrefix(string idPrefix) {
            return new DocumentConverter(options.idPrefix(idPrefix));
        }

        public DocumentConverter PreserveEmptyParagraphs() {
            return new DocumentConverter(options.preserveEmptyParagraphs());
        }

        public DocumentConverter AddStyleMap(string styleMap) {
            return new DocumentConverter(options.addStyleMap(styleMap));
        }

        public DocumentConverter DisableDefaultStyleMap() {
            return new DocumentConverter(options.disableDefaultStyleMap());
        }
        
        public DocumentConverter DisableEmbeddedStyleMap() {
            return new DocumentConverter(options.disableEmbeddedStyleMap());
        }
        
        public DocumentConverter ImageConverter(Func<IImage, IDictionary<string, string>> imageConverter) {
            return new DocumentConverter(options.imageConverter(new ImageConverterShim(imageConverter)));
        }
        
        internal class ImageConverterShim : Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement {
            private readonly Func<IImage, IDictionary<string, string>> func;
            
            internal ImageConverterShim(Func<IImage, IDictionary<string, string>> func) {
                this.func = func;
            }
            
            public Mammoth.Couscous.java.util.Map<string, string> convert(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
                return ToJava.DictionaryToMap(func(new Image(image)));
            }
        }
        
        internal class Image : IImage {
            private readonly Mammoth.Couscous.org.zwobble.mammoth.images.Image image;
            
            internal Image(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
                this.image = image;
            }
            
            public string AltText { get { return image.getAltText().orElse(null); } }
            public string ContentType { get { return image.getContentType(); } }
            public Stream GetStream() { return image.getInputStream().Stream; }
        }

        public IResult<string> ConvertToHtml(Stream stream) {
            return new InternalDocumentConverter(options)
                .convertToHtml(ToJava.StreamToInputStream(stream))
                .ToResult();
        }

        public IResult<string> ConvertToHtml(string path) {
            return new InternalDocumentConverter(options)
                .convertToHtml(new Couscous.java.io.File(path))
                .ToResult();
        }

        public IResult<string> ExtractRawText(Stream stream) {
            return new InternalDocumentConverter(options)
                .extractRawText(ToJava.StreamToInputStream(stream))
                .ToResult();
        }

        public IResult<string> ExtractRawText(string path) {
            return new InternalDocumentConverter(options)
                .extractRawText(new Couscous.java.io.File(path))
                .ToResult();
        }
    }
}
