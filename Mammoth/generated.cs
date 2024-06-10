namespace Mammoth.Couscous.org.zwobble.mammoth {
    internal interface Result<T> {
        T getValue();
        Mammoth.Couscous.java.util.Set<string> getWarnings();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface Image {
        Mammoth.Couscous.java.util.Optional<string> getAltText();
        string getContentType();
        Mammoth.Couscous.java.io.InputStream getInputStream();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal class ImageConverter {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface ImageConverter__ImgElement {
        Mammoth.Couscous.java.util.Map<string, string> convert(Mammoth.Couscous.org.zwobble.mammoth.images.Image image);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _options;
        internal InternalDocumentConverter(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            this._options = options;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_1(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_3(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap> styleMap = (this.readEmbeddedStyleMap(zipFile)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_4());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions conversionOptions = (styleMap.map<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_5(this))).orElse(this._options);
            return ((((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).flatMap<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_6(conversionOptions))).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_7())).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_8())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_9());
        }
        public Mammoth.Couscous.java.util.Optional<string> readEmbeddedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Optional<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_10(zipFile));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_12(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_14(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_15());
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile = new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZippedArchive(file);
            try {
                return function.apply(zipFile);
            } finally {
                zipFile.close();
            }
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile = Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.InMemoryArchive.fromStream(stream);
            try {
                return function.apply(zipFile);
            } finally {
                zipFile.close();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.nio.file.Path>(), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.InputStream _stream;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_1(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._stream = stream;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._stream, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_0(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal Mammoth.Couscous.java.io.File _file;
        internal InternalDocumentConverter__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, Mammoth.Couscous.java.io.File file) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            this._file = file;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.nio.file.Path>((this._file).toPath()), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_3 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.File _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_3(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._file = file;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._file, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_2(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter, this._file));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap apply(string arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parse(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_5 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap arg0) {
            return ((this._this_org__zwobble__mammoth__internal__InternalDocumentConverter)._options).addEmbeddedStyleMap(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _conversionOptions;
        internal InternalDocumentConverter__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions conversionOptions) {
            this._conversionOptions = conversionOptions;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.convertToHtml(nodes, this._conversionOptions);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_7 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_8 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, string> {
        public string apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.write(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_10 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal InternalDocumentConverter__Anonymous_10(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            this._zipFile = zipFile;
        }
        public Mammoth.Couscous.java.util.Optional<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.readStyleMap(this._zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_11 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).extractRawText(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.nio.file.Path>(), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_12 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.InputStream _stream;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_12(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._stream = stream;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._stream, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_11(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal Mammoth.Couscous.java.io.File _file;
        internal InternalDocumentConverter__Anonymous_13(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, Mammoth.Couscous.java.io.File file) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            this._file = file;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).extractRawText(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.nio.file.Path>((this._file).toPath()), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_14 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.File _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter__Anonymous_14(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._file = file;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._file, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_13(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter, this._file));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_15 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText.extractRawText(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface Archive : Mammoth.Couscous.java.io.Closeable {
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.io.InputStream> tryGetInputStream(string name);
        bool exists(string name);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives {
        public static Mammoth.Couscous.java.io.InputStream getInputStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, string name) {
            return (file.tryGetInputStream(name)).orElseThrow<Mammoth.Couscous.java.io.IOException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives__Anonymous_0(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class Archives__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.io.IOException> {
        internal string _name;
        internal Archives__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.io.IOException get() {
            return new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface MutableArchive : Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive {
        void writeEntry(string path, string content);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath splitPath(string path) {
            int index = path.lastIndexOf("/");
            if (index == -1) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath("", path);
            } else {
                string dirname = path.Substring(0, index - 0);
                string basename = path.Substring(index + 1);
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath(dirname, basename);
            }
        }
        public static string joinPath(string[] paths) {
            Mammoth.Couscous.java.util.List<string> nonEmptyPaths = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFilter<string>(Mammoth.Couscous.java.util.Arrays.asList<string>(paths), new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__Anonymous_0());
            Mammoth.Couscous.java.util.List<string> relevantPaths = new Mammoth.Couscous.java.util.ArrayList<string>();
             {
                Mammoth.Couscous.java.util.Iterator<string> _couscous_desugar_foreach_to_for0 = nonEmptyPaths.iterator();
                while (_couscous_desugar_foreach_to_for0.hasNext()) {
                    string path = _couscous_desugar_foreach_to_for0.next();
                    if (path.startsWith("/")) {
                        relevantPaths.clear();
                    }
                    relevantPaths.add(path);
                }
            }
            return java.lang.String.join("/", relevantPaths);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths__SplitPath {
        internal string _dirname;
        internal string _basename;
        internal ZipPaths__SplitPath(string dirname, string basename) {
            this._dirname = dirname;
            this._basename = basename;
        }
        public string getDirname() {
            return this._dirname;
        }
        public string getBasename() {
            return this._basename;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<string> {
        public bool test(string path) {
            return !path.isEmpty();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml {
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter _imageConverter;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> _noteReferences;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment> _referencedComments;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _INITIAL_CONTEXT;
        static DocumentToHtml() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context(false);
        }
        internal DocumentToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._noteReferences = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference>();
            this._referencedComments = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment>();
            this._warnings = new Mammoth.Couscous.java.util.HashSet<string>();
            this._idPrefix = options.idPrefix();
            this._preserveEmptyParagraphs = options.shouldPreserveEmptyParagraphs();
            this._styleMap = options.styleMap();
            this._imageConverter = options.imageConverter();
            this._comments = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment, string>(comments, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_0());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options, document.getComments());
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT), documentConverter._warnings);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> noteReferences) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(noteReferences, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_1(document));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>());
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT), documentConverter._warnings);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> mainBody = this.convertChildrenToHtml(document, context);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.findNotes(document, this._noteReferences);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteNodes = notes.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("ol", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_2(this, context))));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> commentNodes = (this._referencedComments).isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dl", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(this._referencedComments, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_3(this, context))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(mainBody, noteNodes, commentNodes);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string id = this.generateNoteHtmlId(note.getNoteType(), note.getId());
            string referenceId = this.generateNoteRefHtmlId(note.getNoteType(), note.getId());
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteBody = this.convertToHtml(note.getBody(), context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + referenceId), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("li", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", id), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(noteBody, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment referencedComment, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string commentId = (referencedComment._comment).getCommentId();
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> body = this.convertToHtml((referencedComment._comment).getBody(), context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + this.generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dt", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", this.generateReferentHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("Comment " + referencedComment._label))), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dd", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(body, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_4(this, context));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertChildrenToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return this.convertToHtml(element.getChildren(), context);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return element.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context>(this.create_ElementConverterVisitor(), context);
        }
        public string generateNoteHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateReferentHtmlId(this.noteTypeToIdFragment(noteType), noteId);
        }
        public string generateNoteRefHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateReferenceHtmlId(this.noteTypeToIdFragment(noteType), noteId);
        }
        public string generateReferentHtmlId(string referenceType, string referenceId) {
            return this.generateId((referenceType + "-") + referenceId);
        }
        public string generateReferenceHtmlId(string referenceType, string referenceId) {
            return this.generateId((referenceType + "-ref-") + referenceId);
        }
        public string noteTypeToIdFragment(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType) {
            switch (noteType) {
                case Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE:
                    return "footnote";
                case Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE:
                    return "endnote";
                default:
                    throw new Mammoth.Couscous.java.lang.UnsupportedOperationException();
            }
        }
        public string generateId(string bookmarkName) {
            return this._idPrefix + bookmarkName;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor create_ElementConverterVisitor() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__ReferencedComment {
        internal string _label;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment _comment;
        internal DocumentToHtml__ReferencedComment(string label, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment comment) {
            this._label = label;
            this._comment = comment;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Context {
        internal bool _isHeader;
        internal DocumentToHtml__Context(bool isHeader) {
            this._isHeader = isHeader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context isHeader(bool isHeader) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context(isHeader);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__ElementConverterVisitor : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__ElementConverterVisitor(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> children = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_5(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, paragraph, context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getParagraphHtmlPath(paragraph)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_6(paragraph, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(children)).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> nodes = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_7(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, run, context);
            if (run.isSmallCaps()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getSmallCaps()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY)).wrap(nodes);
            }
            if (run.isAllCaps()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getAllCaps()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY)).wrap(nodes);
            }
            if (run.isStrikethrough()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getStrikethrough()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("s"))).wrap(nodes);
            }
            if (run.isUnderline()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getUnderline()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY)).wrap(nodes);
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT) {
                nodes = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("sub")).wrap(nodes);
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT) {
                nodes = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("sup")).wrap(nodes);
            }
            if (run.isItalic()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getItalic()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("em"))).wrap(nodes);
            }
            if (run.isBold()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBold()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("strong"))).wrap(nodes);
            }
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getRunHtmlPath(run)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_8(run, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(nodes)).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            if ((text.getValue()).isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(text.getValue()));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("\t"));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBreakHtmlPath(breakElement)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_9(breakElement));
            return (mapping.wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_10())).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getTableHtmlPath(table)).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("table"));
            return (mapping.wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_11(this, table, context))).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> generateTableChildren(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            int bodyIndex = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.findIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(table.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_12(this))).orElse((table.getChildren()).size());
            if (bodyIndex == 0) {
                return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(table.getChildren(), context.isHeader(false));
            } else {
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> headRows = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(0, bodyIndex), context.isHeader(true));
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> bodyRows = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(bodyIndex, (table.getChildren()).size()), context.isHeader(false));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("thead", headRows), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tbody", bodyRows));
            }
        }
        public bool isHeader(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement child) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow), child)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_13())).orElse(false);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tr", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableRow, context))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string tagName = context._isHeader ? "th" : "td";
            Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
            if (tableCell.getColspan() != 1) {
                attributes.put("colspan", (tableCell.getColspan()).ToString());
            }
            if (tableCell.getRowspan() != 1) {
                attributes.put("rowspan", (tableCell.getRowspan()).ToString());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableCell, context))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.Map<string, string> attributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.mutableMap<string, string>("href", this.generateHref(hyperlink));
            (hyperlink.getTargetFrame()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_14(attributes));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("a", attributes, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(hyperlink, context)));
        }
        public string generateHref(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink) {
            if ((hyperlink.getHref()).isPresent()) {
                return (hyperlink.getHref()).get();
            } else if ((hyperlink.getAnchor()).isPresent()) {
                return "#" + (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId((hyperlink.getAnchor()).get());
            } else {
                return "";
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId(bookmark.getName())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).add(noteReference);
            string noteAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            string noteReferenceAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteRefHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("sup", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + noteAnchor, "id", noteReferenceAnchor), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(("[" + ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).size()) + "]"))))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return (((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getCommentReference()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE)).wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_16(commentReference, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml))).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            try {
                return ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._imageConverter).convert(image);
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add(exception.getMessage());
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment arg0) {
            return arg0.getCommentId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document _document;
        internal DocumentToHtml__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            this._document = document;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference reference) {
            return (((this._document).getNotes()).findNote(reference.getNoteType(), reference.getNoteId())).get();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._context = context;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(note, this._context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._context = context;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment comment) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(comment, this._context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._context = context;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(element, this._context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_5 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._paragraph = paragraph;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> content = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._paragraph, this._context);
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._preserveEmptyParagraphs ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, content) : content;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_6 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._paragraph = paragraph;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._paragraph).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised paragraph style: " + (((this._paragraph).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("p");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_7 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._run = run;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._run, this._context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_8 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_8(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._run = run;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._run).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised run style: " + (((this._run).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_9 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _breakElement;
        internal DocumentToHtml__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            this._breakElement = breakElement;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if ((this._breakElement).getType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("br");
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_10 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_11 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table _table;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _context;
        internal DocumentToHtml__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
            this._table = table;
            this._context = context;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).generateTableChildren(this._table, this._context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_12 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        internal DocumentToHtml__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement child) {
            return !(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml__ElementConverterVisitor).isHeader(child);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow arg0) {
            return arg0.isHeader();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_14 : Mammoth.Couscous.java.util.function.Consumer<string> {
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal DocumentToHtml__Anonymous_14(Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._attributes = attributes;
        }
        public void accept(string targetFrame) {
            (this._attributes).put("target", targetFrame);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_15 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _commentId;
        internal DocumentToHtml__Anonymous_15(string commentId) {
            this._commentId = commentId;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException("Referenced comment could not be found, id: " + this._commentId);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_16 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference _commentReference;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_16(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._commentReference = commentReference;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            string commentId = (this._commentReference).getCommentId();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment comment = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._comments, commentId)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_15(commentId));
            string label = (("[" + (comment.getAuthorInitials()).orElse("")) + (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).size() + 1)) + "]";
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment(label, comment));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferentHtmlId("comment", commentId), "id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(label))));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _DEFAULT;
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _embeddedStyleMap;
        internal bool _disableDefaultStyleMap;
        internal bool _disableEmbeddedStyleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter _imageConverter;
        static DocumentToHtmlOptions() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions("", false, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, false, false, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter.imgElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions__Anonymous_1()));
        }
        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap embeddedStyleMap, bool disableDefaultStyleMap, bool disableEmbeddedStyleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter imageConverter) {
            this._idPrefix = idPrefix;
            this._preserveEmptyParagraphs = preserveEmptyParagraphs;
            this._styleMap = styleMap;
            this._embeddedStyleMap = embeddedStyleMap;
            this._disableDefaultStyleMap = disableDefaultStyleMap;
            this._disableEmbeddedStyleMap = disableEmbeddedStyleMap;
            this._imageConverter = imageConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions idPrefix(string prefix) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(prefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions preserveEmptyParagraphs() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, true, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(string styleMap) {
            return this.addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parse(styleMap));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, (this._styleMap).update(styleMap), this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions disableDefaultStyleMap() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, true, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions disableEmbeddedStyleMap() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, true, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addEmbeddedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap embeddedStyleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions imageConverter(Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter.imgElement(imageConverter));
        }
        public string idPrefix() {
            return this._idPrefix;
        }
        public bool shouldPreserveEmptyParagraphs() {
            return this._preserveEmptyParagraphs;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY;
            if (!this._disableDefaultStyleMap) {
                styleMap = styleMap.update(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP);
            }
            if (!this._disableEmbeddedStyleMap) {
                styleMap = styleMap.update(this._embeddedStyleMap);
            }
            styleMap = styleMap.update(this._styleMap);
            return styleMap;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter imageConverter() {
            return this._imageConverter;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.images.Image _image;
        internal DocumentToHtmlOptions__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
            this._image = image;
        }
        public Mammoth.Couscous.java.io.InputStream get() {
            return (this._image).getInputStream();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement {
        public Mammoth.Couscous.java.util.Map<string, string> convert(Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
            string base64 = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Base64Encoding.streamToBase64(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions__Anonymous_0(image));
            string src = (("data:" + image.getContentType()) + ";base64,") + base64;
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("src", src);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter {
        internal Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement _imgElement;
        internal InternalImageConverter(Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imgElement) {
            this._imgElement = imgElement;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter imgElement(Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imgElement) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter(imgElement);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convert(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image internalImage) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter__Anonymous_4(internalImage, this));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter__Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.images.Image {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _internalImage;
        internal string _contentType;
        internal InternalImageConverter__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image internalImage, string contentType) {
            this._internalImage = internalImage;
            this._contentType = contentType;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAltText() {
            return (this._internalImage).getAltText();
        }
        public string getContentType() {
            return this._contentType;
        }
        public Mammoth.Couscous.java.io.InputStream getInputStream() {
            return (this._internalImage).open();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter__Anonymous_1 : Mammoth.Couscous.java.util.function.Consumer<string> {
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal InternalImageConverter__Anonymous_1(Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._attributes = attributes;
        }
        public void accept(string altText) {
            (this._attributes).put("alt", altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter__Anonymous_2 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Map<string, string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter _this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
        internal Mammoth.Couscous.org.zwobble.mammoth.images.Image _image;
        internal InternalImageConverter__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter this_org__zwobble__mammoth__internal__conversion__InternalImageConverter, Mammoth.Couscous.org.zwobble.mammoth.images.Image image) {
            this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter = this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
            this._image = image;
        }
        public Mammoth.Couscous.java.util.Map<string, string> get() {
            return ((this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter)._imgElement).convert(this._image);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _internalImage;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter _this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
        internal InternalImageConverter__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image internalImage, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter this_org__zwobble__mammoth__internal__conversion__InternalImageConverter) {
            this._internalImage = internalImage;
            this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter = this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(string contentType) {
            Mammoth.Couscous.org.zwobble.mammoth.images.Image image = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter__Anonymous_0(this._internalImage, contentType);
            Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
            ((this._internalImage).getAltText()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter__Anonymous_1(attributes));
            attributes.putAll(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Map<string, string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter__Anonymous_2(this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter, image)));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("img", attributes));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class InternalImageConverter__Anonymous_4 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _internalImage;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter _this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
        internal InternalImageConverter__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image internalImage, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter this_org__zwobble__mammoth__internal__conversion__InternalImageConverter) {
            this._internalImage = internalImage;
            this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter = this_org__zwobble__mammoth__internal__conversion__InternalImageConverter;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (((this._internalImage).getContentType()).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.InternalImageConverter__Anonymous_3(this._internalImage, this._this_org__zwobble__mammoth__internal__conversion__InternalImageConverter))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class RawText {
        public static string extractRawText(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText.extractRawTextOfChildren(document);
        }
        public static string extractRawTextOfChildren(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren parent) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText.extractRawText(parent.getChildren());
        }
        public static string extractRawText(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> nodes) {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText__Anonymous_0()));
        }
        public static string extractRawText(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            if (node is Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text) {
                return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text) node).getValue();
            } else if (node is Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab) {
                return "\t";
            } else {
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren), node)).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText__Anonymous_1())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
                string suffix = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph), node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText__Anonymous_2())).orElse("");
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText.extractRawText(children) + suffix;
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class RawText__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.RawText.extractRawText(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class RawText__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren arg0) {
            return arg0.getChildren();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class RawText__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return "\n\n";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _name;
        internal Bookmark(string name) {
            this._name = name;
        }
        public string getName() {
            return this._name;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Break : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _LINE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _PAGE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _COLUMN_BREAK;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type _type;
        static Break() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._LINE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._PAGE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._PAGE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._COLUMN_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._COLUMN);
        }
        internal Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type type) {
            this._type = type;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type getType() {
            return this._type;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal enum Break__Type {
        _LINE, _PAGE, _COLUMN
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment {
        internal string _commentId;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _body;
        internal Mammoth.Couscous.java.util.Optional<string> _authorName;
        internal Mammoth.Couscous.java.util.Optional<string> _authorInitials;
        internal Comment(string commentId, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> body, Mammoth.Couscous.java.util.Optional<string> authorName, Mammoth.Couscous.java.util.Optional<string> authorInitials) {
            this._commentId = commentId;
            this._body = body;
            this._authorName = authorName;
            this._authorInitials = authorInitials;
        }
        public string getCommentId() {
            return this._commentId;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getBody() {
            return this._body;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAuthorInitials() {
            return this._authorInitials;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAuthorName() {
            return this._authorName;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class CommentReference : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _commentId;
        internal CommentReference(string commentId) {
            this._commentId = commentId;
        }
        public string getCommentId() {
            return this._commentId;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Document : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal Document(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._children = children;
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes getNotes() {
            return this._notes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> getComments() {
            return this._comments;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElement {
        T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElementVisitor<T, U> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break lineBreak, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, U context);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Documents {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface HasChildren {
        Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Hyperlink : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<string> _href;
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Hyperlink(Mammoth.Couscous.java.util.Optional<string> href, Mammoth.Couscous.java.util.Optional<string> anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._href = href;
            this._anchor = anchor;
            this._targetFrame = targetFrame;
            this._children = children;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink href(string href, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.of<string>(href), Mammoth.Couscous.java.util.Optional.empty<string>(), targetFrame, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink anchor(string anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<string>(anchor), targetFrame, children);
        }
        public Mammoth.Couscous.java.util.Optional<string> getHref() {
            return this._href;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAnchor() {
            return this._anchor;
        }
        public Mammoth.Couscous.java.util.Optional<string> getTargetFrame() {
            return this._targetFrame;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Image : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal Mammoth.Couscous.java.util.Optional<string> _contentType;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier _open;
        internal Image(Mammoth.Couscous.java.util.Optional<string> altText, Mammoth.Couscous.java.util.Optional<string> contentType, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier open) {
            this._altText = altText;
            this._contentType = contentType;
            this._open = open;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAltText() {
            return this._altText;
        }
        public Mammoth.Couscous.java.util.Optional<string> getContentType() {
            return this._contentType;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return (this._open).open();
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Note {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal string _id;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _body;
        internal Note(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string id, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> body) {
            this._noteType = noteType;
            this._id = id;
            this._body = body;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType getNoteType() {
            return this._noteType;
        }
        public string getId() {
            return this._id;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getBody() {
            return this._body;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NoteReference : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal string _noteId;
        internal NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            this._noteType = noteType;
            this._noteId = noteId;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference footnoteReference(string noteId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE, noteId);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference endnoteReference(string noteId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE, noteId);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType getNoteType() {
            return this._noteType;
        }
        public string getNoteId() {
            return this._noteId;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal enum NoteType {
        _FOOTNOTE, _ENDNOTE
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _EMPTY;
        internal Mammoth.Couscous.java.util.Map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> _notes;
        static Notes() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>());
        }
        internal Notes(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes) {
            this._notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapValues<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMultiMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_0()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_2());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNote(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(this._notes, noteType)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_3(noteId));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return arg0.getNoteType();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return arg0.getId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, string>(notesOfType, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes__Anonymous_1());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal string _noteId;
        internal Notes__Anonymous_3(string noteId) {
            this._noteId = noteId;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(notesOfType, this._noteId);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingLevel {
        internal string _levelIndex;
        internal bool _isOrdered;
        internal NumberingLevel(string levelIndex, bool isOrdered) {
            this._levelIndex = levelIndex;
            this._isOrdered = isOrdered;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel ordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, true);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel unordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, false);
        }
        public string getLevelIndex() {
            return this._levelIndex;
        }
        public bool isOrdered() {
            return this._isOrdered;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingStyle {
        internal Mammoth.Couscous.java.util.Optional<string> _numId;
        internal NumberingStyle(Mammoth.Couscous.java.util.Optional<string> numId) {
            this._numId = numId;
        }
        public Mammoth.Couscous.java.util.Optional<string> getNumId() {
            return this._numId;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Paragraph : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent _indent;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Paragraph(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._style = style;
            this._numbering = numbering;
            this._indent = indent;
            this._children = children;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> getNumbering() {
            return this._numbering;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent getIndent() {
            return this._indent;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent {
        internal Mammoth.Couscous.java.util.Optional<string> _start;
        internal Mammoth.Couscous.java.util.Optional<string> _end;
        internal Mammoth.Couscous.java.util.Optional<string> _firstLine;
        internal Mammoth.Couscous.java.util.Optional<string> _hanging;
        internal ParagraphIndent(Mammoth.Couscous.java.util.Optional<string> start, Mammoth.Couscous.java.util.Optional<string> end, Mammoth.Couscous.java.util.Optional<string> firstLine, Mammoth.Couscous.java.util.Optional<string> hanging) {
            this._start = start;
            this._end = end;
            this._firstLine = firstLine;
            this._hanging = hanging;
        }
        public Mammoth.Couscous.java.util.Optional<string> getStart() {
            return this._start;
        }
        public Mammoth.Couscous.java.util.Optional<string> getEnd() {
            return this._end;
        }
        public Mammoth.Couscous.java.util.Optional<string> getFirstLine() {
            return this._firstLine;
        }
        public Mammoth.Couscous.java.util.Optional<string> getHanging() {
            return this._hanging;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal bool _isBold;
        internal bool _isItalic;
        internal bool _isUnderline;
        internal bool _isStrikethrough;
        internal bool _isAllCaps;
        internal bool _isSmallCaps;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment _verticalAlignment;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, bool isAllCaps, bool isSmallCaps, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment verticalAlignment, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._isBold = isBold;
            this._isItalic = isItalic;
            this._isUnderline = isUnderline;
            this._isStrikethrough = isStrikethrough;
            this._isAllCaps = isAllCaps;
            this._isSmallCaps = isSmallCaps;
            this._verticalAlignment = verticalAlignment;
            this._style = style;
            this._children = children;
        }
        public bool isBold() {
            return this._isBold;
        }
        public bool isItalic() {
            return this._isItalic;
        }
        public bool isUnderline() {
            return this._isUnderline;
        }
        public bool isStrikethrough() {
            return this._isStrikethrough;
        }
        public bool isAllCaps() {
            return this._isAllCaps;
        }
        public bool isSmallCaps() {
            return this._isSmallCaps;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment getVerticalAlignment() {
            return this._verticalAlignment;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style {
        internal string _styleId;
        internal Mammoth.Couscous.java.util.Optional<string> _name;
        internal Style(string styleId, Mammoth.Couscous.java.util.Optional<string> name) {
            this._styleId = styleId;
            this._name = name;
        }
        public string getStyleId() {
            return this._styleId;
        }
        public Mammoth.Couscous.java.util.Optional<string> getName() {
            return this._name;
        }
        public string describe() {
            string styleIdDescription = "Style ID: " + this._styleId;
            return ((this._name).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style__Anonymous_0(styleIdDescription))).orElse(styleIdDescription);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _styleIdDescription;
        internal Style__Anonymous_0(string styleIdDescription) {
            this._styleIdDescription = styleIdDescription;
        }
        public string apply(string name) {
            return ((name + " (") + this._styleIdDescription) + ")";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Tab : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab _TAB;
        static Tab() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab._TAB = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab();
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Table : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Table(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._style = style;
            this._children = children;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableCell : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal int _rowspan;
        internal int _colspan;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal TableCell(int rowspan, int colspan, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._rowspan = rowspan;
            this._children = children;
            this._colspan = colspan;
        }
        public int getColspan() {
            return this._colspan;
        }
        public int getRowspan() {
            return this._rowspan;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal bool _isHeader;
        internal TableRow(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children, bool isHeader) {
            this._children = children;
            this._isHeader = isHeader;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
        public bool isHeader() {
            return this._isHeader;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Text : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _value;
        internal Text(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal enum VerticalAlignment {
        _SUPERSCRIPT, _SUBSCRIPT, _BASELINE
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _relationships;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal BodyXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._styles = styles;
            this._numbering = numbering;
            this._relationships = relationships;
            this._contentTypes = contentTypes;
            this._file = file;
            this._fileReader = fileReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElements(Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> nodes) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader(this._styles, this._numbering, this._relationships, this._contentTypes, this._file, this._fileReader)).readElements(nodes);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader(this._styles, this._numbering, this._relationships, this._contentTypes, this._file, this._fileReader)).readElement(element);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal CommentXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            this._bodyReader = bodyReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>(element.findChildren("w:comment"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader__Anonymous_0(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> readCommentElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string commentId = element.getAttribute("w:id");
            return (((this._bodyReader).readElements(element.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader__Anonymous_1(commentId, this, element));
        }
        public Mammoth.Couscous.java.util.Optional<string> readOptionalAttribute(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string name) {
            string value = ((element.getAttributeOrNone(name)).orElse("")).trim();
            if (value.isEmpty()) {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            } else {
                return Mammoth.Couscous.java.util.Optional.of<string>(value);
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        internal CommentXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readCommentElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class CommentXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> {
        internal string _commentId;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader _this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal CommentXmlReader__Anonymous_1(string commentId, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader this_org__zwobble__mammoth__internal__docx__CommentXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            this._commentId = commentId;
            this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader = this_org__zwobble__mammoth__internal__docx__CommentXmlReader;
            this._element = element;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment(this._commentId, children, (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(this._element, "w:author"), (this._this_org__zwobble__mammoth__internal__docx__CommentXmlReader).readOptionalAttribute(this._element, "w:initials"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _DEFAULT;
        internal static Mammoth.Couscous.java.util.Map<string, string> _imageExtensions;
        internal Mammoth.Couscous.java.util.Map<string, string> _extensionDefaults;
        internal Mammoth.Couscous.java.util.Map<string, string> _overrides;
        static ContentTypes() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._imageExtensions = ((((((((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.builder<string, string>()).put("png", "png")).put("gif", "gif")).put("jpeg", "jpeg")).put("jpg", "jpeg")).put("bmp", "bmp")).put("tif", "tiff")).put("tiff", "tiff")).build();
        }
        internal ContentTypes(Mammoth.Couscous.java.util.Map<string, string> extensionDefaults, Mammoth.Couscous.java.util.Map<string, string> overrides) {
            this._extensionDefaults = extensionDefaults;
            this._overrides = overrides;
        }
        public Mammoth.Couscous.java.util.Optional<string> findContentType(string path) {
            if ((this._overrides).containsKey(path)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._overrides, path);
            } else {
                string extension = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Paths.getExtension(path);
                if ((this._extensionDefaults).containsKey(extension)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._extensionDefaults, extension);
                } else {
                    return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._imageExtensions, extension.ToLower())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes__Anonymous_0());
                }
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<string, string> {
        public string apply(string imageType) {
            return "image/" + imageType;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readDefaults(element.findChildren("content-types:Default")), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readOverrides(element.findChildren("content-types:Override")));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readDefaults(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readDefault(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(element.getAttribute("Extension"), element.getAttribute("ContentType"));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readOverrides(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readOverride(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(element.getAttribute("PartName"), '/'), element.getAttribute("ContentType"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readDefault(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readOverride(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Dingbats {
        internal static Mammoth.Couscous.java.util.Map<string, int> _dingbats;
        static Dingbats() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats = new Mammoth.Couscous.java.util.HashMap<string, int>();
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_32", 32);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_33", 33);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_34", 8704);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_35", 35);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_36", 8707);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_37", 37);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_38", 38);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_39", 8717);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_40", 40);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_41", 41);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_42", 42);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_43", 43);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_44", 44);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_45", 8722);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_46", 46);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_47", 47);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_48", 48);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_49", 49);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_50", 50);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_51", 51);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_52", 52);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_53", 53);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_54", 54);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_55", 55);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_56", 56);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_57", 57);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_58", 58);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_59", 59);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_60", 60);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_61", 61);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_62", 62);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_63", 63);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_64", 8773);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_65", 913);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_66", 914);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_67", 935);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_68", 916);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_69", 917);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_70", 934);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_71", 915);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_72", 919);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_73", 921);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_74", 977);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_75", 922);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_76", 923);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_77", 924);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_78", 925);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_79", 927);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_80", 928);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_81", 920);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_82", 929);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_83", 931);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_84", 932);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_85", 933);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_86", 962);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_87", 937);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_88", 926);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_89", 936);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_90", 918);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_91", 91);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_92", 8756);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_93", 93);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_94", 8869);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_95", 95);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_96", 8254);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_97", 945);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_98", 946);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_99", 967);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_100", 948);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_101", 949);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_102", 966);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_103", 947);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_104", 951);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_105", 953);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_106", 981);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_107", 954);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_108", 955);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_109", 956);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_110", 957);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_111", 959);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_112", 960);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_113", 952);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_114", 961);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_115", 963);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_116", 964);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_117", 965);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_118", 982);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_119", 969);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_120", 958);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_121", 968);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_122", 950);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_123", 123);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_124", 124);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_125", 125);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_126", 126);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_160", 8364);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_161", 978);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_162", 8242);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_163", 8804);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_164", 8260);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_165", 8734);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_166", 402);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_167", 9827);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_168", 9830);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_169", 9829);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_170", 9824);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_171", 8596);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_172", 8592);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_173", 8593);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_174", 8594);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_175", 8595);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_176", 176);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_177", 177);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_178", 8243);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_179", 8805);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_180", 215);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_181", 8733);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_182", 8706);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_183", 8226);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_184", 247);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_185", 8800);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_186", 8801);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_187", 8776);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_188", 8230);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_189", 9168);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_190", 9135);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_191", 8629);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_192", 8501);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_193", 8465);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_194", 8476);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_195", 8472);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_196", 8855);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_197", 8853);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_198", 8709);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_199", 8745);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_200", 8746);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_201", 8835);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_202", 8839);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_203", 8836);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_204", 8834);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_205", 8838);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_206", 8712);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_207", 8713);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_208", 8736);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_209", 8711);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_210", 174);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_211", 169);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_212", 8482);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_213", 8719);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_214", 8730);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_215", 8901);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_216", 172);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_217", 8743);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_218", 8744);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_219", 8660);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_220", 8656);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_221", 8657);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_222", 8658);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_223", 8659);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_224", 9674);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_225", 12296);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_226", 174);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_227", 169);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_228", 8482);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_229", 8721);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_230", 9115);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_231", 9116);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_232", 9117);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_233", 9121);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_234", 9122);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_235", 9123);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_236", 9127);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_237", 9128);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_238", 9129);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_239", 9130);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_240", 63743);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_241", 12297);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_242", 8747);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_243", 8992);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_244", 9134);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_245", 8993);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_246", 9118);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_247", 9119);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_248", 9120);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_249", 9124);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_250", 9125);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_251", 9126);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_252", 9131);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_253", 9132);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Symbol_254", 9133);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_32", 32);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_33", 128375);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_34", 128376);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_35", 128370);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_36", 128374);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_37", 127942);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_38", 127894);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_39", 128391);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_40", 128488);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_41", 128489);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_42", 128496);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_43", 128497);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_44", 127798);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_45", 127895);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_46", 128638);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_47", 128636);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_48", 128469);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_49", 128470);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_50", 128471);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_51", 9204);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_52", 9205);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_53", 9206);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_54", 9207);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_55", 9194);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_56", 9193);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_57", 9198);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_58", 9197);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_59", 9208);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_60", 9209);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_61", 9210);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_62", 128474);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_63", 128499);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_64", 128736);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_65", 127959);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_66", 127960);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_67", 127961);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_68", 127962);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_69", 127964);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_70", 127981);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_71", 127963);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_72", 127968);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_73", 127958);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_74", 127965);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_75", 128739);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_76", 128269);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_77", 127956);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_78", 128065);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_79", 128066);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_80", 127966);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_81", 127957);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_82", 128740);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_83", 127967);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_84", 128755);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_85", 128364);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_86", 128363);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_87", 128360);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_88", 128264);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_89", 127892);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_90", 127893);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_91", 128492);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_92", 128637);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_93", 128493);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_94", 128490);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_95", 128491);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_96", 11156);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_97", 10004);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_98", 128690);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_99", 11036);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_100", 128737);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_101", 128230);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_102", 128753);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_103", 11035);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_104", 128657);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_105", 128712);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_106", 128745);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_107", 128752);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_108", 128968);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_109", 128372);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_110", 11044);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_111", 128741);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_112", 128660);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_113", 128472);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_114", 128473);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_115", 10067);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_116", 128754);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_117", 128647);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_118", 128653);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_119", 9971);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_120", 10680);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_121", 8854);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_122", 128685);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_123", 128494);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_124", 9168);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_125", 128495);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_126", 128498);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_128", 128697);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_129", 128698);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_130", 128713);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_131", 128714);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_132", 128700);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_133", 128125);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_134", 127947);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_135", 9975);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_136", 127938);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_137", 127948);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_138", 127946);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_139", 127940);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_140", 127949);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_141", 127950);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_142", 128664);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_143", 128480);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_144", 128738);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_145", 128176);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_146", 127991);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_147", 128179);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_148", 128106);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_149", 128481);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_150", 128482);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_151", 128483);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_152", 10031);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_153", 128388);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_154", 128389);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_155", 128387);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_156", 128390);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_157", 128441);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_158", 128442);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_159", 128443);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_160", 128373);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_161", 128368);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_162", 128445);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_163", 128446);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_164", 128203);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_165", 128466);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_166", 128467);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_167", 128366);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_168", 128218);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_169", 128478);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_170", 128479);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_171", 128451);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_172", 128450);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_173", 128444);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_174", 127917);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_175", 127900);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_176", 127896);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_177", 127897);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_178", 127911);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_179", 128191);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_180", 127902);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_181", 128247);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_182", 127903);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_183", 127916);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_184", 128253);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_185", 128249);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_186", 128254);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_187", 128251);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_188", 127898);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_189", 127899);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_190", 128250);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_191", 128187);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_192", 128421);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_193", 128422);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_194", 128423);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_195", 128377);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_196", 127918);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_197", 128379);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_198", 128380);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_199", 128223);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_200", 128385);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_201", 128384);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_202", 128424);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_203", 128425);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_204", 128447);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_205", 128426);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_206", 128476);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_207", 128274);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_208", 128275);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_209", 128477);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_210", 128229);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_211", 128228);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_212", 128371);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_213", 127779);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_214", 127780);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_215", 127781);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_216", 127782);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_217", 9729);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_218", 127784);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_219", 127783);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_220", 127785);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_221", 127786);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_222", 127788);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_223", 127787);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_224", 127772);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_225", 127777);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_226", 128715);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_227", 128719);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_228", 127869);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_229", 127864);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_230", 128718);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_231", 128717);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_232", 9413);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_233", 9855);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_234", 128710);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_235", 128392);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_236", 127891);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_237", 128484);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_238", 128485);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_239", 128486);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_240", 128487);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_241", 128746);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_242", 128063);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_243", 128038);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_244", 128031);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_245", 128021);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_246", 128008);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_247", 128620);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_248", 128622);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_249", 128621);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_250", 128623);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_251", 128506);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_252", 127757);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_253", 127759);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_254", 127758);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Webdings_255", 128330);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_32", 32);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_33", 128393);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_34", 9986);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_35", 9985);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_36", 128083);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_37", 128365);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_38", 128366);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_39", 128367);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_40", 128383);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_41", 9990);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_42", 128386);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_43", 128387);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_44", 128234);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_45", 128235);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_46", 128236);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_47", 128237);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_48", 128448);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_49", 128449);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_50", 128462);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_51", 128463);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_52", 128464);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_53", 128452);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_54", 8987);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_55", 128430);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_56", 128432);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_57", 128434);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_58", 128435);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_59", 128436);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_60", 128427);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_61", 128428);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_62", 9991);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_63", 9997);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_64", 128398);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_65", 9996);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_66", 128399);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_67", 128077);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_68", 128078);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_69", 9756);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_70", 9758);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_71", 9757);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_72", 9759);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_73", 128400);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_74", 9786);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_75", 128528);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_76", 9785);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_77", 128163);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_78", 128369);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_79", 127987);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_80", 127985);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_81", 9992);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_82", 9788);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_83", 127778);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_84", 10052);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_85", 128326);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_86", 10014);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_87", 128328);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_88", 10016);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_89", 10017);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_90", 9770);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_91", 9775);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_92", 128329);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_93", 9784);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_94", 9800);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_95", 9801);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_96", 9802);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_97", 9803);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_98", 9804);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_99", 9805);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_100", 9806);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_101", 9807);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_102", 9808);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_103", 9809);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_104", 9810);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_105", 9811);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_106", 128624);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_107", 128629);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_108", 9899);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_109", 128318);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_110", 9724);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_111", 128911);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_112", 128912);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_113", 10065);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_114", 10066);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_115", 128927);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_116", 10731);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_117", 9670);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_118", 10070);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_119", 11049);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_120", 8999);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_121", 11193);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_122", 8984);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_123", 127989);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_124", 127990);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_125", 128630);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_126", 128631);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_127", 9647);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_128", 127243);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_129", 10112);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_130", 10113);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_131", 10114);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_132", 10115);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_133", 10116);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_134", 10117);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_135", 10118);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_136", 10119);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_137", 10120);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_138", 10121);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_139", 127244);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_140", 10122);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_141", 10123);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_142", 10124);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_143", 10125);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_144", 10126);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_145", 10127);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_146", 10128);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_147", 10129);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_148", 10130);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_149", 10131);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_150", 128610);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_151", 128608);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_152", 128609);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_153", 128611);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_154", 128606);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_155", 128604);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_156", 128605);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_157", 128607);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_158", 8729);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_159", 8226);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_160", 11037);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_161", 11096);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_162", 128902);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_163", 128904);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_164", 128906);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_165", 128907);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_166", 128319);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_167", 9642);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_168", 128910);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_169", 128961);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_170", 128965);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_171", 9733);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_172", 128971);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_173", 128975);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_174", 128979);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_175", 128977);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_176", 11216);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_177", 8982);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_178", 11214);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_179", 11215);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_180", 11217);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_181", 10026);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_182", 10032);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_183", 128336);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_184", 128337);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_185", 128338);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_186", 128339);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_187", 128340);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_188", 128341);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_189", 128342);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_190", 128343);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_191", 128344);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_192", 128345);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_193", 128346);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_194", 128347);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_195", 11184);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_196", 11185);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_197", 11186);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_198", 11187);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_199", 11188);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_200", 11189);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_201", 11190);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_202", 11191);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_203", 128618);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_204", 128619);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_205", 128597);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_206", 128596);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_207", 128599);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_208", 128598);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_209", 128592);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_210", 128593);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_211", 128594);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_212", 128595);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_213", 9003);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_214", 8998);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_215", 11160);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_216", 11162);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_217", 11161);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_218", 11163);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_219", 11144);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_220", 11146);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_221", 11145);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_222", 11147);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_223", 129128);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_224", 129130);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_225", 129129);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_226", 129131);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_227", 129132);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_228", 129133);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_229", 129135);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_230", 129134);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_231", 129144);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_232", 129146);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_233", 129145);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_234", 129147);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_235", 129148);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_236", 129149);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_237", 129151);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_238", 129150);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_239", 8678);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_240", 8680);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_241", 8679);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_242", 8681);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_243", 11012);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_244", 8691);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_245", 11009);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_246", 11008);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_247", 11011);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_248", 11010);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_249", 129196);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_250", 129197);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_251", 128502);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_252", 10003);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_253", 128503);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings_254", 128505);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_32", 32);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_33", 128394);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_34", 128395);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_35", 128396);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_36", 128397);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_37", 9988);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_38", 9984);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_39", 128382);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_40", 128381);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_41", 128453);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_42", 128454);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_43", 128455);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_44", 128456);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_45", 128457);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_46", 128458);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_47", 128459);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_48", 128460);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_49", 128461);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_50", 128203);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_51", 128465);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_52", 128468);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_53", 128437);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_54", 128438);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_55", 128439);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_56", 128440);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_57", 128429);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_58", 128431);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_59", 128433);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_60", 128402);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_61", 128403);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_62", 128408);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_63", 128409);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_64", 128410);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_65", 128411);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_66", 128072);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_67", 128073);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_68", 128412);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_69", 128413);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_70", 128414);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_71", 128415);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_72", 128416);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_73", 128417);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_74", 128070);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_75", 128071);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_76", 128418);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_77", 128419);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_78", 128401);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_79", 128500);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_80", 128504);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_81", 128501);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_82", 9745);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_83", 11197);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_84", 9746);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_85", 11198);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_86", 11199);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_87", 128711);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_88", 10680);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_89", 128625);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_90", 128628);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_91", 128626);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_92", 128627);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_93", 8253);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_94", 128633);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_95", 128634);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_96", 128635);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_97", 128614);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_98", 128612);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_99", 128613);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_100", 128615);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_101", 128602);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_102", 128600);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_103", 128601);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_104", 128603);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_105", 9450);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_106", 9312);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_107", 9313);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_108", 9314);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_109", 9315);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_110", 9316);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_111", 9317);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_112", 9318);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_113", 9319);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_114", 9320);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_115", 9321);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_116", 9471);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_117", 10102);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_118", 10103);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_119", 10104);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_120", 10105);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_121", 10106);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_122", 10107);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_123", 10108);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_124", 10109);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_125", 10110);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_126", 10111);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_128", 9737);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_129", 127765);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_130", 9789);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_131", 9790);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_132", 11839);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_133", 10013);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_134", 128327);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_135", 128348);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_136", 128349);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_137", 128350);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_138", 128351);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_139", 128352);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_140", 128353);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_141", 128354);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_142", 128355);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_143", 128356);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_144", 128357);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_145", 128358);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_146", 128359);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_147", 128616);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_148", 128617);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_149", 8901);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_150", 128900);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_151", 10625);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_152", 9679);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_153", 9675);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_154", 128901);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_155", 128903);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_156", 128905);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_157", 8857);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_158", 10687);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_159", 128908);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_160", 128909);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_161", 9726);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_162", 9632);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_163", 9633);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_164", 128913);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_165", 128914);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_166", 128915);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_167", 128916);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_168", 9635);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_169", 128917);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_170", 128918);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_171", 128919);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_172", 128920);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_173", 11049);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_174", 11045);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_175", 9671);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_176", 128922);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_177", 9672);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_178", 128923);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_179", 128924);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_180", 128925);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_181", 128926);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_182", 11050);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_183", 11047);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_184", 9674);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_185", 128928);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_186", 9686);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_187", 9687);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_188", 11210);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_189", 11211);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_190", 11200);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_191", 11201);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_192", 11039);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_193", 11202);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_194", 11043);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_195", 11042);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_196", 11203);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_197", 11204);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_198", 128929);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_199", 128930);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_200", 128931);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_201", 128932);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_202", 128933);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_203", 128934);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_204", 128935);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_205", 128936);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_206", 128937);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_207", 128938);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_208", 128939);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_209", 128940);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_210", 128941);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_211", 128942);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_212", 128943);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_213", 128944);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_214", 128945);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_215", 128946);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_216", 128947);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_217", 128948);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_218", 128949);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_219", 128950);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_220", 128951);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_221", 128952);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_222", 128953);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_223", 128954);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_224", 128955);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_225", 128956);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_226", 128957);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_227", 128958);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_228", 128959);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_229", 128960);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_230", 128962);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_231", 128964);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_232", 128966);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_233", 128969);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_234", 128970);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_235", 10038);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_236", 128972);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_237", 128974);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_238", 128976);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_239", 128978);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_240", 10041);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_241", 128963);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_242", 128967);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_243", 10031);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_244", 128973);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_245", 128980);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_246", 11212);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_247", 11213);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_248", 8251);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 2_249", 8258);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_32", 32);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_33", 11104);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_34", 11106);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_35", 11105);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_36", 11107);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_37", 11110);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_38", 11111);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_39", 11113);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_40", 11112);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_41", 11120);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_42", 11122);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_43", 11121);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_44", 11123);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_45", 11126);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_46", 11128);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_47", 11131);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_48", 11133);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_49", 11108);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_50", 11109);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_51", 11114);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_52", 11116);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_53", 11115);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_54", 11117);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_55", 11085);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_56", 11168);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_57", 11169);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_58", 11170);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_59", 11171);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_60", 11172);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_61", 11173);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_62", 11174);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_63", 11175);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_64", 11152);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_65", 11153);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_66", 11154);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_67", 11155);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_68", 11136);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_69", 11139);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_70", 11134);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_71", 11135);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_72", 11140);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_73", 11142);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_74", 11141);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_75", 11143);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_76", 11151);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_77", 11149);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_78", 11150);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_79", 11148);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_80", 11118);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_81", 11119);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_82", 9099);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_83", 8996);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_84", 8963);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_85", 8997);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_86", 9251);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_87", 9085);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_88", 8682);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_89", 11192);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_90", 129184);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_91", 129185);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_92", 129186);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_93", 129187);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_94", 129188);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_95", 129189);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_96", 129190);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_97", 129191);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_98", 129192);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_99", 129193);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_100", 129194);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_101", 129195);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_102", 129104);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_103", 129106);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_104", 129105);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_105", 129107);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_106", 129108);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_107", 129109);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_108", 129111);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_109", 129110);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_110", 129112);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_111", 129113);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_112", 9650);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_113", 9660);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_114", 9651);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_115", 9661);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_116", 9664);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_117", 9654);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_118", 9665);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_119", 9655);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_120", 9699);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_121", 9698);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_122", 9700);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_123", 9701);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_124", 128896);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_125", 128898);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_126", 128897);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_128", 128899);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_129", 11205);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_130", 11206);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_131", 11207);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_132", 11208);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_133", 11164);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_134", 11166);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_135", 11165);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_136", 11167);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_137", 129040);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_138", 129042);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_139", 129041);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_140", 129043);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_141", 129044);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_142", 129046);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_143", 129045);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_144", 129047);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_145", 129048);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_146", 129050);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_147", 129049);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_148", 129051);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_149", 129052);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_150", 129054);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_151", 129053);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_152", 129055);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_153", 129024);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_154", 129026);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_155", 129025);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_156", 129027);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_157", 129028);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_158", 129030);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_159", 129029);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_160", 129031);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_161", 129032);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_162", 129034);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_163", 129033);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_164", 129035);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_165", 129056);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_166", 129058);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_167", 129060);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_168", 129062);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_169", 129064);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_170", 129066);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_171", 129068);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_172", 129180);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_173", 129181);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_174", 129182);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_175", 129183);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_176", 129070);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_177", 129072);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_178", 129074);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_179", 129076);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_180", 129078);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_181", 129080);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_182", 129082);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_183", 129081);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_184", 129083);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_185", 129176);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_186", 129178);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_187", 129177);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_188", 129179);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_189", 129084);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_190", 129086);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_191", 129085);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_192", 129087);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_193", 129088);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_194", 129090);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_195", 129089);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_196", 129091);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_197", 129092);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_198", 129094);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_199", 129093);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_200", 129095);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_201", 11176);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_202", 11177);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_203", 11178);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_204", 11179);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_205", 11180);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_206", 11181);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_207", 11182);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_208", 11183);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_209", 129120);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_210", 129122);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_211", 129121);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_212", 129123);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_213", 129124);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_214", 129125);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_215", 129127);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_216", 129126);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_217", 129136);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_218", 129138);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_219", 129137);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_220", 129139);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_221", 129140);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_222", 129141);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_223", 129143);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_224", 129142);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_225", 129152);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_226", 129154);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_227", 129153);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_228", 129155);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_229", 129156);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_230", 129157);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_231", 129159);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_232", 129158);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_233", 129168);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_234", 129170);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_235", 129169);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_236", 129171);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_237", 129172);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_238", 129174);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_239", 129173);
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats).put("Wingdings 3_240", 129175);
        }
        public static Mammoth.Couscous.java.util.Optional<int> findDingbat(string font, int codePoint) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, int>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats._dingbats, (font + "_") + codePoint);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readDocument(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findPartPaths(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readStyles(zipFile, partPaths);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNumbering(zipFile, partPaths, styles);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readContentTypes(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader(path);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader partReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader(zipFile, contentTypes, fileReader, numbering, styles);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNotes(partReader, partPaths), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readComments(partReader, partPaths), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_1(partReader, partPaths));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths findPartPaths(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships packageRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readPackageRelationships(archive);
            string documentFilename = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findDocumentFilename(archive, packageRelationships);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships documentRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readRelationships(archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findRelationshipsPathFor(documentFilename));
            Mammoth.Couscous.java.util.function.Function<string, string> find = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_2(archive, documentRelationships, documentFilename);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths(documentFilename, find.apply("comments"), find.apply("endnotes"), find.apply("footnotes"), find.apply("numbering"), find.apply("styles"));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readPackageRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readRelationships(archive, "_rels/.rels");
        }
        public static string findDocumentFilename(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships packageRelationships) {
            string officeDocumentType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
            string mainDocumentPath = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findPartPath(archive, packageRelationships, officeDocumentType, "", "word/document.xml");
            if (archive.exists(mainDocumentPath)) {
                return mainDocumentPath;
            } else {
                throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException(new Mammoth.Couscous.java.io.IOException("Could not find main document part. Are you sure this is a valid .docx file?"));
            }
        }
        public static string findPartPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, string relationshipType, string basePath, string fallbackPath) {
            Mammoth.Couscous.java.util.List<string> targets = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<string, string>(relationships.findTargetsByType(relationshipType), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_3(basePath));
            Mammoth.Couscous.java.util.List<string> validTargets = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFilter<string>(targets, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_4(archive));
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.tryGetFirst<string>(validTargets)).orElse(fallbackPath);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> readComments(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader partReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths) {
            return partReader.readPart<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>>(partPaths.getComments(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_5(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>())));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> readNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader partReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(partReader.readPart<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(partPaths.getFootnotes(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_6(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>()))), partReader.readPart<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(partPaths.getEndnotes(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_7(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>()))), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_8())).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_9());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, partPaths.getStyles())).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_10())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, partPaths.getNumbering())).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_11(styles))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "[Content_Types].xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_12())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._DEFAULT);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, name)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_13())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY);
        }
        public static string findRelationshipsPathFor(string name) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath parts = Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.splitPath(name);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.joinPath(new string[] {parts.getDirname(), "_rels", parts.getBasename() + ".rels"});
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> tryParseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_15(zipFile, name));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, name)).orElseThrow<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_16(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartWithBodyReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal DocumentReader__PartWithBodyReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            this._zipFile = zipFile;
            this._contentTypes = contentTypes;
            this._fileReader = fileReader;
            this._numbering = numbering;
            this._styles = styles;
        }
        public T readPart<T>(string name, Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> readPart, Mammoth.Couscous.java.util.Optional<T> defaultValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readRelationships(this._zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findRelationshipsPathFor(name));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader(this._styles, this._numbering, relationships, this._contentTypes, this._zipFile, this._fileReader);
            if (defaultValue.isPresent()) {
                return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(this._zipFile, name)).map<T>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_17<T>(readPart, bodyReader))).orElse(defaultValue.get());
            } else {
                return readPart.apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.parseOfficeXml(this._zipFile, name), bodyReader);
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartPaths {
        internal string _mainDocument;
        internal string _comments;
        internal string _endnotes;
        internal string _footnotes;
        internal string _numbering;
        internal string _styles;
        internal DocumentReader__PartPaths(string mainDocument, string comments, string endnotes, string footnotes, string numbering, string styles) {
            this._mainDocument = mainDocument;
            this._comments = comments;
            this._endnotes = endnotes;
            this._footnotes = footnotes;
            this._numbering = numbering;
            this._styles = styles;
        }
        public string getMainDocument() {
            return this._mainDocument;
        }
        public string getComments() {
            return this._comments;
        }
        public string getEndnotes() {
            return this._endnotes;
        }
        public string getFootnotes() {
            return this._footnotes;
        }
        public string getNumbering() {
            return this._numbering;
        }
        public string getStyles() {
            return this._styles;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_0 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal DocumentReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader(bodyReader, this._notes, this._comments)).readElement(element);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_1 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader _partReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths _partPaths;
        internal DocumentReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartWithBodyReader partReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__PartPaths partPaths) {
            this._partReader = partReader;
            this._partPaths = partPaths;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            return (this._partReader).readPart<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>>((this._partPaths).getMainDocument(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_0(notes, comments), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _archive;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _documentRelationships;
        internal string _documentFilename;
        internal DocumentReader__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships documentRelationships, string documentFilename) {
            this._archive = archive;
            this._documentRelationships = documentRelationships;
            this._documentFilename = documentFilename;
        }
        public string apply(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.findPartPath(this._archive, this._documentRelationships, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/" + name, (Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.splitPath(this._documentFilename)).getDirname(), ("word/" + name) + ".xml");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _basePath;
        internal DocumentReader__Anonymous_3(string basePath) {
            this._basePath = basePath;
        }
        public string apply(string target) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths.joinPath(new string[] {this._basePath, target}), '/');
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_4 : Mammoth.Couscous.java.util.function.Predicate<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _archive;
        internal DocumentReader__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive archive) {
            this._archive = archive;
        }
        public bool test(string arg0) {
            return (this._archive).exists(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_5 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader(bodyReader)).readElement(root);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_6 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.footnote(bodyReader)).readElement(root);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_7 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.endnote(bodyReader)).readElement(root);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_8 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg1) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_10 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStylesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_11 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal DocumentReader__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            this._styles = styles;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNumberingXmlElement(element, this._styles);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_12 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readContentTypesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml.readRelationshipsXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_14 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement apply(Mammoth.Couscous.java.io.InputStream arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.parseXml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_15 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal string _name;
        internal DocumentReader__Anonymous_15(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            this._zipFile = zipFile;
            this._name = name;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> get() {
            return ((this._zipFile).tryGetInputStream(this._name)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_14());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_16 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException> {
        internal string _name;
        internal DocumentReader__Anonymous_16(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException get() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException(new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal static class DocumentReader__Anonymous_17 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_17<T> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, T> {
        internal Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> _readPart;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal DocumentReader__Anonymous_17(Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> readPart, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            this._readPart = readPart;
            this._bodyReader = bodyReader;
        }
        public T apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root) {
            return (this._readPart).apply(root, this._bodyReader);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal DocumentXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._bodyReader = bodyReader;
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> body = element.findChild("w:body");
            if (!body.isPresent()) {
                throw new Mammoth.Couscous.java.lang.IllegalArgumentException("Could not find the body element: are you sure this is a docx file?");
            }
            return (((this._bodyReader).readElements((body.get()).getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader__Anonymous_0(this));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader _this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        internal DocumentXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader this_org__zwobble__mammoth__internal__docx__DocumentXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader = this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document(children, (this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._notes, (this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._comments);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap {
        internal static string _STYLE_MAP_PATH;
        internal static string _ABSOLUTE_STYLE_MAP_PATH;
        internal static string _RELATIONSHIPS_PATH;
        internal static string _CONTENT_TYPES_PATH;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _RELATIONSHIPS_NAMESPACES;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _CONTENT_TYPES_NAMESPACES;
        static EmbeddedStyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH = "mammoth/style-map";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH = "/" + Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH;
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH = "word/_rels/document.xml.rels";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH = "[Content_Types].xml";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/relationships")).build();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/content-types")).build();
        }
        public static Mammoth.Couscous.java.util.Optional<string> readStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return (file.tryGetInputStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_0());
        }
        public static void embedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive, string styleMap) {
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH, styleMap);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateRelationships(archive);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateContentTypes(archive);
        }
        public static void updateRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement relationships = parser.parseStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream(archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement relationship = Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element("Relationship", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("Id", "rMammothStyleMap", "Type", "http://schemas.zwobble.org/mammoth/style-map", "Target", Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updatedRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateOrAddElement(relationships, relationship, "Id");
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlWriter.toString(updatedRelationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES));
        }
        public static void updateContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement contentTypes = parser.parseStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream(archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement @override = Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element("Override", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("PartName", Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH, "ContentType", "text/prs.mammoth.style-map"));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updatedRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateOrAddElement(contentTypes, @override, "PartName");
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlWriter.toString(updatedRelationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updateOrAddElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parent, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            Mammoth.Couscous.java.util.OptionalInt index = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.findIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(parent.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_2(element, identifyingAttribute));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(parent.getChildren());
            if (index.isPresent()) {
                children.set(index.getAsInt(), element);
            } else {
                children.add(element);
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(parent.getName(), parent.getAttributes(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.io.InputStream, string> {
        public string apply(Mammoth.Couscous.java.io.InputStream arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Streams.toString(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal string _identifyingAttribute;
        internal EmbeddedStyleMap__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            this._element = element;
            this._identifyingAttribute = identifyingAttribute;
        }
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement childElement) {
            return ((childElement.getName()).Equals((this._element).getName())) && (childElement.getAttributeOrNone(this._identifyingAttribute)).equals((this._element).getAttributeOrNone(this._identifyingAttribute));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal string _identifyingAttribute;
        internal EmbeddedStyleMap__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            this._element = element;
            this._identifyingAttribute = identifyingAttribute;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode child) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement), child)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_1(this._element, this._identifyingAttribute))).orElse(false);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface FileReader {
        Mammoth.Couscous.java.io.InputStream getInputStream(string uri);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal string _tagName;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _noteType;
        internal NotesXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader, string tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType) {
            this._bodyReader = bodyReader;
            this._tagName = tagName;
            this._noteType = noteType;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader footnote(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader(bodyReader, "footnote", Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader endnote(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader(bodyReader, "endnote", Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> elements = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(element.findChildren("w:" + this._tagName), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_0(this));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_1(this));
        }
        public bool isNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:type")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_2(this))).orElse(true);
        }
        public bool isSeparatorType(string type) {
            return (type.Equals("continuationSeparator")) || (type.Equals("separator"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> readNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (((this._bodyReader).readElements(element.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader__Anonymous_3(this, element));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isNoteElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).readNoteElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public bool apply(string type) {
            return !(this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isSeparatorType(type);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal NotesXmlReader__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
            this._element = element;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note((this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader)._noteType, (this._element).getAttribute("w:id"), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> _abstractNums;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> _levelsByParagraphStyleId;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> _nums;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        static Numbering() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY);
        }
        internal Numbering(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> abstractNums, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> nums, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            this._abstractNums = abstractNums;
            this._levelsByParagraphStyleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(abstractNums.values(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_0()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_1()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_2());
            this._nums = nums;
            this._styles = styles;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> findLevel(string numId, string level) {
            return (((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num>(this._nums, numId)).flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_3())).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_4(this))).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_9(this, level));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> findLevelByParagraphStyleId(string styleId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(this._levelsByParagraphStyleId, styleId)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_10());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__AbstractNum {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> _levels;
        internal Mammoth.Couscous.java.util.Optional<string> _numStyleLink;
        internal Numbering__AbstractNum(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> levels, Mammoth.Couscous.java.util.Optional<string> numStyleLink) {
            this._levels = levels;
            this._numStyleLink = numStyleLink;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__AbstractNumLevel {
        internal string _levelIndex;
        internal bool _isOrdered;
        internal Mammoth.Couscous.java.util.Optional<string> _paragraphStyleId;
        internal Numbering__AbstractNumLevel(string levelIndex, bool isOrdered, Mammoth.Couscous.java.util.Optional<string> paragraphStyleId) {
            this._levelIndex = levelIndex;
            this._isOrdered = isOrdered;
            this._paragraphStyleId = paragraphStyleId;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel ordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel(levelIndex, true, Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel unordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel(levelIndex, false, Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel toNumberingLevel() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(this._levelIndex, this._isOrdered);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Num {
        internal Mammoth.Couscous.java.util.Optional<string> _abstractNumId;
        internal Numbering__Num(Mammoth.Couscous.java.util.Optional<string> abstractNumId) {
            this._abstractNumId = abstractNumId;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum abstractNum) {
            return (abstractNum._levels).values();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_1 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> {
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel level) {
            return (level._paragraphStyleId).isPresent();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel level) {
            return (level._paragraphStyleId).get();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num, Mammoth.Couscous.java.util.Optional<string>> {
        public Mammoth.Couscous.java.util.Optional<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num num) {
            return num._abstractNumId;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _this_org__zwobble__mammoth__internal__docx__Numbering;
        internal Numbering__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering this_org__zwobble__mammoth__internal__docx__Numbering) {
            this._this_org__zwobble__mammoth__internal__docx__Numbering = this_org__zwobble__mammoth__internal__docx__Numbering;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> apply(string abstractNumId) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>((this._this_org__zwobble__mammoth__internal__docx__Numbering)._abstractNums, abstractNumId);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_5 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _this_org__zwobble__mammoth__internal__docx__Numbering;
        internal Numbering__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering this_org__zwobble__mammoth__internal__docx__Numbering) {
            this._this_org__zwobble__mammoth__internal__docx__Numbering = this_org__zwobble__mammoth__internal__docx__Numbering;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> apply(string numStyleLink) {
            return ((this._this_org__zwobble__mammoth__internal__docx__Numbering)._styles).findNumberingStyleById(numStyleLink);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle, Mammoth.Couscous.java.util.Optional<string>> {
        public Mammoth.Couscous.java.util.Optional<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle style) {
            return style.getNumId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_7 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _this_org__zwobble__mammoth__internal__docx__Numbering;
        internal string _level;
        internal Numbering__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering this_org__zwobble__mammoth__internal__docx__Numbering, string level) {
            this._this_org__zwobble__mammoth__internal__docx__Numbering = this_org__zwobble__mammoth__internal__docx__Numbering;
            this._level = level;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(string linkedNumId) {
            return (this._this_org__zwobble__mammoth__internal__docx__Numbering).findLevel(linkedNumId, this._level);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_8 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel value) {
            return value.toNumberingLevel();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _this_org__zwobble__mammoth__internal__docx__Numbering;
        internal string _level;
        internal Numbering__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering this_org__zwobble__mammoth__internal__docx__Numbering, string level) {
            this._this_org__zwobble__mammoth__internal__docx__Numbering = this_org__zwobble__mammoth__internal__docx__Numbering;
            this._level = level;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum abstractNum) {
            if ((abstractNum._numStyleLink).isPresent()) {
                return (((abstractNum._numStyleLink).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_5(this._this_org__zwobble__mammoth__internal__docx__Numbering))).flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_6())).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_7(this._this_org__zwobble__mammoth__internal__docx__Numbering, this._level));
            } else {
                return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(abstractNum._levels, this._level)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_8());
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_10 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel value) {
            return value.toNumberingLevel();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumberingXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles) {
            Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> abstractNums = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNums(element.findChildren("w:abstractNum"));
            Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> nums = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNums(element.findChildren("w:num"));
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(abstractNums, nums, styles);
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> readAbstractNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> readAbstractNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string abstractNumId = element.getAttribute("w:abstractNumId");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum abstractNum = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevels(element), (element.findChildOrEmpty("w:numStyleLink")).getAttributeOrNone("w:val"));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>(abstractNumId, abstractNum);
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> readAbstractNumLevels(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(element.findChildren("w:lvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> readAbstractNumLevel(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string levelIndex = element.getAttribute("w:ilvl");
            Mammoth.Couscous.java.util.Optional<string> numFmt = (element.findChildOrEmpty("w:numFmt")).getAttributeOrNone("w:val");
            bool isOrdered = !numFmt.equals(Mammoth.Couscous.java.util.Optional.of<string>("bullet"));
            Mammoth.Couscous.java.util.Optional<string> paragraphStyleId = (element.findChildOrEmpty("w:pStyle")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>(levelIndex, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel(levelIndex, isOrdered, paragraphStyleId));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> readNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList numElements) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num>(numElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_2());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> readNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement) {
            string numId = numElement.getAttribute("w:numId");
            Mammoth.Couscous.java.util.Optional<string> abstractNumId = (numElement.findChildOrEmpty("w:abstractNumId")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num>(numId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num(abstractNumId));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNum> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNum(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__AbstractNumLevel> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevel(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Num> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNum(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _XML_NAMESPACES;
        static OfficeXml() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml._XML_NAMESPACES = ((((((((((((((((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")).put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")).put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")).put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")).put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")).put("w", "http://purl.oclc.org/ooxml/wordprocessingml/main")).put("r", "http://purl.oclc.org/ooxml/officeDocument/relationships")).put("wp", "http://purl.oclc.org/ooxml/drawingml/wordprocessingDrawing")).put("a", "http://purl.oclc.org/ooxml/drawingml/main")).put("pic", "http://purl.oclc.org/ooxml/drawingml/picture")).put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")).put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")).put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")).put("v", "urn:schemas-microsoft-com:vml")).put("office-word", "urn:schemas-microsoft-com:office:word")).build();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseXml(Mammoth.Couscous.java.io.InputStream inputStream) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml._XML_NAMESPACES);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement) (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.collapseAlternateContent(parser.parseStream(inputStream))).get(0);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> collapseAlternateContent(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode node) {
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml__Anonymous_1());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.collapseAlternateContent(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            if ((element.getName()).Equals("mc:AlternateContent")) {
                return (element.findChildOrEmpty("mc:Fallback")).getChildren();
            } else {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement collapsedElement = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(element.getName(), element.getAttributes(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(element.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml__Anonymous_0()));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(collapsedElement);
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode textNode) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(textNode);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class PathRelativeFileReader : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> _path;
        internal PathRelativeFileReader(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path) {
            this._path = path;
        }
        public Mammoth.Couscous.java.io.InputStream getInputStream(string uri) {
            try {
                Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.net.URI> absoluteUri = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.asAbsoluteUri(uri);
                if (absoluteUri.isPresent()) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.open(absoluteUri.get());
                } else if ((this._path).isPresent()) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.open((((this._path).get()).toUri()).resolve(uri));
                } else {
                    throw new Mammoth.Couscous.java.io.IOException("path of document is unknown, but is required for relative URI");
                }
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                throw new Mammoth.Couscous.java.io.IOException((("could not open external image '" + uri) + "': ") + exception.getMessage());
            }
        }
        public static Mammoth.Couscous.java.io.InputStream open(Mammoth.Couscous.java.net.URI uri) {
            return (uri.toURL()).openStream();
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.net.URI> asAbsoluteUri(string uriString) {
            try {
                Mammoth.Couscous.java.net.URI uri = new Mammoth.Couscous.java.net.URI(uriString);
                return uri.isAbsolute() ? Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.net.URI>(uri) : Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.net.URI>();
            } catch (Mammoth.Couscous.java.net.URISyntaxException exception) {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.net.URI>();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult _EMPTY_SUCCESS;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _elements;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _extra;
        internal Mammoth.Couscous.java.lang.Iterable<string> _warnings;
        static ReadResult() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
        }
        internal ReadResult(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> extra, Mammoth.Couscous.java.lang.Iterable<string> warnings) {
            this._elements = elements;
            this._extra = extra;
            this._warnings = warnings;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult flatMap<T>(Mammoth.Couscous.java.lang.Iterable<T> iterable, Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> function) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> results = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult>(iterable, function);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_0()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_1()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_2()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult map<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult second, Mammoth.Couscous.java.util.function.BiFunction<T, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(function.apply(first.getValue(), second._elements)), second._extra, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first.getWarnings(), second._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(element));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult success(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult emptyWithWarning(string warning) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), warning);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, string warning) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(element), warning);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult withWarning(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, string warning) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(warning));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult map(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(function.apply(this._elements)), this._extra, this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult flatMap(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result = function.apply(this._elements);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(result._elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._extra, result._extra), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(this._warnings, result._warnings));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult toExtra() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._extra, this._elements), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult appendExtra() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._elements, this._extra), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> toResult() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(this._elements, this._warnings);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._elements;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._extra;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<string>> {
        public Mammoth.Couscous.java.lang.Iterable<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._warnings;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationship {
        internal string _relationshipId;
        internal string _target;
        internal string _type;
        internal Relationship(string relationshipId, string target, string type) {
            this._relationshipId = relationshipId;
            this._target = target;
            this._type = type;
        }
        public string getRelationshipId() {
            return this._relationshipId;
        }
        public string getTarget() {
            return this._target;
        }
        public string getType() {
            return this._type;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, string> _targetsByRelationshipId;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.List<string>> _targetsByType;
        static Relationships() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>());
        }
        internal Relationships(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> relationships) {
            this._targetsByRelationshipId = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, string, string>(relationships, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_0());
            this._targetsByType = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMultiMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, string, string>(relationships, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_1());
        }
        public string findTargetByRelationshipId(string relationshipId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._targetsByRelationshipId, relationshipId)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_2(relationshipId));
        }
        public Mammoth.Couscous.java.util.List<string> findTargetsByType(string type) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.List<string>>(this._targetsByType, type)).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship relationship) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(relationship.getRelationshipId(), relationship.getTarget());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship relationship) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(relationship.getType(), relationship.getTarget());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_2 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _relationshipId;
        internal Relationships__Anonymous_2(string relationshipId) {
            this._relationshipId = relationshipId;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Could not find relationship '" + this._relationshipId) + "'");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationshipsXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.findChildren("relationships:Relationship"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml__Anonymous_0()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship readRelationship(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string relationshipId = element.getAttribute("Id");
            string target = element.getAttribute("Target");
            string type = element.getAttribute("Type");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship(relationshipId, target, type);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml.readRelationship(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader {
        internal static Mammoth.Couscous.java.util.Set<string> _IMAGE_TYPES_SUPPORTED_BY_BROWSERS;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _relationships;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal Mammoth.Couscous.java.lang.StringBuilder _currentInstrText;
        internal Mammoth.Couscous.java.util.Queue<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField> _complexFieldStack;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> _deletedParagraphContents;
        static StatefulBodyXmlReader() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.set<string>(new string[] {"image/png", "image/gif", "image/jpeg", "image/svg+xml", "image/tiff"});
        }
        internal StatefulBodyXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._styles = styles;
            this._numbering = numbering;
            this._relationships = relationships;
            this._contentTypes = contentTypes;
            this._file = file;
            this._fileReader = fileReader;
            this._currentInstrText = new Mammoth.Couscous.java.lang.StringBuilder();
            this._complexFieldStack = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Queues.stack<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField>();
            this._deletedParagraphContents = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            switch (element.getName()) {
                case "w:t":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text(element.innerText()));
                case "w:r":
                    return this.readRun(element);
                case "w:p":
                    return this.readParagraph(element);
                case "w:fldChar":
                    return this.readFieldChar(element);
                case "w:instrText":
                    return this.readInstrText(element);
                case "w:tab":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab._TAB);
                case "w:noBreakHyphen":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text("‑"));
                case "w:softHyphen":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text("­"));
                case "w:sym":
                    return this.readSymbol(element);
                case "w:br":
                    return this.readBreak(element);
                case "w:tbl":
                    return this.readTable(element);
                case "w:tr":
                    return this.readTableRow(element);
                case "w:tc":
                    return this.readTableCell(element);
                case "w:hyperlink":
                    return this.readHyperlink(element);
                case "w:bookmarkStart":
                    return this.readBookmark(element);
                case "w:footnoteReference":
                    return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE, element);
                case "w:endnoteReference":
                    return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE, element);
                case "w:commentReference":
                    return this.readCommentReference(element);
                case "w:pict":
                    return this.readPict(element);
                case "v:imagedata":
                    return this.readImagedata(element);
                case "wp:inline":
                case "wp:anchor":
                    return this.readInline(element);
                case "w:sdt":
                    return this.readSdt(element);
                case "w:ins":
                case "w:object":
                case "w:smartTag":
                case "w:drawing":
                case "v:group":
                case "v:rect":
                case "v:roundrect":
                case "v:shape":
                case "v:textbox":
                case "w:txbxContent":
                    return this.readElements(element.getChildren());
                case "office-word:wrap":
                case "v:shadow":
                case "v:shapetype":
                case "w:bookmarkEnd":
                case "w:sectPr":
                case "w:proofErr":
                case "w:lastRenderedPageBreak":
                case "w:commentRangeStart":
                case "w:commentRangeEnd":
                case "w:del":
                case "w:footnoteRef":
                case "w:endnoteRef":
                case "w:annotationRef":
                case "w:pPr":
                case "w:rPr":
                case "w:tblPr":
                case "w:tblGrid":
                case "w:trPr":
                case "w:tcPr":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
                default:
                    string warning = "An unrecognised element was ignored: " + element.getName();
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning(warning);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:rPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readRunStyle(properties), this.readElements(element.getChildren()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_0(this, properties));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField> currentHyperlinkComplexField() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(this._complexFieldStack, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField)));
        }
        public bool isBold(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:b");
        }
        public bool isItalic(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:i");
        }
        public bool isUnderline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return (((properties.findChild("w:u")).flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_1())).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_2())).orElse(false);
        }
        public bool isStrikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:strike");
        }
        public bool isAllCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:caps");
        }
        public bool isSmallCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:smallCaps");
        }
        public bool readBooleanElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string tagName) {
            return ((properties.findChild(tagName)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_4())).orElse(false);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment readVerticalAlignment(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            string verticalAlignment = (this.readVal(properties, "w:vertAlign")).orElse("");
            switch (verticalAlignment) {
                case "superscript":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT;
                case "subscript":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT;
                default:
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._BASELINE;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readRunStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:rStyle", "Run", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_5(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElements(Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(nodes, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_6(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:pPr");
            bool isDeleted = ((properties.findChildOrEmpty("w:rPr")).findChild("w:del")).isPresent();
            if (isDeleted) {
                (this._deletedParagraphContents).addAll(element.getChildren());
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
            } else {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent = this.readParagraphIndent(properties);
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> childrenXml = element.getChildren();
                if (!(this._deletedParagraphContents).isEmpty()) {
                    childrenXml = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(this._deletedParagraphContents, childrenXml);
                    this._deletedParagraphContents = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
                }
                return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readParagraphStyle(properties), this.readElements(childrenXml), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_7(this, properties, indent))).appendExtra();
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readFieldChar(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string type = (element.getAttributeOrNone("w:fldCharType")).orElse("");
            if (type.Equals("begin")) {
                (this._complexFieldStack).add(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (this._currentInstrText).setLength(0);
            } else if (type.Equals("end")) {
                (this._complexFieldStack).remove();
            } else if (type.Equals("separate")) {
                string instrText = (this._currentInstrText).toString();
                Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField complexField = ((this.parseHyperlinkFieldCode(instrText)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_8())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (this._complexFieldStack).remove();
                (this._complexFieldStack).add(complexField);
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInstrText(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            (this._currentInstrText).append(element.innerText());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink>> parseHyperlinkFieldCode(string instrText) {
            Mammoth.Couscous.java.util.regex.Pattern externalLinkPattern = Mammoth.Couscous.java.util.regex.Pattern.compile("\\s*HYPERLINK \"(.*)\"");
            Mammoth.Couscous.java.util.regex.Matcher externalLinkMatcher = externalLinkPattern.matcher(instrText);
            if (externalLinkMatcher.lookingAt()) {
                string href = externalLinkMatcher.group(1);
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_9(href));
            }
            Mammoth.Couscous.java.util.regex.Pattern internalLinkPattern = Mammoth.Couscous.java.util.regex.Pattern.compile("\\s*HYPERLINK\\s+\\\\l\\s+\"(.*)\"");
            Mammoth.Couscous.java.util.regex.Matcher internalLinkMatcher = internalLinkPattern.matcher(instrText);
            if (internalLinkMatcher.lookingAt()) {
                string anchor = internalLinkMatcher.group(1);
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_10(anchor));
            }
            return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink>>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readParagraphStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:pStyle", "Paragraph", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_11(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string styleTagName, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            return ((this.readVal(properties, styleTagName)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_12(this, styleType, findStyleById))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.empty());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById(string styleType, string styleId, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style = findStyleById.apply(styleId);
            if (style.isPresent()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(style);
            } else {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, Mammoth.Couscous.java.util.Optional.empty<string>())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(((styleType + " style with ID ") + styleId) + " was referenced but not defined in the document"));
            }
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readNumbering(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike numberingProperties = properties.findChildOrEmpty("w:numPr");
            Mammoth.Couscous.java.util.Optional<string> numId = this.readVal(numberingProperties, "w:numId");
            Mammoth.Couscous.java.util.Optional<string> levelIndex = this.readVal(numberingProperties, "w:ilvl");
            if (numId.isPresent() && levelIndex.isPresent()) {
                return (this._numbering).findLevel(numId.get(), levelIndex.get());
            }
            if (style.isPresent()) {
                string styleId = (style.get()).getStyleId();
                Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> level = (this._numbering).findLevelByParagraphStyleId(styleId);
                if (level.isPresent()) {
                    return level;
                }
            }
            return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent readParagraphIndent(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike indent = properties.findChildOrEmpty("w:ind");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>(indent.getAttributeOrNone("w:start"), indent.getAttributeOrNone("w:left")), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>(indent.getAttributeOrNone("w:end"), indent.getAttributeOrNone("w:right")), indent.getAttributeOrNone("w:firstLine"), indent.getAttributeOrNone("w:hanging"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readSymbol(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> font = element.getAttributeOrNone("w:font");
            Mammoth.Couscous.java.util.Optional<string> charValue = element.getAttributeOrNone("w:char");
            if (font.isPresent() && charValue.isPresent()) {
                Mammoth.Couscous.java.util.Optional<int> dingbat = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats.findDingbat(font.get(), int.Parse(charValue.get()));
                if (!dingbat.isPresent() && Mammoth.Couscous.java.util.regex.Pattern.matches("F0..", charValue.get())) {
                    dingbat = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Dingbats.findDingbat(font.get(), int.Parse((charValue.get()).Substring(2)));
                }
                if (dingbat.isPresent()) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.codepointToString(dingbat.get())));
                }
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning((("A w:sym element with an unsupported character was ignored: char " + charValue.orElse("null")) + " in font ") + font.orElse("null"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string breakType = (element.getAttributeOrNone("w:type")).orElse("textWrapping");
            switch (breakType) {
                case "textWrapping":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._LINE_BREAK);
                case "page":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._PAGE_BREAK);
                case "column":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._COLUMN_BREAK);
                default:
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("Unsupported break type: " + breakType);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTable(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:tblPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readTableStyle(properties), (this.readElements(element.getChildren())).flatMap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_13(this)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_14());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readTableStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:tblStyle", "Table", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_15(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult calculateRowspans(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> rows) {
            Mammoth.Couscous.java.util.Optional<string> error = this.checkTableRows(rows);
            if (error.isPresent()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(rows, error.get());
            }
            Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> rowspans = new Mammoth.Couscous.java.util.HashMap<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>();
            Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> merged = new Mammoth.Couscous.java.util.HashSet<Mammoth.Couscous.java.util.Map__Entry<int, int>>();
            Mammoth.Couscous.java.util.Map<int, Mammoth.Couscous.java.util.Map__Entry<int, int>> lastCellForColumn = new Mammoth.Couscous.java.util.HashMap<int, Mammoth.Couscous.java.util.Map__Entry<int, int>>();
             {
                int rowIndex = 0;
                while (rowIndex < rows.size()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow row = (Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow) rows.get(rowIndex);
                    int columnIndex = 0;
                     {
                        int cellIndex = 0;
                        while (cellIndex < (row.getChildren()).size()) {
                            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell cell = (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.util.Map__Entry<int, int>> spanningCell = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<int, Mammoth.Couscous.java.util.Map__Entry<int, int>>(lastCellForColumn, columnIndex);
                            Mammoth.Couscous.java.util.Map__Entry<int, int> position = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<int, int>(rowIndex, cellIndex);
                            if (cell._vmerge && spanningCell.isPresent()) {
                                rowspans.put(spanningCell.get(), (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>(rowspans, spanningCell.get())).get() + 1);
                                merged.add(position);
                            } else {
                                lastCellForColumn.put(columnIndex, position);
                                rowspans.put(position, 1);
                            }
                            columnIndex = columnIndex + cell._colspan;
                            cellIndex = cellIndex + 1;
                        }
                    }
                    rowIndex = rowIndex + 1;
                }
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMapWithIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(rows, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_16(merged, rowspans)));
        }
        public Mammoth.Couscous.java.util.Optional<string> checkTableRows(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> rows) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for2 = rows.iterator();
                while (_couscous_desugar_foreach_to_for2.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement rowElement = _couscous_desugar_foreach_to_for2.next();
                    Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow> row = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow), rowElement);
                    if (!row.isPresent()) {
                        return Mammoth.Couscous.java.util.Optional.of<string>("unexpected non-row element in table, cell merging may be incorrect");
                    } else {
                         {
                            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for1 = ((row.get()).getChildren()).iterator();
                            while (_couscous_desugar_foreach_to_for1.hasNext()) {
                                Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement cell = _couscous_desugar_foreach_to_for1.next();
                                if (!(cell is Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell)) {
                                    return Mammoth.Couscous.java.util.Optional.of<string>("unexpected non-cell element in table row, cell merging may be incorrect");
                                }
                            }
                        }
                    }
                }
            }
            return Mammoth.Couscous.java.util.Optional.empty<string>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTableRow(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:trPr");
            bool isHeader = properties.hasChild("w:tblHeader");
            return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_17(isHeader));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTableCell(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:tcPr");
            Mammoth.Couscous.java.util.Optional<string> gridSpan = (properties.findChildOrEmpty("w:gridSpan")).getAttributeOrNone("w:val");
            int colspan = (gridSpan.map<int>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_18())).orElse(1);
            return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_19(this, properties, colspan));
        }
        public bool readVmerge(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return ((properties.findChild("w:vMerge")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_21())).orElse(false);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readHyperlink(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> relationshipId = element.getAttributeOrNone("r:id");
            Mammoth.Couscous.java.util.Optional<string> anchor = element.getAttributeOrNone("w:anchor");
            Mammoth.Couscous.java.util.Optional<string> targetFrame = (element.getAttributeOrNone("w:tgtFrame")).filter(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_22());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult childrenResult = this.readElements(element.getChildren());
            if (relationshipId.isPresent()) {
                string targetHref = (this._relationships).findTargetByRelationshipId(relationshipId.get());
                string href = (anchor.map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_23(targetHref, anchor))).orElse(targetHref);
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_24(href, targetFrame));
            } else if (anchor.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_25(anchor, targetFrame));
            } else {
                return childrenResult;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBookmark(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string name = element.getAttribute("w:name");
            if (name.Equals("_GoBack")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark(name));
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string noteId = element.getAttribute("w:id");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(noteType, noteId));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readCommentReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string commentId = element.getAttribute("w:id");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference(commentId));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readPict(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (this.readElements(element.getChildren())).toExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImagedata(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("r:id")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_27(element, this))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("A v:imagedata element without a relationship ID was ignored"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("wp:docPr");
            Mammoth.Couscous.java.util.Optional<string> altText = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>((properties.getAttributeOrNone("descr")).filter(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_28()), properties.getAttributeOrNone("title"));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips = ((((element.findChildren("a:graphic")).findChildren("a:graphicData")).findChildren("pic:pic")).findChildren("pic:blipFill")).findChildren("a:blip");
            return this.readBlips(blips, altText);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlips(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips, Mammoth.Couscous.java.util.Optional<string> altText) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(blips, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_29(this, altText));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlip(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip, Mammoth.Couscous.java.util.Optional<string> altText) {
            Mammoth.Couscous.java.util.Optional<string> embedRelationshipId = blip.getAttributeOrNone("r:embed");
            Mammoth.Couscous.java.util.Optional<string> linkRelationshipId = blip.getAttributeOrNone("r:link");
            if (embedRelationshipId.isPresent()) {
                string imagePath = this.relationshipIdToDocxPath(embedRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_30(this, imagePath));
            } else if (linkRelationshipId.isPresent()) {
                string imagePath = (this._relationships).findTargetByRelationshipId(linkRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_31(this, imagePath));
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("Could not find image file for a:blip element");
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImage(string imagePath, Mammoth.Couscous.java.util.Optional<string> altText, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier open) {
            Mammoth.Couscous.java.util.Optional<string> contentType = (this._contentTypes).findContentType(imagePath);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image(altText, contentType, open);
            string contentTypeString = contentType.orElse("(unknown)");
            if ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS).contains(contentTypeString)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(image);
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(image, ("Image of type " + contentTypeString) + " is unlikely to display in web browsers");
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readSdt(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return this.readElements((element.findChildOrEmpty("w:sdtContent")).getChildren());
        }
        public string relationshipIdToDocxPath(string relationshipId) {
            string target = (this._relationships).findTargetByRelationshipId(relationshipId);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Uris.uriToZipEntryName("word", target);
        }
        public Mammoth.Couscous.java.util.Optional<string> readVal(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike element, string name) {
            return (element.findChildOrEmpty(name)).getAttributeOrNone("w:val");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__ComplexField_static {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField _UNKNOWN;
        static StatefulBodyXmlReader__ComplexField_static() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_32();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField hyperlink(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> childrenToHyperlink) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField(childrenToHyperlink);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface StatefulBodyXmlReader__ComplexField {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__HyperlinkComplexField : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField {
        internal Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> _childrenToHyperlink;
        internal StatefulBodyXmlReader__HyperlinkComplexField(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> childrenToHyperlink) {
            this._childrenToHyperlink = childrenToHyperlink;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__UnmergedTableCell : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal bool _vmerge;
        internal int _colspan;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal StatefulBodyXmlReader__UnmergedTableCell(bool vmerge, int colspan, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._vmerge = vmerge;
            this._colspan = colspan;
            this._children = children;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell(1, this._colspan, this._children), context);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal StatefulBodyXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField> hyperlinkComplexField = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).currentHyperlinkComplexField();
            if (hyperlinkComplexField.isPresent()) {
                children = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(((hyperlinkComplexField.get())._childrenToHyperlink).apply(children));
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isBold(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isItalic(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isUnderline(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isStrikethrough(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isAllCaps(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isSmallCaps(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVerticalAlignment(this._properties), style, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Optional<string>> {
        public Mammoth.Couscous.java.util.Optional<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return child.getAttributeOrNone("w:val");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        public bool apply(string value) {
            return (!(value.Equals("false")) && !(value.Equals("0"))) && !(value.Equals("none"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        public bool apply(string value) {
            return !(value.Equals("false")) && !(value.Equals("0"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return ((child.getAttributeOrNone("w:val")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_3())).orElse(true);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_5 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._styles).findCharacterStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_7 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent _indent;
        internal StatefulBodyXmlReader__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
            this._indent = indent;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph(style, (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readNumbering(style, this._properties), this._indent, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_8 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink>, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField apply(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> href) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static.hyperlink(href);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> {
        internal string _href;
        internal StatefulBodyXmlReader__Anonymous_9(string href) {
            this._href = href;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href(this._href, Mammoth.Couscous.java.util.Optional.empty<string>(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_10 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink> {
        internal string _anchor;
        internal StatefulBodyXmlReader__Anonymous_10(string anchor) {
            this._anchor = anchor;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.anchor(this._anchor, Mammoth.Couscous.java.util.Optional.empty<string>(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_11 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._styles).findParagraphStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_12 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _styleType;
        internal Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> _findStyleById;
        internal StatefulBodyXmlReader__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._styleType = styleType;
            this._findStyleById = findStyleById;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> apply(string styleId) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).findStyleById(this._styleType, styleId, this._findStyleById);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_13(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).calculateRowspans(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_14 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> arg0, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg1) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_15 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_15(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._styles).findTableStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_16 : Mammoth.Couscous.java.util.function.BiFunction<int, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> _merged;
        internal Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> _rowspans;
        internal StatefulBodyXmlReader__Anonymous_16(Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> merged, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> rowspans) {
            this._merged = merged;
            this._rowspans = rowspans;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(int rowIndex, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement rowElement) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow row = (Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow) rowElement;
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> mergedCells = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>();
             {
                int cellIndex = 0;
                while (cellIndex < (row.getChildren()).size()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell cell = (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                    Mammoth.Couscous.java.util.Map__Entry<int, int> position = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<int, int>(rowIndex, cellIndex);
                    if (!(this._merged).contains(position)) {
                        mergedCells.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>(this._rowspans, position)).get(), cell._colspan, cell._children));
                    }
                    cellIndex = cellIndex + 1;
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(mergedCells, row.isHeader());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_17 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal bool _isHeader;
        internal StatefulBodyXmlReader__Anonymous_17(bool isHeader) {
            this._isHeader = isHeader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(children, this._isHeader);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_18 : Mammoth.Couscous.java.util.function.Function<string, int> {
        public int apply(string arg0) {
            return int.Parse(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_19 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal int _colspan;
        internal StatefulBodyXmlReader__Anonymous_19(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, int colspan) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
            this._colspan = colspan;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVmerge(this._properties), this._colspan, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_20 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        public bool apply(string val) {
            return val.Equals("continue");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_21 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:val")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_20())).orElse(true);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_22 : Mammoth.Couscous.java.util.function.Predicate<string> {
        public bool test(string value) {
            return !value.isEmpty();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_23 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _targetHref;
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal StatefulBodyXmlReader__Anonymous_23(string targetHref, Mammoth.Couscous.java.util.Optional<string> anchor) {
            this._targetHref = targetHref;
            this._anchor = anchor;
        }
        public string apply(string fragment) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Uris.replaceFragment(this._targetHref, (this._anchor).get());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_24 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal string _href;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal StatefulBodyXmlReader__Anonymous_24(string href, Mammoth.Couscous.java.util.Optional<string> targetFrame) {
            this._href = href;
            this._targetFrame = targetFrame;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href(this._href, this._targetFrame, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_25 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal StatefulBodyXmlReader__Anonymous_25(Mammoth.Couscous.java.util.Optional<string> anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame) {
            this._anchor = anchor;
            this._targetFrame = targetFrame;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.anchor((this._anchor).get(), this._targetFrame, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_26 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_26(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_27 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_27(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._element = element;
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(string relationshipId) {
            Mammoth.Couscous.java.util.Optional<string> title = (this._element).getAttributeOrNone("o:title");
            string imagePath = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).relationshipIdToDocxPath(relationshipId);
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readImage(imagePath, title, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_26(this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, imagePath));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_28 : Mammoth.Couscous.java.util.function.Predicate<string> {
        public bool test(string description) {
            return !(description.trim()).isEmpty();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_29 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal StatefulBodyXmlReader__Anonymous_29(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.java.util.Optional<string> altText) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._altText = altText;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readBlip(blip, this._altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_30 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_30(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_31 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_31(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._fileReader).getInputStream(this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_32 : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _paragraphStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _characterStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _tableStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> _numberingStyles;
        static Styles() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>());
        }
        internal Styles(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> paragraphStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> characterStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> tableStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> numberingStyles) {
            this._paragraphStyles = paragraphStyles;
            this._characterStyles = characterStyles;
            this._tableStyles = tableStyles;
            this._numberingStyles = numberingStyles;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findParagraphStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._paragraphStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findCharacterStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._characterStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findTableStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._tableStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> findNumberingStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>(this._numberingStyles, id);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStylesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements = element.findChildren("w:style");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "paragraph"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "character"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "table"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readNumberingStyles(styleElements));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements, string styleType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.styleElementsOfType(styleElements, styleType), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyleId(element);
            Mammoth.Couscous.java.util.Optional<string> styleName = (element.findChildOrEmpty("w:name")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(styleId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, styleName));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> readNumberingStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.styleElementsOfType(styleElements, "numbering"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> readNumberingStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyleId(element);
            Mammoth.Couscous.java.util.Optional<string> numId = (((element.findChildOrEmpty("w:pPr")).findChildOrEmpty("w:numPr")).findChildOrEmpty("w:numId")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>(styleId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle(numId));
        }
        public static string readStyleId(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return element.getAttribute("w:styleId");
        }
        public static Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> styleElementsOfType(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements, string styleType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(styleElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_2(styleType));
        }
        public static bool isStyleType(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement styleElement, string styleType) {
            return (styleElement.getAttribute("w:type")).Equals(styleType);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyle(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingStyle> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readNumberingStyle(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _styleType;
        internal StylesXml__Anonymous_2(string styleType) {
            this._styleType = styleType;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement styleElement) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.isStyleType(styleElement, this._styleType);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Uris {
        public static string uriToZipEntryName(string @base, string uri) {
            if (uri.startsWith("/")) {
                return uri.Substring(1);
            } else {
                return (@base + "/") + uri;
            }
        }
        public static string replaceFragment(string uri, string fragment) {
            int hashIndex = uri.indexOf("#");
            if (hashIndex != -1) {
                uri = (uri.Substring(0, hashIndex - 0));
            }
            return (uri + "#") + fragment;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode _FORCE_WRITE;
        static Html() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite._FORCE_WRITE;
        }
        public static string write(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.lang.StringBuilder builder = new Mammoth.Couscous.java.lang.StringBuilder();
            nodes.forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_0(builder));
            return builder.toString();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode text(string value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode(value);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, false, ""), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(tagNames, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, true, ""), children);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_2());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for3 = nodes.iterator();
                while (_couscous_desugar_foreach_to_for3.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node = _couscous_desugar_foreach_to_for3.next();
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(collapsed, node);
                }
            }
            return collapsed;
        }
        public static void collapsingAdd(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapsedNode = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(node);
            if (!Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.tryCollapse(collapsed, collapsedNode)) {
                collapsed.add(collapsedNode);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode collapse(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return node.accept<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_3());
        }
        public static bool tryCollapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.map<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool>((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(collapsed)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_4()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement), node), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html__Anonymous_5())).orElse(false);
        }
        public static bool isMatch(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement first, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement second) {
            return (second.getTagNames()).contains(first.getTagName()) && (first.getAttributes()).equals(second.getAttributes());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal Html__Anonymous_0(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(node, this._builder);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_2 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(element.getChildren());
            if (children.isEmpty() && !element.isVoid()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTag(), children));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            if ((node.getValue()).isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(node);
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(forceWrite);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_3 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTag(), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(element.getChildren()));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            return node;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
            return forceWrite;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>> {
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode last) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement), last);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_5 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement last, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement next) {
            if (next.isCollapsible() && Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.isMatch(last, next)) {
                string separator = next.getSeparator();
                if (!separator.isEmpty()) {
                    (last.getChildren()).add(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(separator));
                }
                 {
                    Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for4 = (next.getChildren()).iterator();
                    while (_couscous_desugar_foreach_to_for4.hasNext()) {
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child = _couscous_desugar_foreach_to_for4.next();
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(last.getChildren(), child);
                    }
                }
                return true;
            } else {
                return false;
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag _tag;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _children;
        internal static Mammoth.Couscous.java.util.Set<string> _VOID_TAG_NAMES;
        static HtmlElement() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement._VOID_TAG_NAMES = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.set<string>(new string[] {"img", "br", "hr"});
        }
        internal HtmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children) {
            this._tag = tag;
            this._children = children;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag getTag() {
            return this._tag;
        }
        public Mammoth.Couscous.java.util.List<string> getTagNames() {
            return (this._tag).getTagNames();
        }
        public string getTagName() {
            return (this.getTagNames()).get(0);
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return (this._tag).getAttributes();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> getChildren() {
            return this._children;
        }
        public bool isCollapsible() {
            return (this._tag).isCollapsible();
        }
        public string getSeparator() {
            return (this._tag).getSeparator();
        }
        public bool isVoid() {
            return (this._children).isEmpty() && Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement.isVoidTag(this.getTagName());
        }
        public static bool isVoidTag(string tagName) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement._VOID_TAG_NAMES).contains(tagName);
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlForceWrite : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite _FORCE_WRITE;
        static HtmlForceWrite() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite._FORCE_WRITE = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite();
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode {
        void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor);
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode__Visitor {
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element);
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node);
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode__Mapper<T> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTag {
        internal Mammoth.Couscous.java.util.List<string> _tagNames;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal bool _isCollapsible;
        internal string _separator;
        internal HtmlTag(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, bool isCollapsible, string separator) {
            this._tagNames = tagNames;
            this._attributes = attributes;
            this._isCollapsible = isCollapsible;
            this._separator = separator;
        }
        public Mammoth.Couscous.java.util.List<string> getTagNames() {
            return this._tagNames;
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
        }
        public bool isCollapsible() {
            return this._isCollapsible;
        }
        public string getSeparator() {
            return this._separator;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTextNode : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal string _value;
        internal HtmlTextNode(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter {
        public static void write(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node, Mammoth.Couscous.java.lang.StringBuilder builder) {
            node.accept(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_1(builder));
        }
        public static void generateAttributes(Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.lang.StringBuilder builder) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.java.util.Map__Entry<string, string>> _couscous_desugar_foreach_to_for5 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.orderedBy<Mammoth.Couscous.java.util.Map__Entry<string, string>, string>(attributes.entrySet(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_2())).iterator();
                while (_couscous_desugar_foreach_to_for5.hasNext()) {
                    Mammoth.Couscous.java.util.Map__Entry<string, string> attribute = _couscous_desugar_foreach_to_for5.next();
                    ((((builder.append(" ")).append(attribute.getKey())).append("=\"")).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeAttributeValue(attribute.getValue()))).append("\"");
                }
            }
        }
        public static string escapeText(string text) {
            return ((text.replace("&", "&amp;")).replace("<", "&lt;")).replace(">", "&gt;");
        }
        public static string escapeAttributeValue(string value) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeText(value)).replace("\"", "&quot;");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter__Anonymous_0(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(child, this._builder);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter__Anonymous_1(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            ((this._builder).append("<")).append(element.getTagName());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.generateAttributes(element.getAttributes(), this._builder);
            if (element.isVoid()) {
                (this._builder).append(" />");
            } else {
                (this._builder).append(">");
                (element.getChildren()).forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_0(this._builder));
                (((this._builder).append("</")).append(element.getTagName())).append(">");
            }
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            (this._builder).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeText(node.getValue()));
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map__Entry<string, string>, string> {
        public string apply(Mammoth.Couscous.java.util.Map__Entry<string, string> arg0) {
            return arg0.getKey();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>> flatMap<T, R>(Mammoth.Couscous.java.lang.Iterable<T> iterable, Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> results = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>>(iterable, function);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, R>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_0<R>()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_1<R>()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> flatMap<T1, T2, R>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T1> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> intermediateResult = function.apply(first._value, second._value);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(intermediateResult._value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first._warnings, second._warnings), intermediateResult._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> map<T1, T2, R>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T1> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, R> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(function.apply(first._value, second._value), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first._warnings, second._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> empty() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> success<T>(T value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T>(value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult<T> {
        internal T _value;
        internal Mammoth.Couscous.java.lang.Iterable<string> _warnings;
        internal InternalResult(T value, Mammoth.Couscous.java.lang.Iterable<string> warnings) {
            this._value = value;
            this._warnings = warnings;
        }
        public T getValue() {
            return this._value;
        }
        public Mammoth.Couscous.java.lang.Iterable<string> getWarnings() {
            return this._warnings;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> map<R>(Mammoth.Couscous.java.util.function.Function<T, R> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(function.apply(this._value), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> flatMap<R>(Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> intermediateResult = function.apply(this._value);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>(intermediateResult._value, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(this._warnings, intermediateResult._warnings));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.Result<T> toResult() {
            Mammoth.Couscous.java.util.Set<string> warnings = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.toSet<string>(this._warnings);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult__Anonymous_2<T>(this, warnings);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_0 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_0<R> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, R> {
        public R apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> result) {
            return result._value;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_1 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_1<R> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, Mammoth.Couscous.java.lang.Iterable<string>> {
        public Mammoth.Couscous.java.lang.Iterable<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> result) {
            return result._warnings;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult__Anonymous_2 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult__Anonymous_2<T> : Mammoth.Couscous.org.zwobble.mammoth.Result<T> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> _this_org__zwobble__mammoth__internal__results__InternalResult;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal InternalResult__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> this_org__zwobble__mammoth__internal__results__InternalResult, Mammoth.Couscous.java.util.Set<string> warnings) {
            this._this_org__zwobble__mammoth__internal__results__InternalResult = this_org__zwobble__mammoth__internal__results__InternalResult;
            this._warnings = warnings;
        }
        public T getValue() {
            return (this._this_org__zwobble__mammoth__internal__results__InternalResult)._value;
        }
        public Mammoth.Couscous.java.util.Set<string> getWarnings() {
            return this._warnings;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class BreakMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _LINE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _PAGE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _COLUMN_BREAK;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type _breakType;
        static BreakMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._LINE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._PAGE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._PAGE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._COLUMN_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._COLUMN);
        }
        internal BreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type breakType) {
            this._breakType = breakType;
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break element) {
            return (element.getType()).equals(this._breakType);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DefaultStyles {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _DEFAULT_STYLE_MAP;
        static DefaultStyles() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMappings(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(new string[] {"p.Heading1 => h1:fresh", "p.Heading2 => h2:fresh", "p.Heading3 => h3:fresh", "p.Heading4 => h4:fresh", "p.Heading5 => h5:fresh", "p.Heading6 => h6:fresh", "p[style-name='Heading 1'] => h1:fresh", "p[style-name='Heading 2'] => h2:fresh", "p[style-name='Heading 3'] => h3:fresh", "p[style-name='Heading 4'] => h4:fresh", "p[style-name='Heading 5'] => h5:fresh", "p[style-name='Heading 6'] => h6:fresh", "p[style-name='heading 1'] => h1:fresh", "p[style-name='heading 2'] => h2:fresh", "p[style-name='heading 3'] => h3:fresh", "p[style-name='heading 4'] => h4:fresh", "p[style-name='heading 5'] => h5:fresh", "p[style-name='heading 6'] => h6:fresh", "r[style-name='Strong'] => strong", "p[style-name='footnote text'] => p:fresh", "r[style-name='footnote reference'] =>", "p[style-name='endnote text'] => p:fresh", "r[style-name='endnote reference'] =>", "p[style-name='annotation text'] => p:fresh", "r[style-name='annotation reference'] =>", "p[style-name='Footnote'] => p:fresh", "r[style-name='Footnote anchor'] =>", "p[style-name='Endnote'] => p:fresh", "r[style-name='Endnote anchor'] =>", "p:unordered-list(1) => ul > li:fresh", "p:unordered-list(2) => ul|ol > li > ul > li:fresh", "p:unordered-list(3) => ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:ordered-list(1) => ol > li:fresh", "p:ordered-list(2) => ul|ol > li > ol > li:fresh", "p:ordered-list(3) => ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "r[style-name='Hyperlink'] =>", "p[style-name='Normal'] => p:fresh"}));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface DocumentElementMatcher<T> {
        bool matches(T element);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching {
        public static bool matchesStyle(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleId(styleId, style) && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleName(styleName, style);
        }
        public static bool matchesStyleId(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<string, string>(styleId, style.map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_0()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_1());
        }
        public static bool matchesStyleName(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher, string>(styleName, style.flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_2()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_3());
        }
        public static bool matches<T, U>(Mammoth.Couscous.java.util.Optional<T> required, Mammoth.Couscous.java.util.Optional<U> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual) {
            return (required.map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_5<T, U>(actual, areEqual))).orElse(true);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style arg0) {
            return arg0.getStyleId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_1 : Mammoth.Couscous.java.util.function.BiPredicate<string, string> {
        public bool test(string arg0, string arg1) {
            return arg0.Equals(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style, Mammoth.Couscous.java.util.Optional<string>> {
        public Mammoth.Couscous.java.util.Optional<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style arg0) {
            return arg0.getName();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_3 : Mammoth.Couscous.java.util.function.BiPredicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher, string> {
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher arg0, string arg1) {
            return arg0.matches(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_4 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_4<U, T> : Mammoth.Couscous.java.util.function.Function<U, bool> {
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, U> _areEqual;
        internal T _requiredValue;
        internal DocumentElementMatching__Anonymous_4(Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual, T requiredValue) {
            this._areEqual = areEqual;
            this._requiredValue = requiredValue;
        }
        public bool apply(U actualValue) {
            return (this._areEqual).test(this._requiredValue, actualValue);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching__Anonymous_5 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching__Anonymous_5<T, U> : Mammoth.Couscous.java.util.function.Function<T, bool> {
        internal Mammoth.Couscous.java.util.Optional<U> _actual;
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, U> _areEqual;
        internal DocumentElementMatching__Anonymous_5(Mammoth.Couscous.java.util.Optional<U> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, U> areEqual) {
            this._actual = actual;
            this._areEqual = areEqual;
        }
        public bool apply(T requiredValue) {
            return ((this._actual).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching__Anonymous_4<U, T>(this._areEqual, requiredValue))).orElse(false);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class EqualToStringMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher {
        internal string _value;
        internal EqualToStringMatcher(string value) {
            this._value = value;
        }
        public bool matches(string value) {
            return (this._value).equalsIgnoreCase(value);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPath_static {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _EMPTY;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _IGNORE;
        static HtmlPath_static() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.Ignore._INSTANCE;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath elements(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement[] elements) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.java.util.Arrays.asList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(elements));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, false, "");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tag)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(tagNames, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, true, "");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tag)));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface HtmlPath {
        Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag _tag;
        internal HtmlPathElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag) {
            this._tag = tag;
        }
        public Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement__Anonymous_0(this, generateNodes);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> wrapNodes(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(this._tag, nodes));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement _this_org__zwobble__mammoth__internal__styles__HtmlPathElement;
        internal Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> _generateNodes;
        internal HtmlPathElement__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement this_org__zwobble__mammoth__internal__styles__HtmlPathElement, Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
            this._this_org__zwobble__mammoth__internal__styles__HtmlPathElement = this_org__zwobble__mammoth__internal__styles__HtmlPathElement;
            this._generateNodes = generateNodes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__styles__HtmlPathElement).wrapNodes((this._generateNodes).get());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElements : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _elements;
        internal HtmlPathElements(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements) {
            this._elements = elements;
        }
        public Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _couscous_desugar_foreach_to_for6 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.reversed<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(this._elements)).iterator();
                while (_couscous_desugar_foreach_to_for6.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = _couscous_desugar_foreach_to_for6.next();
                    generateNodes = element.wrap(generateNodes);
                }
            }
            return generateNodes;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class Ignore : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _INSTANCE;
        static Ignore() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.Ignore._INSTANCE = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.Ignore();
        }
        public Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> wrap(Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> generateNodes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.Ignore__Anonymous_0();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class Ignore__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> _styleName;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        static ParagraphMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        internal ParagraphMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering) {
            this._styleId = styleId;
            this._styleName = styleName;
            this._numbering = numbering;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleName(string styleName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher.styleName(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(styleName));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(styleName), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher orderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.ordered(level)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher unorderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.unordered(level)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return this.matchesStyle(paragraph) && this.matchesNumbering(paragraph);
        }
        public bool matchesStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, paragraph.getStyle());
        }
        public bool matchesNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this._numbering, paragraph.getNumbering(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher__Anonymous_0());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher__Anonymous_0 : Mammoth.Couscous.java.util.function.BiPredicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> {
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel first, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel second) {
            return first.isOrdered() == second.isOrdered() && (first.getLevelIndex()).equalsIgnoreCase(second.getLevelIndex());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> _styleName;
        static RunMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        internal RunMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName) {
            this._styleId = styleId;
            this._styleName = styleName;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleName(string styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(styleName)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, run.getStyle());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StartsWithStringMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher {
        internal string _prefix;
        internal StartsWithStringMatcher(string prefix) {
            this._prefix = prefix;
        }
        public bool matches(string value) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.startsWithIgnoreCase(value, this._prefix);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface StringMatcher {
        bool matches(string value);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _EMPTY;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _allCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _smallCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> _tableStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        static StyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY = (new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder()).build();
        }
        internal StyleMap(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> bold, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> italic, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> underline, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> strikethrough, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> allCaps, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> smallCaps, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> commentReference, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> paragraphStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> runStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> tableStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> breakStyles) {
            this._bold = bold;
            this._italic = italic;
            this._underline = underline;
            this._strikethrough = strikethrough;
            this._allCaps = allCaps;
            this._smallCaps = smallCaps;
            this._commentReference = commentReference;
            this._paragraphStyles = paragraphStyles;
            this._runStyles = runStyles;
            this._tableStyles = tableStyles;
            this._breakStyles = breakStyles;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap merge(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap high, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap low) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._bold, low._bold), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._italic, low._italic), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._underline, low._underline), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._strikethrough, low._strikethrough), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._allCaps, low._allCaps), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._smallCaps, low._smallCaps), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._commentReference, low._commentReference), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(high._paragraphStyles, low._paragraphStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(high._runStyles, low._runStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>(high._tableStyles, low._tableStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(high._breakStyles, low._breakStyles));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap update(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap.merge(styleMap, this);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getBold() {
            return this._bold;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getItalic() {
            return this._italic;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getUnderline() {
            return this._underline;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getStrikethrough() {
            return this._strikethrough;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getAllCaps() {
            return this._allCaps;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getSmallCaps() {
            return this._smallCaps;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getCommentReference() {
            return this._commentReference;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getParagraphHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(this._paragraphStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_0(paragraph))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_1());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getRunHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(this._runStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_2(run))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_3());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getTableHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>(this._tableStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_4(table))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_5());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getBreakHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(this._breakStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_6(breakElement))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_7());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal StyleMap__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            this._paragraph = paragraph;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> styleMapping) {
            return styleMapping.matches(this._paragraph);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal StyleMap__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            this._run = run;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> styleMapping) {
            return styleMapping.matches(this._run);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_4 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table _table;
        internal StyleMap__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            this._table = table;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table> styleMapping) {
            return styleMapping.matches(this._table);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_5 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_6 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _breakElement;
        internal StyleMap__Anonymous_6(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            this._breakElement = breakElement;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> styleMapping) {
            return styleMapping.matches(this._breakElement);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_7 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _allCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _smallCaps;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>> _tableStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        internal StyleMapBuilder() {
            this._paragraphStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>();
            this._runStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>();
            this._tableStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>>();
            this._breakStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>();
            this._bold = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._underline = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._strikethrough = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._allCaps = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._smallCaps = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._italic = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._commentReference = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder bold(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._bold = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder italic(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._italic = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder underline(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._underline = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder strikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._strikethrough = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder allCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._allCaps = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder smallCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._smallCaps = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder commentReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            this._commentReference = Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(path);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._paragraphStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._runStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapTable(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._tableStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._breakStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(this._bold, this._italic, this._underline, this._strikethrough, this._allCaps, this._smallCaps, this._commentReference, this._paragraphStyles, this._runStyles, this._tableStyles, this._breakStyles);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class StyleMapping {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapping<T> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<T> _matcher;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _htmlPath;
        internal StyleMapping(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<T> matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath) {
            this._matcher = matcher;
            this._htmlPath = htmlPath;
        }
        public bool matches(T element) {
            return (this._matcher).matches(element);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath getHtmlPath() {
            return this._htmlPath;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class TableMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> _styleName;
        static TableMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        internal TableMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName) {
            this._styleId = styleId;
            this._styleName = styleName;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher styleName(string styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(styleName)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, table.getStyle());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser {
        public static Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> identifier = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            switch (identifier.getValue()) {
                case "p":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseParagraphMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_0(paragraph);
                case "r":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseRunMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_1(run);
                case "table":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher table = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseTableMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_2(table);
                case "b":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_3();
                case "i":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_4();
                case "u":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_5();
                case "strike":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_6();
                case "all-caps":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_7();
                case "small-caps":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_8();
                case "comment-reference":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_9();
                case "br":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseBreakMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_10(breakMatcher);
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(identifier, "Unrecognised document element: " + identifier);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher parseParagraphMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseNumbering(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(styleId, styleName, numbering);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher parseRunMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(styleId, styleName);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher parseTableMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher(styleId, styleName);
        }
        public static Mammoth.Couscous.java.util.Optional<string> parseStyleId(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseClassName(tokens);
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> parseStyleName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[")) {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "style-name");
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher stringMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStringMatcher(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "]");
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(stringMatcher);
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>();
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher parseStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens));
            } else if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "^=")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StartsWithStringMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens));
            } else {
                throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(tokens.next(), "Expected string matcher but got token " + (tokens.next()).getValue());
            }
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> parseNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":")) {
                bool isOrdered = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseListType(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "(");
                string level = ((new Mammoth.Couscous.java.math.BigInteger(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER))).subtract(Mammoth.Couscous.java.math.BigInteger._ONE)).toString();
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ")");
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(level, isOrdered));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>();
            }
        }
        public static bool parseListType(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> listType = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            switch (listType.getValue()) {
                case "ordered-list":
                    return true;
                case "unordered-list":
                    return false;
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(listType, "Unrecognised list type: " + listType);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher parseBreakMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[");
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "type");
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> stringToken = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "]");
            string typeName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseStringToken(stringToken);
            switch (typeName) {
                case "line":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._LINE_BREAK;
                case "page":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._PAGE_BREAK;
                case "column":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher._COLUMN_BREAK;
                default:
                    throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(stringToken, "Unrecognised break type: " + typeName);
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_0 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _paragraph;
        internal DocumentMatcherParser__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph) {
            this._paragraph = paragraph;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapParagraph(this._paragraph, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_1 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _run;
        internal DocumentMatcherParser__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run) {
            this._run = run;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapRun(this._run, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_2 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher _table;
        internal DocumentMatcherParser__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.TableMatcher table) {
            this._table = table;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapTable(this._table, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_3 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.bold(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_4 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.italic(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_5 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.underline(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_6 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.strikethrough(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_7 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.allCaps(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_8 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.smallCaps(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_9 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.commentReference(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_10 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _breakMatcher;
        internal DocumentMatcherParser__Anonymous_10(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher) {
            this._breakMatcher = breakMatcher;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapBreak(this._breakMatcher, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class EscapeSequences {
        internal static Mammoth.Couscous.java.util.regex.Pattern _PATTERN;
        static EscapeSequences() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences._PATTERN = Mammoth.Couscous.java.util.regex.Pattern.compile("\\\\(.)");
        }
        public static string decode(string value) {
            Mammoth.Couscous.java.util.regex.Matcher matcher = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences._PATTERN).matcher(value);
            Mammoth.Couscous.java.lang.StringBuilder decoded = new Mammoth.Couscous.java.lang.StringBuilder();
            int lastIndex = 0;
            while (matcher.find()) {
                decoded.append(value.Substring(lastIndex, matcher.start() - lastIndex));
                decoded.append(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.escapeSequence(matcher.group(1)));
                lastIndex = matcher.end();
            }
            decoded.append(value.Substring(lastIndex, (value.Length) - lastIndex));
            return decoded.toString();
        }
        public static char escapeSequence(string code) {
            switch (code) {
                case "n":
                    return '\n';
                case "r":
                    return '\r';
                case "t":
                    return '\t';
                default:
                    return code.charAt(0);
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "!")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE;
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseHtmlPathElements(tokens);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parseHtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>();
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens);
                elements.add(element);
                while ((tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE) && tokens.isNext(1, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ">")) {
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ">");
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    elements.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens));
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(elements);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement parseElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseTagNames(tokens);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> attributeList = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseAttributeOrClassNames(tokens);
            Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> _couscous_desugar_foreach_to_for7 = attributeList.iterator();
                while (_couscous_desugar_foreach_to_for7.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute attribute = _couscous_desugar_foreach_to_for7.next();
                    if (attribute._append && attributes.containsKey(attribute._name)) {
                        attributes.put(attribute._name, ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(attributes, attribute._name)).get() + " ") + attribute._value);
                    } else {
                        attributes.put(attribute._name, attribute._value);
                    }
                }
            }
            bool isFresh = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseIsFresh(tokens);
            string separator = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseSeparator(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, !isFresh, separator));
        }
        public static Mammoth.Couscous.java.util.List<string> parseTagNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            tagNames.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            while (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "|")) {
                tagNames.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            }
            return tagNames;
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> parseAttributeOrClassNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> attributes = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute>();
            while (true) {
                Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> attribute = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseAttributeOrClassName(tokens);
                if (attribute.isPresent()) {
                    attributes.add(attribute.get());
                } else {
                    return attributes;
                }
            }
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute> parseAttributeOrClassName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.isNext(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[")) {
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseAttribute(tokens));
            } else if (tokens.isNext(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ".")) {
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseClassName(tokens));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute>();
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute parseAttribute(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "[");
            string name = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=");
            string value = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "]");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute(name, value, true);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute parseClassName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ".");
            string className = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Attribute("class", className, true);
        }
        public static bool parseIsFresh(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return tokens.tryParse(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Anonymous_0(tokens));
        }
        public static string parseSeparator(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            bool isSeparator = tokens.tryParse(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser__Anonymous_1(tokens));
            if (isSeparator) {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "(");
                string value = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseString(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ")");
                return value;
            } else {
                return "";
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser__Attribute {
        internal string _name;
        internal string _value;
        internal bool _append;
        internal HtmlPathParser__Attribute(string name, string value, bool append) {
            this._name = name;
            this._value = value;
            this._append = append;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser__Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator__Action {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> _tokens;
        internal HtmlPathParser__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            this._tokens = tokens;
        }
        public void run() {
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":");
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "fresh");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator__Action {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> _tokens;
        internal HtmlPathParser__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            this._tokens = tokens;
        }
        public void run() {
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":");
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "separator");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T> rule<T>(T type, string regex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>(type, Mammoth.Couscous.java.util.regex.Pattern.compile(regex));
        }
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser<T> {
        internal Mammoth.Couscous.java.util.regex.Pattern _pattern;
        internal Mammoth.Couscous.java.util.List<T> _rules;
        internal RegexTokeniser(T unknown, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>> rules) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>> allRules = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>>(rules);
            allRules.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<T>(unknown, "."));
            this._pattern = Mammoth.Couscous.java.util.regex.Pattern.compile(java.lang.String.join("|", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, string>(allRules, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_0<T>())));
            this._rules = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, T>(allRules, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_1<T>());
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokenise(string value) {
            Mammoth.Couscous.java.util.regex.Matcher matcher = (this._pattern).matcher(value);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokens = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>>();
            while (matcher.lookingAt()) {
                Mammoth.Couscous.java.util.Optional<int> groupIndex = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<int>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.intRange(0, (this._rules).size()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__Anonymous_2(matcher));
                if (groupIndex.isPresent()) {
                    T tokenType = (this._rules).get(groupIndex.get());
                    tokens.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>(matcher.regionStart(), tokenType, matcher.group()));
                    matcher.region(matcher.end(), value.Length);
                } else {
                    throw new Mammoth.Couscous.java.lang.RuntimeException("Could not find group");
                }
            }
            return tokens;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__TokenRule {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__TokenRule<T> {
        internal T _type;
        internal Mammoth.Couscous.java.util.regex.Pattern _regex;
        internal RegexTokeniser__TokenRule(T type, Mammoth.Couscous.java.util.regex.Pattern regex) {
            if ((regex.matcher("")).groupCount() != 0) {
                throw new Mammoth.Couscous.java.lang.RuntimeException("regex cannot contain any groups");
            }
            this._type = type;
            this._regex = regex;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__Anonymous_0 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_0<T> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T> rule) {
            return ("(" + (rule._regex).pattern()) + ")";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class RegexTokeniser__Anonymous_1 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_1<T> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T>, T> {
        public T apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<T> rule) {
            return rule._type;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class RegexTokeniser__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<int> {
        internal Mammoth.Couscous.java.util.regex.Matcher _matcher;
        internal RegexTokeniser__Anonymous_2(Mammoth.Couscous.java.util.regex.Matcher matcher) {
            this._matcher = matcher;
        }
        public bool test(int index) {
            return !Mammoth.Couscous.java.util.Objects.isNull((this._matcher).group(index + 1));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap parse(string input) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMappings(Mammoth.Couscous.java.util.Arrays.asList<string>(input.split("\\r?\\n")));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap parseStyleMappings(Mammoth.Couscous.java.util.List<string> lines) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap.builder();
             {
                int lineIndex = 0;
                while (lineIndex < lines.size()) {
                    string line = lines.get(lineIndex);
                    try {
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.handleLine(styleMap, line);
                    } catch (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException exception) {
                        throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.ParseException(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.generateErrorMessage(line, lineIndex + 1, exception.getCharacterIndex(), exception.getMessage()));
                    }
                    lineIndex = lineIndex + 1;
                }
            }
            return styleMap.build();
        }
        public static void handleLine(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap, string line) {
            if (line.startsWith("#")) {
                return;
            }
            line = line.trim();
            if (line.isEmpty()) {
                return;
            }
            (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMapping(line)).accept(styleMap);
        }
        public static Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder> parseStyleMapping(string line) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokenise(line);
            Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parse(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, "=>");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseHtmlPath(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser__Anonymous_0(documentMatcher, htmlPath);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parseHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY;
            } else {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parse(tokens);
            }
        }
        public static string generateErrorMessage(string line, int lineNumber, int characterIndex, string message) {
            return ((((((((("error reading style map at line " + lineNumber) + ", character ") + (characterIndex + 1)) + ": ") + message) + "\n\n") + line) + "\n") + Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.repeatString(" ", characterIndex)) + "^";
        }
        public static string repeatString(string value, int times) {
            Mammoth.Couscous.java.lang.StringBuilder builder = new Mammoth.Couscous.java.lang.StringBuilder();
             {
                int i = 0;
                while (i < times) {
                    builder.append(value);
                    i = i + 1;
                }
            }
            return builder.toString();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser__Anonymous_0 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder> {
        internal Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _documentMatcher;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _htmlPath;
        internal StyleMapParser__Anonymous_0(Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath) {
            this._documentMatcher = documentMatcher;
            this._htmlPath = htmlPath;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap) {
            (this._documentMatcher).accept(styleMap, this._htmlPath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMappingTokeniser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokenise(string line) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokeniseToList(line), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(line.Length, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF, ""));
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>> tokeniseToList(string line) {
            string stringPrefix = "'(?:(?:\\\\.|[^'])*)";
            string identifierCharacter = "(?:[a-zA-Z\\-_]|\\\\.)";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokeniser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNKNOWN, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>[] {Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, ((identifierCharacter + "(?:") + identifierCharacter) + "|[0-9])*"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":|>|=>|\\^=|=|\\(|\\)|\\[|\\]|\\||!|\\."), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE, "\\s+"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING, stringPrefix + "'"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNTERMINATED_STRING, stringPrefix), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER, "[0-9]+")}));
            return tokeniser.tokenise(line);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class Token {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class Token<T> {
        internal int _characterIndex;
        internal T _tokenType;
        internal string _value;
        internal Token(int characterIndex, T tokenType, string value) {
            this._characterIndex = characterIndex;
            this._tokenType = tokenType;
            this._value = value;
        }
        public int getCharacterIndex() {
            return this._characterIndex;
        }
        public T getTokenType() {
            return this._tokenType;
        }
        public string getValue() {
            return this._value;
        }
        public string toString() {
            return ((("Token(tokenType=" + this._tokenType) + ", value=") + this._value) + ")";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class TokenIterator {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenIterator<T> {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> _tokens;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> _end;
        internal int _index;
        internal TokenIterator(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokens, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> end) {
            this._tokens = tokens;
            this._end = end;
            this._index = 0;
        }
        public bool isNext(int offset, T tokenType, string value) {
            int tokenIndex = this._index + offset;
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(tokenIndex);
            return (token.getTokenType()).equals(tokenType) && ((token.getValue()).Equals(value));
        }
        public bool isNext(T tokenType, string value) {
            return this.isNext(0, tokenType, value);
        }
        public bool trySkip(T tokenType, string value) {
            if (this.isNext(tokenType, value)) {
                this.skip();
                return true;
            } else {
                return false;
            }
        }
        public T peekTokenType() {
            return (this.getToken(this._index)).getTokenType();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            this._index = this._index + 1;
            return token;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next(T type) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if ((token.getTokenType()).equals(type)) {
                this._index = this._index + 1;
                return token;
            } else {
                throw this.unexpectedTokenType(type, token);
            }
        }
        public string nextValue(T type) {
            return (this.next(type)).getValue();
        }
        public void skip() {
            this._index = this._index + 1;
        }
        public void skip(T tokenType) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            this._index = this._index + 1;
        }
        public void skip(T tokenType, string tokenValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            string actualValue = token.getValue();
            if (!(actualValue.Equals(tokenValue))) {
                throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<T>(token, (((("expected " + tokenType) + " token with value ") + tokenValue) + " but value was ") + actualValue);
            }
            this._index = this._index + 1;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException unexpectedTokenType(T expected, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> actual) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<T>(actual, (("expected token of type " + expected) + " but was of type ") + actual.getTokenType());
        }
        public bool tryParse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator__Action action) {
            int originalIndex = this._index;
            try {
                action.run();
                return true;
            } catch (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException exception) {
                this._index = originalIndex;
                return false;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> getToken(int index) {
            if (index < (this._tokens).size()) {
                return (this._tokens).get(index);
            } else {
                return this._end;
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal interface TokenIterator__Action {
        void run();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenParser {
        public static Mammoth.Couscous.java.util.Optional<string> parseClassName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            if (tokens.trySkip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ".")) {
                return Mammoth.Couscous.java.util.Optional.of<string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseIdentifier(tokens));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public static string parseIdentifier(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.decode(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
        }
        public static string parseString(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseStringToken(tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING));
        }
        public static string parseStringToken(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> token) {
            string value = token.getValue();
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.EscapeSequences.decode(value.Substring(1, ((value.Length) - 1) - 1));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal enum TokenType {
        _WHITESPACE, _IDENTIFIER, _SYMBOL, _STRING, _UNTERMINATED_STRING, _INTEGER, _EOF, _UNKNOWN
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal interface InputStreamSupplier {
        Mammoth.Couscous.java.io.InputStream open();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class Optionals {
        public static Mammoth.Couscous.java.util.Optional<T> first<T>(Mammoth.Couscous.java.util.Optional<T> first, Mammoth.Couscous.java.util.Optional<T> second) {
            if (first.isPresent()) {
                return first;
            } else {
                return second;
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> flatMap<T1, T2, R>(Mammoth.Couscous.java.util.Optional<T1> first, Mammoth.Couscous.java.util.Optional<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, Mammoth.Couscous.java.util.Optional<R>> function) {
            if (first.isPresent() && second.isPresent()) {
                return function.apply(first.get(), second.get());
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> map<T1, T2, R>(Mammoth.Couscous.java.util.Optional<T1> first, Mammoth.Couscous.java.util.Optional<T2> second, Mammoth.Couscous.java.util.function.BiFunction<T1, T2, R> function) {
            if (first.isPresent() && second.isPresent()) {
                return Mammoth.Couscous.java.util.Optional.of<R>(function.apply(first.get(), second.get()));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<R> map<R>(Mammoth.Couscous.java.util.OptionalInt first, Mammoth.Couscous.java.util.function.IntFunction<R> function) {
            if (first.isPresent()) {
                return Mammoth.Couscous.java.util.Optional.of<R>(function.apply(first.getAsInt()));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<R>();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal interface SupplierWithException<T, E> {
        T get();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefix {
        internal Mammoth.Couscous.java.util.Optional<string> _prefix;
        internal string _uri;
        internal NamespacePrefix(Mammoth.Couscous.java.util.Optional<string> prefix, string uri) {
            this._prefix = prefix;
            this._uri = uri;
        }
        public Mammoth.Couscous.java.util.Optional<string> getPrefix() {
            return this._prefix;
        }
        public string getUri() {
            return this._uri;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes : Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> _uriToPrefix;
        internal NamespacePrefixes(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> uriToPrefix) {
            this._uriToPrefix = uriToPrefix;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder();
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupUri(string uri) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>(this._uriToPrefix, uri);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupPrefix(string prefix) {
            return this.lookupPrefix(Mammoth.Couscous.java.util.Optional.of<string>(prefix));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> defaultNamespace() {
            return this.lookupPrefix(Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> lookupPrefix(Mammoth.Couscous.java.util.Optional<string> prefix) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>((this._uriToPrefix).values(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Anonymous_0(prefix));
        }
        public Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> iterator() {
            return ((this._uriToPrefix).values()).iterator();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Builder {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> _uriToPrefix;
        internal NamespacePrefixes__Builder() {
            this._uriToPrefix = new Mammoth.Couscous.java.util.HashMap<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder put(string prefix, string uri) {
            (this._uriToPrefix).put(uri, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix(Mammoth.Couscous.java.util.Optional.of<string>(prefix), uri));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder defaultPrefix(string uri) {
            (this._uriToPrefix).put(uri, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix(Mammoth.Couscous.java.util.Optional.empty<string>(), uri));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes(this._uriToPrefix);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix> {
        internal Mammoth.Couscous.java.util.Optional<string> _prefix;
        internal NamespacePrefixes__Anonymous_0(Mammoth.Couscous.java.util.Optional<string> prefix) {
            this._prefix = prefix;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix @namespace) {
            return (@namespace.getPrefix()).equals(this._prefix);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NullXmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _INSTANCE;
        static NullXmlElement() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement._INSTANCE = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement();
        }
        public bool hasChild(string name) {
            return false;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name) {
            return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return this;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.java.util.Optional.empty<string>();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike {
        internal string _name;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> _children;
        internal XmlElement(string name, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            this._name = name;
            this._attributes = attributes;
            this._children = children;
        }
        public string getName() {
            return this._name;
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
        }
        public string getAttribute(string name) {
            return (this.getAttributeOrNone(name)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_0(name));
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._attributes, name);
        }
        public string innerText() {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, string>(this._children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_1()));
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor) {
            return visitor.visit(this);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren() {
            return this._children;
        }
        public string toString() {
            return ((((("XmlElement(name=" + this._name) + ", attributes=") + this._attributes) + ", children=") + this._children) + ")";
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList findChildren(string name) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.toList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this.findChildrenIterable(name)));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.getFirst<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this.findChildrenIterable(name));
        }
        public bool hasChild(string name) {
            return ((this.findChildrenIterable(name)).iterator()).hasNext();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.getFirst<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike>(this.findChildrenIterable(name), Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement._INSTANCE);
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChildrenIterable(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._children, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_2(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _name;
        internal XmlElement__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Element has no '" + this._name) + "' attribute");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode arg0) {
            return arg0.innerText();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_2 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _name;
        internal XmlElement__Anonymous_2(string name) {
            this._name = name;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return (child.getName()).Equals(this._name);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlElementLike {
        bool hasChild(string name);
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name);
        Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name);
        Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name);
        Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList : Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> _elements;
        internal XmlElementList(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> elements) {
            this._elements = elements;
        }
        public Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> iterator() {
            return (this._elements).iterator();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList findChildren(string name) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList__Anonymous_0(name)));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>> {
        internal string _name;
        internal XmlElementList__Anonymous_0(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return element.findChildren(this._name);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlNode {
        string innerText();
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlNodeVisitor<T> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode textNode);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlNodes {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element(name, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element(string name, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(name, attributes, children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode text(string value) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode(value);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlTextNode : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode {
        internal string _value;
        internal XmlTextNode(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public string innerText() {
            return this._value;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor) {
            return visitor.visit(this);
        }
        public string toString() {
            return ("XmlTextNode(value=" + this._value) + ")";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class ElementName {
        internal string _uri;
        internal string _localName;
        internal ElementName(string uri, string localName) {
            this._uri = uri;
            this._localName = localName;
        }
        public string getUri() {
            return this._uri;
        }
        public string getLocalName() {
            return this._localName;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal interface SimpleSaxHandler {
        void startElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> attributes);
        void endElement();
        void characters(string @string);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlElementBuilder {
        internal string _name;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> _children;
        internal XmlElementBuilder(string name, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._name = name;
            this._attributes = attributes;
            this._children = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(this._name, this._attributes, this._children);
        }
        public void addChild(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode node) {
            (this._children).add(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _namespaces;
        internal XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes namespaces) {
            this._namespaces = namespaces;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseStream(Mammoth.Couscous.java.io.InputStream inputStream) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator nodeGenerator = this.create_NodeGenerator();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSax.parseStream(inputStream, nodeGenerator);
            return nodeGenerator.getRoot();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseString(string value) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator nodeGenerator = this.create_NodeGenerator();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSax.parseString(value, nodeGenerator);
            return nodeGenerator.getRoot();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator create_NodeGenerator() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__NodeGenerator : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.SimpleSaxHandler {
        internal Mammoth.Couscous.java.util.Deque<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder> _elementStack;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;
        internal XmlParser__NodeGenerator(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser this_org__zwobble__mammoth__internal__xml__parsing__XmlParser) {
            this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser;
            this._elementStack = new Mammoth.Couscous.java.util.ArrayDeque<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement getRoot() {
            return ((this._elementStack).getFirst()).build();
        }
        public void startElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> attributes) {
            Mammoth.Couscous.java.util.Map<string, string> simpleAttributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapKeys<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string, string>(attributes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_0(this));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder element = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder(this.readName(name), simpleAttributes);
            (this._elementStack).add(element);
        }
        public string readName(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            if (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.isNullOrEmpty(name.getUri())) {
                return name.getLocalName();
            } else {
                return ((((this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser)._namespaces).lookupUri(name.getUri())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_2(name))).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_3(name));
            }
        }
        public void endElement() {
            if ((this._elementStack).size() > 1) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder element = (this._elementStack).removeLast();
                ((this._elementStack).getLast()).addChild(element.build());
            }
        }
        public void characters(string @string) {
            ((this._elementStack).getLast()).addChild(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode(@string));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        internal XmlParser__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator) {
            this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        }
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName arg0) {
            return (this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator).readName(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<string, string> {
        public string apply(string prefix) {
            return prefix + ":";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefix @namespace) {
            return ((@namespace.getPrefix()).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__Anonymous_1())).orElse("") + (this._name).getLocalName();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__Anonymous_3 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string get() {
            return (("{" + (this._name).getUri()) + "}") + (this._name).getLocalName();
        }
    }
}

