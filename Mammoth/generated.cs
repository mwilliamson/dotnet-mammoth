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
        public static string extractRawTextOfChildren(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren parent) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(parent.getChildren());
        }
        public static string extractRawText(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> nodes) {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_16()));
        }
        public static string extractRawText(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text), node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_17())).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_20(node));
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
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawTextOfChildren(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_16 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_17 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text arg0) {
            return arg0.getValue();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_18 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren arg0) {
            return arg0.getChildren();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_19 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return "\n\n";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_20 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement _node;
        internal InternalDocumentConverter__Anonymous_20(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            this._node = node;
        }
        public string get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren), this._node)).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_18())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
            string suffix = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph), this._node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_19())).orElse("");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(children) + suffix;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface Archive : Mammoth.Couscous.java.io.Closeable {
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.io.InputStream> tryGetInputStream(string name);
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

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml {
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement _imageConverter;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> _noteReferences;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment> _referencedComments;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(document), documentConverter._warnings);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> noteReferences) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(noteReferences, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_1(document));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>());
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(element), documentConverter._warnings);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> mainBody = this.convertChildrenToHtml(document);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.findNotes(document, this._noteReferences);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteNodes = notes.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("ol", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_2(this))));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> commentNodes = (this._referencedComments).isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dl", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(this._referencedComments, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_3(this))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(mainBody, noteNodes, commentNodes);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note) {
            string id = this.generateNoteHtmlId(note.getNoteType(), note.getId());
            string referenceId = this.generateNoteRefHtmlId(note.getNoteType(), note.getId());
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteBody = this.convertToHtml(note.getBody());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + referenceId), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("li", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", id), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(noteBody, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment referencedComment) {
            string commentId = (referencedComment._comment).getCommentId();
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> body = this.convertToHtml((referencedComment._comment).getBody());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + this.generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dt", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", this.generateReferentHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("Comment " + referencedComment._label))), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dd", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(body, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_4(this));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertChildrenToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren element) {
            return this.convertToHtml(element.getChildren());
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element) {
            return element.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_16(this));
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
        internal DocumentToHtml__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment arg0) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_5 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal DocumentToHtml__Anonymous_5(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._paragraph = paragraph;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> content = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._paragraph);
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
        internal DocumentToHtml__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._run = run;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(this._run);
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
    internal class DocumentToHtml__Anonymous_11 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _commentId;
        internal DocumentToHtml__Anonymous_11(string commentId) {
            this._commentId = commentId;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException("Referenced comment could not be found, id: " + this._commentId);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_12 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference _commentReference;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._commentReference = commentReference;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            string commentId = (this._commentReference).getCommentId();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment comment = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._comments, commentId)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_11(commentId));
            string label = (("[" + (comment.getAuthorInitials()).orElse("")) + (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).size() + 1)) + "]";
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment(label, comment));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferentHtmlId("comment", commentId), "id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(label))));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_13 : Mammoth.Couscous.org.zwobble.mammoth.images.Image {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal string _contentType;
        internal DocumentToHtml__Anonymous_13(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, string contentType) {
            this._image = image;
            this._contentType = contentType;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAltText() {
            return (this._image).getAltText();
        }
        public string getContentType() {
            return this._contentType;
        }
        public Mammoth.Couscous.java.io.InputStream getInputStream() {
            return (this._image).open();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_14 : Mammoth.Couscous.java.util.function.Consumer<string> {
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal DocumentToHtml__Anonymous_14(Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._attributes = attributes;
        }
        public void accept(string altText) {
            (this._attributes).put("alt", altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_15 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal DocumentToHtml__Anonymous_15(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._image = image;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(string contentType) {
            try {
                Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>(((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._imageConverter).convert(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_13(this._image, contentType)));
                ((this._image).getAltText()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_14(attributes));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("img", attributes));
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add(exception.getMessage());
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_16 : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_16(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> children = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_5(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, paragraph);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getParagraphHtmlPath(paragraph)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_6(paragraph, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(children)).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> nodes = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_7(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, run);
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
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text) {
            if ((text.getValue()).isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(text.getValue()));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("\t"));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBreakHtmlPath(breakElement)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_9(breakElement));
            return (mapping.wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_10())).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("table", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(table)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tr", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableRow)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell) {
            Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
            if (tableCell.getColspan() != 1) {
                attributes.put("colspan", (tableCell.getColspan()).ToString());
            }
            if (tableCell.getRowspan() != 1) {
                attributes.put("rowspan", (tableCell.getRowspan()).ToString());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("td", attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableCell))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink) {
            Mammoth.Couscous.java.util.Map<string, string> attributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", this.generateHref(hyperlink));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("a", attributes, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(hyperlink)));
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
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId(bookmark.getName())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference) {
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).add(noteReference);
            string noteAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            string noteReferenceAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteRefHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("sup", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + noteAnchor, "id", noteReferenceAnchor), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(("[" + ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).size()) + "]"))))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference) {
            return (((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getCommentReference()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE)).wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_12(commentReference, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml))).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image) {
            return ((image.getContentType()).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_15(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, image))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
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
        internal Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement _imageConverter;
        static DocumentToHtmlOptions() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions("", false, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, false, false, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions__Anonymous_1());
        }
        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap embeddedStyleMap, bool disableDefaultStyleMap, bool disableEmbeddedStyleMap, Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter) {
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, imageConverter);
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
        public Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter() {
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

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _name;
        internal Bookmark(string name) {
            this._name = name;
        }
        public string getName() {
            return this._name;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElementVisitor<T> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break lineBreak);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image);
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
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Hyperlink(Mammoth.Couscous.java.util.Optional<string> href, Mammoth.Couscous.java.util.Optional<string> anchor, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._href = href;
            this._anchor = anchor;
            this._children = children;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink href(string href, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.of<string>(href), Mammoth.Couscous.java.util.Optional.empty<string>(), children);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink anchor(string anchor, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<string>(anchor), children);
        }
        public Mammoth.Couscous.java.util.Optional<string> getHref() {
            return this._href;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAnchor() {
            return this._anchor;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
    internal class Paragraph : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Paragraph(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._style = style;
            this._numbering = numbering;
            this._children = children;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> getNumbering() {
            return this._numbering;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Run : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal bool _isBold;
        internal bool _isItalic;
        internal bool _isUnderline;
        internal bool _isStrikethrough;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment _verticalAlignment;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _style;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Run(bool isBold, bool isItalic, bool isUnderline, bool isStrikethrough, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment verticalAlignment, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._isBold = isBold;
            this._isItalic = isItalic;
            this._isUnderline = isUnderline;
            this._isStrikethrough = isStrikethrough;
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment getVerticalAlignment() {
            return this._verticalAlignment;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> getStyle() {
            return this._style;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Table : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Table(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._children = children;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class TableRow : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal TableRow(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            this._children = children;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(this);
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
    internal class DocumentReader {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readDocument(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readStyles(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNumbering(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readContentTypes(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader(path);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_0(zipFile, styles, numbering, contentTypes, fileReader);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNotes(zipFile, bodyReaders), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readComments(zipFile, bodyReaders), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_1(bodyReaders, zipFile));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> readComments(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/comments.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_2(bodyReaders))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> readNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/footnotes.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_3(bodyReaders))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>())), ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/endnotes.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_4(bodyReaders))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>())), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_5())).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_6());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/styles.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_7())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/numbering.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_8())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "[Content_Types].xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_9())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._DEFAULT);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, ("word/_rels/" + name) + ".xml.rels")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_10())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY);
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> tryParseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_12(zipFile, name));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, name)).orElseThrow<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_13(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface DocumentReader__BodyReaders {
        Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader forName(string name);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal DocumentReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._zipFile = zipFile;
            this._styles = styles;
            this._numbering = numbering;
            this._contentTypes = contentTypes;
            this._fileReader = fileReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader forName(string name) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readRelationships(this._zipFile, name);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader(this._styles, this._numbering, relationships, this._contentTypes, this._zipFile, this._fileReader);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_1 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal DocumentReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            this._bodyReaders = bodyReaders;
            this._zipFile = zipFile;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader reader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader((this._bodyReaders).forName("document"), notes, comments);
            return reader.readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.parseOfficeXml(this._zipFile, "word/document.xml"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal DocumentReader__Anonymous_2(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            this._bodyReaders = bodyReaders;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.CommentXmlReader((this._bodyReaders).forName("comments"))).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal DocumentReader__Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            this._bodyReaders = bodyReaders;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.footnote((this._bodyReaders).forName("footnotes"))).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal DocumentReader__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            this._bodyReaders = bodyReaders;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.endnote((this._bodyReaders).forName("endnotes"))).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_5 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg1) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_7 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStylesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_8 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNumberingXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readContentTypesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_10 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml.readRelationshipsXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_11 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement apply(Mammoth.Couscous.java.io.InputStream arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.parseXml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_12 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _zipFile;
        internal string _name;
        internal DocumentReader__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile, string name) {
            this._zipFile = zipFile;
            this._name = name;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> get() {
            return ((this._zipFile).tryGetInputStream(this._name)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__Anonymous_11());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_13 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException> {
        internal string _name;
        internal DocumentReader__Anonymous_13(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException get() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException(new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name));
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike body = element.findChildOrEmpty("w:body");
            return (((this._bodyReader).readElements(body.getChildren())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader__Anonymous_0(this));
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
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> _numbering;
        static Numbering() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>());
        }
        internal Numbering(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> numbering) {
            this._numbering = numbering;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> findLevel(string numId, string level) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(this._numbering, numId)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering__Anonymous_0(level));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal string _level;
        internal Numbering__Anonymous_0(string level) {
            this._level = level;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> levels) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levels, this._level);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumberingXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNums(element.findChildren("w:abstractNum"));
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNums(element.findChildren("w:num"), abstractNums));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readAbstractNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readAbstractNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string abstractNumId = element.getAttribute("w:abstractNumId");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNumId, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevels(element));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevels(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(element.findChildren("w:lvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevel(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string levelIndex = element.getAttribute("w:ilvl");
            Mammoth.Couscous.java.util.Optional<string> numFmt = (element.findChildOrEmpty("w:numFmt")).getAttributeOrNone("w:val");
            bool isOrdered = !numFmt.equals(Mammoth.Couscous.java.util.Optional.of<string>("bullet"));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levelIndex, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, isOrdered));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList numElements, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_2(abstractNums));
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            string numId = numElement.getAttribute("w:numId");
            string abstractNumId = ((numElement.findChild("w:abstractNumId")).get()).getAttribute("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numId, (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNums, abstractNumId)).get());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNum(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevel(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>> {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> _abstractNums;
        internal NumberingXml__Anonymous_2(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            this._abstractNums = abstractNums;
        }
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNum(numElement, this._abstractNums);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _XML_NAMESPACES;
        static OfficeXml() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml._XML_NAMESPACES = (((((((((((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).put("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main")).put("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")).put("a", "http://schemas.openxmlformats.org/drawingml/2006/main")).put("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture")).put("content-types", "http://schemas.openxmlformats.org/package/2006/content-types")).put("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")).put("relationships", "http://schemas.openxmlformats.org/package/2006/relationships")).put("v", "urn:schemas-microsoft-com:vml")).put("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006")).put("office-word", "urn:schemas-microsoft-com:office:word")).build();
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
        internal string _target;
        internal Relationship(string target) {
            this._target = target;
        }
        public string getTarget() {
            return this._target;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> _relationships;
        static Relationships() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>());
        }
        internal Relationships(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> relationships) {
            this._relationships = relationships;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship findRelationshipById(string id) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(this._relationships, id)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships__Anonymous_0(id));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Relationships__Anonymous_0 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _id;
        internal Relationships__Anonymous_0(string id) {
            this._id = id;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Could not find relationship '" + this._id) + "'");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationshipsXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.findChildren("relationships:Relationship"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml__Anonymous_0()));
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> readRelationship(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.getAttribute("Id"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship(element.getAttribute("Target")));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
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
                case "w:br":
                    return this.readBreak(element);
                case "w:tbl":
                    return this.readTable(element);
                case "w:tr":
                    return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_0());
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
                case "w:smartTag":
                case "w:drawing":
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
                case "w:tcPr":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
                default:
                    string warning = "An unrecognised element was ignored: " + element.getName();
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning(warning);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:rPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readRunStyle(properties), this.readElements(element.getChildren()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_1(this, properties));
        }
        public Mammoth.Couscous.java.util.Optional<string> currentHyperlinkHref() {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(this._complexFieldStack, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField)))).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_2());
        }
        public bool isBold(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:b");
        }
        public bool isItalic(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:i");
        }
        public bool isUnderline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:u");
        }
        public bool isStrikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:strike");
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
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = this.readNumbering(properties);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readParagraphStyle(properties), this.readElements(element.getChildren()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_7(numbering))).appendExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readFieldChar(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string type = (element.getAttributeOrNone("w:fldCharType")).orElse("");
            if (type.Equals("begin")) {
                (this._currentInstrText).setLength(0);
            } else if (type.Equals("end")) {
                (this._complexFieldStack).remove();
            } else if (type.Equals("separate")) {
                string instrText = (this._currentInstrText).toString();
                Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField complexField = ((this.parseHyperlinkFieldCode(instrText)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_8())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (this._complexFieldStack).add(complexField);
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInstrText(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            (this._currentInstrText).append(element.innerText());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.java.util.Optional<string> parseHyperlinkFieldCode(string instrText) {
            Mammoth.Couscous.java.util.regex.Pattern pattern = Mammoth.Couscous.java.util.regex.Pattern.compile("\\s*HYPERLINK \"(.*)\"");
            Mammoth.Couscous.java.util.regex.Matcher matcher = pattern.matcher(instrText);
            if (matcher.lookingAt()) {
                return Mammoth.Couscous.java.util.Optional.of<string>(matcher.group(1));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readParagraphStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:pStyle", "Paragraph", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_9(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string styleTagName, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            return ((this.readVal(properties, styleTagName)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_10(this, styleType, findStyleById))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.empty());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById(string styleType, string styleId, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style = findStyleById.apply(styleId);
            if (style.isPresent()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(style);
            } else {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, Mammoth.Couscous.java.util.Optional.empty<string>())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(((styleType + " style with ID ") + styleId) + " was referenced but not defined in the document"));
            }
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike numberingProperties = properties.findChildOrEmpty("w:numPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.flatMap<string, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this.readVal(numberingProperties, "w:numId"), this.readVal(numberingProperties, "w:ilvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_11(this));
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
            return ((this.readElements(element.getChildren())).flatMap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_12(this))).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_13());
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
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMapWithIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(rows, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_14(merged, rowspans)));
        }
        public Mammoth.Couscous.java.util.Optional<string> checkTableRows(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> rows) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for1 = rows.iterator();
                while (_couscous_desugar_foreach_to_for1.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement rowElement = _couscous_desugar_foreach_to_for1.next();
                    Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow> row = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow), rowElement);
                    if (!row.isPresent()) {
                        return Mammoth.Couscous.java.util.Optional.of<string>("unexpected non-row element in table, cell merging may be incorrect");
                    } else {
                         {
                            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for0 = ((row.get()).getChildren()).iterator();
                            while (_couscous_desugar_foreach_to_for0.hasNext()) {
                                Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement cell = _couscous_desugar_foreach_to_for0.next();
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTableCell(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:tcPr");
            Mammoth.Couscous.java.util.Optional<string> gridSpan = (properties.findChildOrEmpty("w:gridSpan")).getAttributeOrNone("w:val");
            int colspan = (gridSpan.map<int>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_15())).orElse(1);
            return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_16(this, properties, colspan));
        }
        public bool readVmerge(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return ((properties.findChild("w:vMerge")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_18())).orElse(false);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readHyperlink(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> relationshipId = element.getAttributeOrNone("r:id");
            Mammoth.Couscous.java.util.Optional<string> anchor = element.getAttributeOrNone("w:anchor");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult childrenResult = this.readElements(element.getChildren());
            if (relationshipId.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_19(this, relationshipId));
            } else if (anchor.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_20(anchor));
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
            return ((element.getAttributeOrNone("r:id")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_22(element, this))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("A v:imagedata element without a relationship ID was ignored"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("wp:docPr");
            Mammoth.Couscous.java.util.Optional<string> altText = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>((properties.getAttributeOrNone("descr")).filter(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_23()), properties.getAttributeOrNone("title"));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips = ((((element.findChildren("a:graphic")).findChildren("a:graphicData")).findChildren("pic:pic")).findChildren("pic:blipFill")).findChildren("a:blip");
            return this.readBlips(blips, altText);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlips(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips, Mammoth.Couscous.java.util.Optional<string> altText) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(blips, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_24(this, altText));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlip(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip, Mammoth.Couscous.java.util.Optional<string> altText) {
            Mammoth.Couscous.java.util.Optional<string> embedRelationshipId = blip.getAttributeOrNone("r:embed");
            Mammoth.Couscous.java.util.Optional<string> linkRelationshipId = blip.getAttributeOrNone("r:link");
            if (embedRelationshipId.isPresent()) {
                string imagePath = this.relationshipIdToDocxPath(embedRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_25(this, imagePath));
            } else if (linkRelationshipId.isPresent()) {
                string imagePath = ((this._relationships).findRelationshipById(linkRelationshipId.get())).getTarget();
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_26(this, imagePath));
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship relationship = (this._relationships).findRelationshipById(relationshipId);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Uris.uriToZipEntryName("word", relationship.getTarget());
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_27();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField hyperlink(string href) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField(href);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface StatefulBodyXmlReader__ComplexField {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__HyperlinkComplexField : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField {
        internal string _href;
        internal StatefulBodyXmlReader__HyperlinkComplexField(string href) {
            this._href = href;
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
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T> visitor) {
            return visitor.visit(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell(1, this._colspan, this._children));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_1 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal StatefulBodyXmlReader__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            Mammoth.Couscous.java.util.Optional<string> hyperlinkHref = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).currentHyperlinkHref();
            if (hyperlinkHref.isPresent()) {
                children = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href(hyperlinkHref.get(), children));
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isBold(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isItalic(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isUnderline(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isStrikethrough(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVerticalAlignment(this._properties), style, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField field) {
            return field._href;
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
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal StatefulBodyXmlReader__Anonymous_7(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering) {
            this._numbering = numbering;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph(style, this._numbering, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_8 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField apply(string href) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static.hyperlink(href);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._styles).findParagraphStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_10 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _styleType;
        internal Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> _findStyleById;
        internal StatefulBodyXmlReader__Anonymous_10(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
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
    internal class StatefulBodyXmlReader__Anonymous_11 : Mammoth.Couscous.java.util.function.BiFunction<string, string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(string arg0, string arg1) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._numbering).findLevel(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_12 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_12(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).calculateRowspans(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_14 : Mammoth.Couscous.java.util.function.BiFunction<int, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> _merged;
        internal Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> _rowspans;
        internal StatefulBodyXmlReader__Anonymous_14(Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> merged, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> rowspans) {
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(mergedCells);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_15 : Mammoth.Couscous.java.util.function.Function<string, int> {
        public int apply(string arg0) {
            return int.Parse(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_16 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal int _colspan;
        internal StatefulBodyXmlReader__Anonymous_16(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, int colspan) {
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
    internal class StatefulBodyXmlReader__Anonymous_17 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        public bool apply(string val) {
            return val.Equals("continue");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_18 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:val")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_17())).orElse(true);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_19 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _relationshipId;
        internal StatefulBodyXmlReader__Anonymous_19(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.java.util.Optional<string> relationshipId) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._relationshipId = relationshipId;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href((((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._relationships).findRelationshipById((this._relationshipId).get())).getTarget(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_20 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal StatefulBodyXmlReader__Anonymous_20(Mammoth.Couscous.java.util.Optional<string> anchor) {
            this._anchor = anchor;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.anchor((this._anchor).get(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_21 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_21(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_22 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_22(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._element = element;
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(string relationshipId) {
            Mammoth.Couscous.java.util.Optional<string> title = (this._element).getAttributeOrNone("o:title");
            string imagePath = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).relationshipIdToDocxPath(relationshipId);
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readImage(imagePath, title, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_21(this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, imagePath));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_23 : Mammoth.Couscous.java.util.function.Predicate<string> {
        public bool test(string description) {
            return !(description.trim()).isEmpty();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_24 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal StatefulBodyXmlReader__Anonymous_24(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.java.util.Optional<string> altText) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._altText = altText;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readBlip(blip, this._altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_25 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_25(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, this._imagePath);
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
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._fileReader).getInputStream(this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_27 : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _EMPTY;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _paragraphStyles;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> _characterStyles;
        static Styles() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>());
        }
        internal Styles(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> paragraphStyles, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> characterStyles) {
            this._paragraphStyles = paragraphStyles;
            this._characterStyles = characterStyles;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findParagraphStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._paragraphStyles, id);
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> findCharacterStyleById(string id) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(this._characterStyles, id);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStylesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements = element.findChildren("w:style");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "paragraph"), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyles(styleElements, "character"));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList styleElements, string styleType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(styleElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_0(styleType)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string styleId = element.getAttribute("w:styleId");
            Mammoth.Couscous.java.util.Optional<string> styleName = (element.findChildOrEmpty("w:name")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(styleId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, styleName));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_0 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _styleType;
        internal StylesXml__Anonymous_0(string styleType) {
            this._styleType = styleType;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement styleElement) {
            return (styleElement.getAttribute("w:type")).Equals(this._styleType);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml__Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyle(arg0);
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
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for2 = nodes.iterator();
                while (_couscous_desugar_foreach_to_for2.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node = _couscous_desugar_foreach_to_for2.next();
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
                    Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_desugar_foreach_to_for3 = (next.getChildren()).iterator();
                    while (_couscous_desugar_foreach_to_for3.hasNext()) {
                        Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child = _couscous_desugar_foreach_to_for3.next();
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
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.java.util.Map__Entry<string, string>> _couscous_desugar_foreach_to_for4 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.orderedBy<Mammoth.Couscous.java.util.Map__Entry<string, string>, string>(attributes.entrySet(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_2())).iterator();
                while (_couscous_desugar_foreach_to_for4.hasNext()) {
                    Mammoth.Couscous.java.util.Map__Entry<string, string> attribute = _couscous_desugar_foreach_to_for4.next();
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMappings(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(new string[] {"p.Heading1 => h1:fresh", "p.Heading2 => h2:fresh", "p.Heading3 => h3:fresh", "p.Heading4 => h4:fresh", "p.Heading5 => h5:fresh", "p.Heading6 => h6:fresh", "p[style-name='Heading 1'] => h1:fresh", "p[style-name='Heading 2'] => h2:fresh", "p[style-name='Heading 3'] => h3:fresh", "p[style-name='Heading 4'] => h4:fresh", "p[style-name='Heading 5'] => h5:fresh", "p[style-name='Heading 6'] => h6:fresh", "p[style-name='heading 1'] => h1:fresh", "p[style-name='heading 2'] => h2:fresh", "p[style-name='heading 3'] => h3:fresh", "p[style-name='heading 4'] => h4:fresh", "p[style-name='heading 5'] => h5:fresh", "p[style-name='heading 6'] => h6:fresh", "r[style-name='Strong'] => strong", "p[style-name='footnote text'] => p", "r[style-name='footnote reference'] =>", "p[style-name='endnote text'] => p", "r[style-name='endnote reference'] =>", "p[style-name='annotation text'] => p", "r[style-name='annotation reference'] =>", "p[style-name='Footnote'] => p", "r[style-name='Footnote anchor'] =>", "p[style-name='Endnote'] => p", "r[style-name='Endnote anchor'] =>", "p:unordered-list(1) => ul > li:fresh", "p:unordered-list(2) => ul|ol > li > ul > li:fresh", "p:unordered-list(3) => ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:ordered-list(1) => ol > li:fresh", "p:ordered-list(2) => ul|ol > li > ol > li:fresh", "p:ordered-list(3) => ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "r[style-name='Hyperlink'] =>", "p[style-name='Normal'] => p:fresh"}));
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
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _couscous_desugar_foreach_to_for5 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.reversed<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(this._elements)).iterator();
                while (_couscous_desugar_foreach_to_for5.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = _couscous_desugar_foreach_to_for5.next();
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
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        static StyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY = (new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder()).build();
        }
        internal StyleMap(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> bold, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> italic, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> underline, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> strikethrough, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> commentReference, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> paragraphStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> runStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> breakStyles) {
            this._bold = bold;
            this._italic = italic;
            this._underline = underline;
            this._strikethrough = strikethrough;
            this._commentReference = commentReference;
            this._paragraphStyles = paragraphStyles;
            this._runStyles = runStyles;
            this._breakStyles = breakStyles;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap merge(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap high, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap low) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._bold, low._bold), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._italic, low._italic), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._underline, low._underline), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._strikethrough, low._strikethrough), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(high._commentReference, low._commentReference), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(high._paragraphStyles, low._paragraphStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(high._runStyles, low._runStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(high._breakStyles, low._breakStyles));
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
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getCommentReference() {
            return this._commentReference;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getParagraphHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(this._paragraphStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_0(paragraph))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_1());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getRunHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(this._runStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_2(run))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_3());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getBreakHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>(this._breakStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_4(breakElement))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap__Anonymous_5());
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
    internal class StyleMap__Anonymous_4 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _breakElement;
        internal StyleMap__Anonymous_4(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement) {
            this._breakElement = breakElement;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> styleMapping) {
            return styleMapping.matches(this._breakElement);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_5 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _commentReference;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>> _breakStyles;
        internal StyleMapBuilder() {
            this._paragraphStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>();
            this._runStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>();
            this._breakStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>>();
            this._bold = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._underline = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._strikethrough = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._breakStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(this._bold, this._italic, this._underline, this._strikethrough, this._commentReference, this._paragraphStyles, this._runStyles, this._breakStyles);
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
                case "b":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_2();
                case "i":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_3();
                case "u":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_4();
                case "strike":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_5();
                case "comment-reference":
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_6();
                case "br":
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseBreakMatcher(tokens);
                    return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser__Anonymous_7(breakMatcher);
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
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.bold(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_3 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.italic(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_4 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.underline(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_5 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.strikethrough(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_6 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.commentReference(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_7 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _breakMatcher;
        internal DocumentMatcherParser__Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher) {
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
            Mammoth.Couscous.java.util.List<string> classNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseClassNames(tokens);
            Mammoth.Couscous.java.util.Map<string, string> attributes = classNames.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("class", java.lang.String.join(" ", classNames));
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
        public static Mammoth.Couscous.java.util.List<string> parseClassNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            Mammoth.Couscous.java.util.List<string> classNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            while (true) {
                Mammoth.Couscous.java.util.Optional<string> className = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenParser.parseClassName(tokens);
                if (className.isPresent()) {
                    classNames.add(className.get());
                } else {
                    return classNames;
                }
            }
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokenise(line));
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
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>> tokenise(string line) {
            string stringPrefix = "'(?:(?:\\\\.|[^'])*)";
            string identifierCharacter = "(?:[a-zA-Z\\-_]|\\\\.)";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokeniser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNKNOWN, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser__TokenRule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>[] {Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, ((identifierCharacter + "(?:") + identifierCharacter) + "|[0-9])*"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":|>|=>|\\^=|=|\\(|\\)|\\[|\\]|\\||!|\\."), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE, "\\s+"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING, stringPrefix + "'"), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNTERMINATED_STRING, stringPrefix), Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.RegexTokeniser.rule<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER, "[0-9]+")}));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>> tokens = tokeniser.tokenise(line);
            tokens.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType>(line.Length, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF, ""));
            return tokens;
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
        internal int _index;
        internal TokenIterator(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokens) {
            this._tokens = tokens;
            this._index = 0;
        }
        public bool isNext(int offset, T tokenType, string value) {
            int tokenIndex = this._index + offset;
            if (tokenIndex < (this._tokens).size()) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = (this._tokens).get(tokenIndex);
                return (token.getTokenType()).equals(tokenType) && ((token.getValue()).Equals(value));
            } else {
                return false;
            }
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
            return ((this._tokens).get(this._index)).getTokenType();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = (this._tokens).get(this._index);
            this._index = this._index + 1;
            return token;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next(T type) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = (this._tokens).get(this._index);
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = (this._tokens).get(this._index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            this._index = this._index + 1;
        }
        public void skip(T tokenType, string tokenValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = (this._tokens).get(this._index);
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

