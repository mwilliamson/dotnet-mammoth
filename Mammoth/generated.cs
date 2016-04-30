namespace Mammoth.Couscous.org.zwobble.mammoth {
    internal interface Result<T> {
        T getValue();
        Mammoth.Couscous.java.util.Set<string> getWarnings();
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_1 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.nio.file.Path>(), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_0 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.InputStream _stream;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_0(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._stream = stream;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._stream, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_1(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal Mammoth.Couscous.java.io.File _file;
        internal InternalDocumentConverter_Anonymous_3(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, Mammoth.Couscous.java.io.File file) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            this._file = file;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).convertToHtml(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.nio.file.Path>((this._file).toPath()), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_2 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.File _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_2(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._file = file;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._file, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_3(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter, this._file));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_4 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, string> {
        public string apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.write(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_5 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_6 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_7 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_7(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.convertToHtml(nodes, (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter)._options);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_9 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).extractRawText(Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.nio.file.Path>(), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_8 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.InputStream _stream;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_8(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._stream = stream;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._stream, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_9(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_11 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal Mammoth.Couscous.java.io.File _file;
        internal InternalDocumentConverter_Anonymous_11(Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter, Mammoth.Couscous.java.io.File file) {
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
            this._file = file;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return (this._this_org__zwobble__mammoth__internal__InternalDocumentConverter).extractRawText(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.nio.file.Path>((this._file).toPath()), zipFile);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_10 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.java.io.File _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter _this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        internal InternalDocumentConverter_Anonymous_10(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter this_org__zwobble__mammoth__internal__InternalDocumentConverter) {
            this._file = file;
            this._this_org__zwobble__mammoth__internal__InternalDocumentConverter = this_org__zwobble__mammoth__internal__InternalDocumentConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> get() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.withDocxFile<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(this._file, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_11(this._this_org__zwobble__mammoth__internal__InternalDocumentConverter, this._file));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_12 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawTextOfChildren(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_13 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_15 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren arg0) {
            return arg0.getChildren();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_16 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return "\n\n";
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_14 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement _node;
        internal InternalDocumentConverter_Anonymous_14(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            this._node = node;
        }
        public string get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren), this._node)).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_15())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
            string suffix = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph), this._node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_16())).orElse("");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(children) + suffix;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter_Anonymous_17 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text arg0) {
            return arg0.getValue();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _options;
        internal InternalDocumentConverter(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            this._options = options;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_0(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_2(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return ((((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).flatMap<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_7(this))).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_6())).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_5())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_4());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_8(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_10(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_12());
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ZippedDocxFile(file);
            try {
                return function.apply(zipFile);
            } finally {
                zipFile.close();
            }
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.InMemoryDocxFile.fromStream(stream);
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
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_13()));
        }
        public static string extractRawText(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text), node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_17())).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter_Anonymous_14(node));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_18 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document _document;
        internal DocumentToHtml_Anonymous_18(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            this._document = document;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference reference) {
            return (((this._document).getNotes()).findNote(reference.getNoteType(), reference.getNoteId())).get();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_19 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_19(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_20 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_20(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_22 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_22(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._paragraph = paragraph;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._paragraph).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised paragraph style: " + (((this._paragraph).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.element("p");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_23 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_23(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._run = run;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath get() {
            if (((this._run).getStyle()).isPresent()) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add("Unrecognised run style: " + (((this._run).getStyle()).get()).describe());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath._EMPTY;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_25 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal DocumentToHtml_Anonymous_25(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image) {
            this._image = image;
        }
        public Mammoth.Couscous.java.io.InputStream get() {
            return (this._image).open();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_26 : Mammoth.Couscous.java.util.function.Consumer<string> {
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal DocumentToHtml_Anonymous_26(Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._attributes = attributes;
        }
        public void accept(string altText) {
            (this._attributes).put("alt", altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_24 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_24(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._image = image;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(string contentType) {
            try {
                Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
                string base64 = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Base64Encoding.streamToBase64(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_25(this._image));
                string src = (("data:" + contentType) + ";base64,") + base64;
                attributes.put("src", src);
                ((this._image).getAltText()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_26(attributes));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.selfClosingElement("img", attributes));
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add(exception.getMessage());
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml_Anonymous_21 : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml_Anonymous_21(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> content = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(paragraph);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._preserveEmptyParagraphs ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, content) : content;
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getParagraphHtmlPath(paragraph)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_22(paragraph, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return mapping.wrap(children);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(run);
            if (run.isStrikethrough()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getStrikethrough()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement("s"))).wrap(nodes);
            }
            if (run.isUnderline()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getUnderline()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath._EMPTY)).wrap(nodes);
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT) {
                nodes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("sub", nodes));
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT) {
                nodes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("sup", nodes));
            }
            if (run.isItalic()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getItalic()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement("em"))).wrap(nodes);
            }
            if (run.isBold()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBold()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement("strong"))).wrap(nodes);
            }
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getRunHtmlPath(run)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_23(run, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return mapping.wrap(nodes);
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
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak lineBreak) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.selfClosingElement("br"));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("table", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(table)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tr", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableRow)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("td", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableCell))));
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
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image) {
            return ((image.getContentType()).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_24(image, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml {
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> _noteReferences;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal DocumentToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            this._noteReferences = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference>();
            this._warnings = new Mammoth.Couscous.java.util.HashSet<string>();
            this._idPrefix = options.idPrefix();
            this._preserveEmptyParagraphs = options.shouldPreserveEmptyParagraphs();
            this._styleMap = options.styleMap();
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(document), documentConverter._warnings);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> noteReferences) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(noteReferences, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_18(document));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(element), documentConverter._warnings);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> mainBody = this.convertChildrenToHtml(document);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.findNotes(document, this._noteReferences);
            if (notes.isEmpty()) {
                return mainBody;
            } else {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode noteNode = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("ol", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_19(this)));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(mainBody, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(noteNode));
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note) {
            string id = this.generateNoteHtmlId(note.getNoteType(), note.getId());
            string referenceId = this.generateNoteRefHtmlId(note.getNoteType(), note.getId());
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteBody = this.convertToHtml(note.getBody());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + referenceId), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("li", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", id), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(noteBody, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_20(this));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertChildrenToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren element) {
            return this.convertToHtml(element.getChildren());
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element) {
            return element.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml_Anonymous_21(this));
        }
        public string generateNoteHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateId((this.noteTypeToIdFragment(noteType) + "-") + noteId);
        }
        public string generateNoteRefHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateId((this.noteTypeToIdFragment(noteType) + "-ref-") + noteId);
        }
        public string noteTypeToIdFragment(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType _couscous_tmp_0 = noteType;
            if (_couscous_tmp_0.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE)) {
                return "footnote";
            } else if (_couscous_tmp_0.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE)) {
                return "endnote";
            } else {
                throw new Mammoth.Couscous.java.lang.UnsupportedOperationException();
            }
        }
        public string generateId(string bookmarkName) {
            return this._idPrefix + bookmarkName;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _DEFAULT;
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal bool _disableDefaultStyleMap;
        static DocumentToHtmlOptions() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions("", false, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, false);
        }
        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap, bool disableDefaultStyleMap) {
            this._idPrefix = idPrefix;
            this._preserveEmptyParagraphs = preserveEmptyParagraphs;
            this._styleMap = styleMap;
            this._disableDefaultStyleMap = disableDefaultStyleMap;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions idPrefix(string prefix) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(prefix, this._preserveEmptyParagraphs, this._styleMap, this._disableDefaultStyleMap);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions preserveEmptyParagraphs() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, true, this._styleMap, this._disableDefaultStyleMap);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(string styleMap) {
            return this.addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parse(styleMap));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, (this._styleMap).update(styleMap), this._disableDefaultStyleMap);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions disableDefaultStyleMap() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, true);
        }
        public string idPrefix() {
            return this._idPrefix;
        }
        public bool shouldPreserveEmptyParagraphs() {
            return this._preserveEmptyParagraphs;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap() {
            return this._disableDefaultStyleMap ? this._styleMap : (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP).update(this._styleMap);
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
    internal class Document : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Document(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes) {
            this._children = children;
            this._notes = notes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes getNotes() {
            return this._notes;
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
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak lineBreak);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference);
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
    internal class LineBreak : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak _LINE_BREAK;
        static LineBreak() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak._LINE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak();
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
    internal class Notes_Anonymous_27 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return arg0.getNoteType();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes_Anonymous_29 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note arg0) {
            return arg0.getId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes_Anonymous_28 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, string>(notesOfType, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes_Anonymous_29());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Notes_Anonymous_30 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal string _noteId;
        internal Notes_Anonymous_30(string noteId) {
            this._noteId = noteId;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notesOfType) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(notesOfType, this._noteId);
        }
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
            this._notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapValues<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMultiMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes_Anonymous_27()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes_Anonymous_28());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNote(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(this._notes, noteType)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes_Anonymous_30(noteId));
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
    internal class Style_Anonymous_31 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _styleIdDescription;
        internal Style_Anonymous_31(string styleIdDescription) {
            this._styleIdDescription = styleIdDescription;
        }
        public string apply(string name) {
            return ((name + " (") + this._styleIdDescription) + ")";
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
            return ((this._name).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style_Anonymous_31(styleIdDescription))).orElse(styleIdDescription);
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
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal TableCell(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
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
    internal class BodyXmlReader_Anonymous_32 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_33 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_34 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_35 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal BodyXmlReader_Anonymous_35(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._properties = properties;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).isBold(this._properties), (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).isItalic(this._properties), (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).isUnderline(this._properties), (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).isStrikethrough(this._properties), (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).readVerticalAlignment(this._properties), style, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_36 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal BodyXmlReader_Anonymous_36(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._styles).findCharacterStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_37 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal BodyXmlReader_Anonymous_37(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_38 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        internal BodyXmlReader_Anonymous_38(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering) {
            this._numbering = numbering;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph(style, this._numbering, children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_39 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal BodyXmlReader_Anonymous_39(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._styles).findParagraphStyleById(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_40 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal string _styleType;
        internal Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> _findStyleById;
        internal BodyXmlReader_Anonymous_40(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._styleType = styleType;
            this._findStyleById = findStyleById;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> apply(string styleId) {
            return (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).findStyleById(this._styleType, styleId, this._findStyleById);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_41 : Mammoth.Couscous.java.util.function.BiFunction<string, string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal BodyXmlReader_Anonymous_41(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(string arg0, string arg1) {
            return ((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._numbering).findLevel(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_42 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal BodyXmlReader_Anonymous_42(Mammoth.Couscous.java.util.Optional<string> anchor) {
            this._anchor = anchor;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.anchor((this._anchor).get(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_43 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _relationshipId;
        internal BodyXmlReader_Anonymous_43(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, Mammoth.Couscous.java.util.Optional<string> relationshipId) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._relationshipId = relationshipId;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href((((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._relationships).findRelationshipById((this._relationshipId).get())).getTarget(), children);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_44 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal string _imagePath;
        internal BodyXmlReader_Anonymous_44(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFiles.getInputStream((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._file, this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_45 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal BodyXmlReader_Anonymous_45(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, Mammoth.Couscous.java.util.Optional<string> altText) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._altText = altText;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip) {
            return (this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader).readBlip(blip, this._altText);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_46 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal string _imagePath;
        internal BodyXmlReader_Anonymous_46(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return ((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._fileReader).getInputStream(this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader_Anonymous_47 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
        internal string _imagePath;
        internal BodyXmlReader_Anonymous_47(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader this_org__zwobble__mammoth__internal__docx__BodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader = this_org__zwobble__mammoth__internal__docx__BodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFiles.getInputStream((this._this_org__zwobble__mammoth__internal__docx__BodyXmlReader)._file, this._imagePath);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class BodyXmlReader {
        internal static Mammoth.Couscous.java.util.Set<string> _IMAGE_TYPES_SUPPORTED_BY_BROWSERS;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _relationships;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        static BodyXmlReader() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.set<string>(new string[] {"image/png", "image/gif", "image/jpeg", "image/svg+xml", "image/tiff"});
        }
        internal BodyXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._styles = styles;
            this._numbering = numbering;
            this._relationships = relationships;
            this._contentTypes = contentTypes;
            this._file = file;
            this._fileReader = fileReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string _couscous_tmp_1 = element.getName();
            if (_couscous_tmp_1.Equals("w:t")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text(element.innerText()));
            } else if (_couscous_tmp_1.Equals("w:r")) {
                return this.readRun(element);
            } else if (_couscous_tmp_1.Equals("w:p")) {
                return this.readParagraph(element);
            } else if (_couscous_tmp_1.Equals("w:tab")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab._TAB);
            } else if (_couscous_tmp_1.Equals("w:br")) {
                return this.readBreak(element);
            } else if (_couscous_tmp_1.Equals("w:tbl")) {
                return (this.readElements(element.children())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_32());
            } else if (_couscous_tmp_1.Equals("w:tr")) {
                return (this.readElements(element.children())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_33());
            } else if (_couscous_tmp_1.Equals("w:tc")) {
                return (this.readElements(element.children())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_34());
            } else if (_couscous_tmp_1.Equals("w:hyperlink")) {
                return this.readHyperlink(element);
            } else if (_couscous_tmp_1.Equals("w:bookmarkStart")) {
                return this.readBookmark(element);
            } else if (_couscous_tmp_1.Equals("w:footnoteReference")) {
                return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE, element);
            } else if (_couscous_tmp_1.Equals("w:endnoteReference")) {
                return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE, element);
            } else if (_couscous_tmp_1.Equals("w:pict")) {
                return this.readPict(element);
            } else if (_couscous_tmp_1.Equals("v:imagedata")) {
                return this.readImagedata(element);
            } else if (_couscous_tmp_1.Equals("wp:inline")) {
                return this.readInline(element);
            } else if (_couscous_tmp_1.Equals("wp:anchor")) {
                return this.readInline(element);
            } else if (_couscous_tmp_1.Equals("w:ins")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("w:smartTag")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("w:drawing")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("v:roundrect")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("v:shape")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("v:textbox")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("w:txbxContent")) {
                return this.readElements(element.children());
            } else if (_couscous_tmp_1.Equals("office-word:wrap")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("v:shadow")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("v:shapetype")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:bookmarkEnd")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:sectPr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:proofErr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:lastRenderedPageBreak")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:commentRangeStart")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:commentRangeEnd")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:commentReference")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:del")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:footnoteRef")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:endnoteRef")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:pPr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:rPr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:tblPr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:tblGrid")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else if (_couscous_tmp_1.Equals("w:tcPr")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else {
                string warning = "An unrecognised element was ignored: " + element.getName();
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning(warning);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:rPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readRunStyle(properties), this.readElements(element.children()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_35(this, properties));
        }
        public bool isBold(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return properties.hasChild("w:b");
        }
        public bool isItalic(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return properties.hasChild("w:i");
        }
        public bool isUnderline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return properties.hasChild("w:u");
        }
        public bool isStrikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return properties.hasChild("w:strike");
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment readVerticalAlignment(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            string verticalAlignment = (this.readVal(properties, "w:vertAlign")).orElse("");
            string _couscous_tmp_2 = verticalAlignment;
            if (_couscous_tmp_2.Equals("superscript")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT;
            } else if (_couscous_tmp_2.Equals("subscript")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT;
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._BASELINE;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readRunStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:rStyle", "Run", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_36(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElements(Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(nodes, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_37(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:pPr");
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = this.readNumbering(properties);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readParagraphStyle(properties), this.readElements(element.children()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_38(numbering))).appendExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readParagraphStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:pStyle", "Paragraph", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_39(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string styleTagName, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            return ((this.readVal(properties, styleTagName)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_40(this, styleType, findStyleById))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.empty());
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
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.flatMap<string, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this.readVal(numberingProperties, "w:numId"), this.readVal(numberingProperties, "w:ilvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_41(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string breakType = (element.getAttributeOrNone("w:type")).orElse("");
            if (breakType.Equals("")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.LineBreak._LINE_BREAK);
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("Unsupported break type: " + breakType);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readHyperlink(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> relationshipId = element.getAttributeOrNone("r:id");
            Mammoth.Couscous.java.util.Optional<string> anchor = element.getAttributeOrNone("w:anchor");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult childrenResult = this.readElements(element.children());
            if (relationshipId.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_43(this, relationshipId));
            } else if (anchor.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_42(anchor));
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readPict(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (this.readElements(element.children())).toExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImagedata(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> title = element.getAttributeOrNone("o:title");
            string relationshipId = element.getAttribute("r:id");
            string imagePath = this.relationshipIdToDocxPath(relationshipId);
            return this.readImage(imagePath, title, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_44(this, imagePath));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> altText = (element.findChildOrEmpty("wp:docPr")).getAttributeOrNone("descr");
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips = ((((element.findChildren("a:graphic")).findChildren("a:graphicData")).findChildren("pic:pic")).findChildren("pic:blipFill")).findChildren("a:blip");
            return this.readBlips(blips, altText);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlips(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips, Mammoth.Couscous.java.util.Optional<string> altText) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(blips, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_45(this, altText));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlip(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip, Mammoth.Couscous.java.util.Optional<string> altText) {
            Mammoth.Couscous.java.util.Optional<string> embedRelationshipId = blip.getAttributeOrNone("r:embed");
            Mammoth.Couscous.java.util.Optional<string> linkRelationshipId = blip.getAttributeOrNone("r:link");
            if (embedRelationshipId.isPresent()) {
                string imagePath = this.relationshipIdToDocxPath(embedRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_47(this, imagePath));
            } else if (linkRelationshipId.isPresent()) {
                string imagePath = ((this._relationships).findRelationshipById(linkRelationshipId.get())).getTarget();
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader_Anonymous_46(this, imagePath));
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImage(string imagePath, Mammoth.Couscous.java.util.Optional<string> altText, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier open) {
            Mammoth.Couscous.java.util.Optional<string> contentType = (this._contentTypes).findContentType(imagePath);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image(altText, contentType, open);
            string contentTypeString = contentType.orElse("(unknown)");
            if ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS).contains(contentTypeString)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(image);
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(image, ("Image of type " + contentTypeString) + " is unlikely to display in web browsers");
            }
        }
        public string relationshipIdToDocxPath(string relationshipId) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship relationship = (this._relationships).findRelationshipById(relationshipId);
            return "word/" + Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(relationship.getTarget(), 47);
        }
        public Mammoth.Couscous.java.util.Optional<string> readVal(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike element, string name) {
            return (element.findChildOrEmpty(name)).getAttributeOrNone("w:val");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypes_Anonymous_48 : Mammoth.Couscous.java.util.function.Function<string, string> {
        public string apply(string imageType) {
            return "image/" + imageType;
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
                    return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._imageExtensions, extension.ToLower())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes_Anonymous_48());
                }
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml_Anonymous_49 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readDefault(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml_Anonymous_50 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, string>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readOverride(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypesXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readDefaults(element.findChildren("content-types:Default")), Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readOverrides(element.findChildren("content-types:Override")));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readDefaults(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml_Anonymous_49());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readDefault(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(element.getAttribute("Extension"), element.getAttribute("ContentType"));
        }
        public static Mammoth.Couscous.java.util.Map<string, string> readOverrides(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, string>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml_Anonymous_50());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, string> readOverride(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, string>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.trimLeft(element.getAttribute("PartName"), 47), element.getAttribute("ContentType"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface DocumentReader__BodyReaders {
        Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader forName(string name);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_51 : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile _zipFile;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal DocumentReader_Anonymous_51(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
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
    internal class DocumentReader_Anonymous_52 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile _zipFile;
        internal DocumentReader_Anonymous_52(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            this._bodyReaders = bodyReaders;
            this._zipFile = zipFile;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader reader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader((this._bodyReaders).forName("document"), notes);
            return reader.readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.parseOfficeXml(this._zipFile, "word/document.xml"));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_53 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_54 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal DocumentReader_Anonymous_54(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            this._bodyReaders = bodyReaders;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.footnote((this._bodyReaders).forName("footnotes"))).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_55 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders _bodyReaders;
        internal DocumentReader_Anonymous_55(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            this._bodyReaders = bodyReaders;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader.endnote((this._bodyReaders).forName("endnotes"))).readElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_56 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg0, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> arg1) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat(arg0, arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_57 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStylesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_58 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNumberingXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_59 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypesXml.readContentTypesXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_60 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml.readRelationshipsXmlElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_62 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.io.InputStream, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement apply(Mammoth.Couscous.java.io.InputStream arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.parseXml(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_61 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.SupplierWithException<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>, Mammoth.Couscous.java.io.IOException> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile _zipFile;
        internal string _name;
        internal DocumentReader_Anonymous_61(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile, string name) {
            this._zipFile = zipFile;
            this._name = name;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> get() {
            return ((this._zipFile).tryGetInputStream(this._name)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_62());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader_Anonymous_63 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException> {
        internal string _name;
        internal DocumentReader_Anonymous_63(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException get() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException(new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readDocument(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readStyles(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNumbering(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readContentTypes(zipFile);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader(path);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders = new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_51(zipFile, styles, numbering, contentTypes, fileReader);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readNotes(zipFile, bodyReaders)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_52(bodyReaders, zipFile));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes> readNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader__BodyReaders bodyReaders) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/footnotes.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_54(bodyReaders))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>())), ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/endnotes.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_55(bodyReaders))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>())), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_56())).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_53());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles readStyles(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/styles.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_57())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "word/numbering.xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_58())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering._EMPTY);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes readContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(file, "[Content_Types].xml")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_59())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes._DEFAULT);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile, string name) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, ("word/_rels/" + name) + ".xml.rels")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_60())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships._EMPTY);
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> tryParseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile, string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_61(zipFile, name));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parseOfficeXml(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile zipFile, string name) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.tryParseOfficeXml(zipFile, name)).orElseThrow<Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader_Anonymous_63(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader_Anonymous_64 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader _this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        internal DocumentXmlReader_Anonymous_64(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader this_org__zwobble__mammoth__internal__docx__DocumentXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader = this_org__zwobble__mammoth__internal__docx__DocumentXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document(children, (this._this_org__zwobble__mammoth__internal__docx__DocumentXmlReader)._notes);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentXmlReader {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal DocumentXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes) {
            this._bodyReader = bodyReader;
            this._notes = notes;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document> readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement body = element.findChild("w:body");
            return (((this._bodyReader).readElements(body.children())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentXmlReader_Anonymous_64(this));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface DocxFile : Mammoth.Couscous.java.io.Closeable {
        Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.io.InputStream> tryGetInputStream(string name);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocxFiles_Anonymous_65 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.io.IOException> {
        internal string _name;
        internal DocxFiles_Anonymous_65(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.io.IOException get() {
            return new Mammoth.Couscous.java.io.IOException("Missing entry in file: " + this._name);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocxFiles {
        public static Mammoth.Couscous.java.io.InputStream getInputStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFile file, string name) {
            return (file.tryGetInputStream(name)).orElseThrow<Mammoth.Couscous.java.io.IOException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocxFiles_Anonymous_65(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal interface FileReader {
        Mammoth.Couscous.java.io.InputStream getInputStream(string uri);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader_Anonymous_66 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader_Anonymous_66(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isNoteElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader_Anonymous_67 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader_Anonymous_67(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return (this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).readNoteElement(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader_Anonymous_68 : Mammoth.Couscous.java.util.function.Function<string, bool> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal NotesXmlReader_Anonymous_68(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        }
        public bool apply(string type) {
            return !(this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader).isSeparatorType(type);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NotesXmlReader_Anonymous_69 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader _this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal NotesXmlReader_Anonymous_69(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader this_org__zwobble__mammoth__internal__docx__NotesXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader = this_org__zwobble__mammoth__internal__docx__NotesXmlReader;
            this._element = element;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note((this._this_org__zwobble__mammoth__internal__docx__NotesXmlReader)._noteType, (this._element).getAttribute("w:id"), children);
        }
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
            Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> elements = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(element.findChildren("w:" + this._tagName), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader_Anonymous_66(this));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader_Anonymous_67(this));
        }
        public bool isNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:type")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader_Anonymous_68(this))).orElse(true);
        }
        public bool isSeparatorType(string type) {
            return type.Equals("continuationSeparator") || type.Equals("separator");
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> readNoteElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (((this._bodyReader).readElements(element.children())).toResult()).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NotesXmlReader_Anonymous_69(this, element));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering_Anonymous_70 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal string _level;
        internal Numbering_Anonymous_70(string level) {
            this._level = level;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> levels) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levels, this._level);
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
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(this._numbering, numId)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering_Anonymous_70(level));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml_Anonymous_71 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNum(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml_Anonymous_72 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevel(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml_Anonymous_73 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>> {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> _abstractNums;
        internal NumberingXml_Anonymous_73(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            this._abstractNums = abstractNums;
        }
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNum(numElement, this._abstractNums);
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
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml_Anonymous_71());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readAbstractNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string abstractNumId = element.getAttribute("w:abstractNumId");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNumId, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevels(element));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevels(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(element.findChildren("w:lvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml_Anonymous_72());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevel(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string levelIndex = element.getAttribute("w:ilvl");
            Mammoth.Couscous.java.util.Optional<string> numFmt = (element.findChildOrEmpty("w:numFmt")).getAttributeOrNone("w:val");
            bool isOrdered = !numFmt.equals(Mammoth.Couscous.java.util.Optional.of<string>("bullet"));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levelIndex, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, isOrdered));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList numElements, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml_Anonymous_73(abstractNums));
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            string numId = numElement.getAttribute("w:numId");
            string abstractNumId = (numElement.findChild("w:abstractNumId")).getAttribute("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numId, (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNums, abstractNumId)).get());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml_Anonymous_75 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml.collapseAlternateContent(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXml_Anonymous_74 : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            if ((element.getName()).Equals("mc:AlternateContent")) {
                return (element.findChild("mc:Fallback")).getChildren();
            } else {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement collapsedElement = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(element.getName(), element.getAttributes(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(element.children(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml_Anonymous_75()));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(collapsedElement);
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlTextNode textNode) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(textNode);
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
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.OfficeXml_Anonymous_74());
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
    internal class ReadResult_Anonymous_76 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._elements;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult_Anonymous_77 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._extra;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult_Anonymous_78 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.java.lang.Iterable<string>> {
        public Mammoth.Couscous.java.lang.Iterable<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result) {
            return result._warnings;
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult_Anonymous_76()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult_Anonymous_77()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult_Anonymous_78()));
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(warning));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, string warning) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(element), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(warning));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult map(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(function.apply(this._elements)), this._extra, this._warnings);
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
    internal class Relationships_Anonymous_79 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _id;
        internal Relationships_Anonymous_79(string id) {
            this._id = id;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Could not find relationship '" + this._id) + "'");
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
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(this._relationships, id)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships_Anonymous_79(id));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml_Anonymous_80 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml.readRelationship(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class RelationshipsXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships readRelationshipsXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.findChildren("relationships:Relationship"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.RelationshipsXml_Anonymous_80()));
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship> readRelationship(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship>(element.getAttribute("Id"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationship(element.getAttribute("Target")));
        }
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
    internal class StylesXml_Anonymous_81 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _styleType;
        internal StylesXml_Anonymous_81(string styleType) {
            this._styleType = styleType;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement styleElement) {
            return (styleElement.getAttribute("w:type")).Equals(this._styleType);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXml_Anonymous_82 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement arg0) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml.readStyle(arg0);
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
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(styleElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml_Anonymous_81(styleType)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StylesXml_Anonymous_82());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string styleId = element.getAttribute("w:styleId");
            Mammoth.Couscous.java.util.Optional<string> styleName = (element.findChildOrEmpty("w:name")).getAttributeOrNone("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(styleId, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, styleName));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html_Anonymous_83 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal Html_Anonymous_83(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(node, this._builder);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html_Anonymous_84 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(node);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html_Anonymous_85 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.stripEmpty(element.getChildren());
            if (children.isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTagNames(), element.getAttributes(), children, element.isCollapsible()));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(element);
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
    internal class Html_Anonymous_86 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(element.getTagNames(), element.getAttributes(), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapse(element.getChildren()), element.isCollapsible());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement element) {
            return element;
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
    internal class Html_Anonymous_87 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>> {
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode last) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement), last);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html_Anonymous_88 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement last, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement next) {
            if (next.isCollapsible() && Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.isMatch(last, next)) {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_tmp_4 = (next.getChildren()).iterator();
                while (_couscous_tmp_4.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child = _couscous_tmp_4.next();
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(last.getChildren(), child);
                }
                return true;
            } else {
                return false;
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
            nodes.forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_83(builder));
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, children, false);
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(tagNames, attributes, children, true);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode selfClosingElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.selfClosingElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode selfClosingElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement(tagName, attributes);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_84());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> stripEmpty(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return node.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_85());
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _couscous_tmp_3 = nodes.iterator();
            while (_couscous_tmp_3.hasNext()) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node = _couscous_tmp_3.next();
                Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsingAdd(collapsed, node);
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
            return node.accept<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_86());
        }
        public static bool tryCollapse(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> collapsed, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.map<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement, bool>((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(collapsed)).flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_87()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement), node), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html_Anonymous_88())).orElse(false);
        }
        public static bool isMatch(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement first, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement second) {
            return (second.getTagNames()).contains(first.getTagName()) && (first.getAttributes()).equals(second.getAttributes());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal Mammoth.Couscous.java.util.List<string> _tagNames;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> _children;
        internal bool _collapsible;
        internal HtmlElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> children, bool collapsible) {
            this._tagNames = tagNames;
            this._attributes = attributes;
            this._children = children;
            this._collapsible = collapsible;
        }
        public Mammoth.Couscous.java.util.List<string> getTagNames() {
            return this._tagNames;
        }
        public string getTagName() {
            return (this._tagNames).get(0);
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> getChildren() {
            return this._children;
        }
        public bool isCollapsible() {
            return this._collapsible;
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
    internal interface HtmlNode__Visitor {
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element);
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement element);
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node);
        void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode__Mapper<T> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement element);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal interface HtmlNode {
        void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor);
        T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlSelfClosingElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal string _tagName;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal HtmlSelfClosingElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._tagName = tagName;
            this._attributes = attributes;
        }
        public string getTagName() {
            return this._tagName;
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
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
    internal class HtmlWriter_Anonymous_90 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter_Anonymous_90(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode child) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.write(child, this._builder);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter_Anonymous_89 : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor {
        internal Mammoth.Couscous.java.lang.StringBuilder _builder;
        internal HtmlWriter_Anonymous_89(Mammoth.Couscous.java.lang.StringBuilder builder) {
            this._builder = builder;
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement element) {
            ((this._builder).append("<")).append(element.getTagName());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.generateAttributes(element.getAttributes(), this._builder);
            (this._builder).append(">");
            (element.getChildren()).forEach(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter_Anonymous_90(this._builder));
            (((this._builder).append("</")).append(element.getTagName())).append(">");
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlSelfClosingElement element) {
            ((this._builder).append("<")).append(element.getTagName());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.generateAttributes(element.getAttributes(), this._builder);
            (this._builder).append(" />");
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTextNode node) {
            (this._builder).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeText(node.getValue()));
        }
        public void visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlForceWrite forceWrite) {
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter_Anonymous_91 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.Map__Entry<string, string>, string> {
        public string apply(Mammoth.Couscous.java.util.Map__Entry<string, string> arg0) {
            return arg0.getKey();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter {
        public static void write(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node, Mammoth.Couscous.java.lang.StringBuilder builder) {
            node.accept(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter_Anonymous_89(builder));
        }
        public static void generateAttributes(Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.lang.StringBuilder builder) {
            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.java.util.Map__Entry<string, string>> _couscous_tmp_5 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.orderedBy<Mammoth.Couscous.java.util.Map__Entry<string, string>, string>(attributes.entrySet(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter_Anonymous_91())).iterator();
            while (_couscous_tmp_5.hasNext()) {
                Mammoth.Couscous.java.util.Map__Entry<string, string> attribute = _couscous_tmp_5.next();
                ((((builder.append(" ")).append(attribute.getKey())).append("=\"")).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeAttributeValue(attribute.getValue()))).append("\"");
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

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult_Anonymous_92 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult_Anonymous_92<R> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, R> {
        public R apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> result) {
            return result._value;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult_Anonymous_93 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult_Anonymous_93<R> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, Mammoth.Couscous.java.lang.Iterable<string>> {
        public Mammoth.Couscous.java.lang.Iterable<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R> result) {
            return result._warnings;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult_Anonymous_94 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal class InternalResult_Anonymous_94<T> : Mammoth.Couscous.org.zwobble.mammoth.Result<T> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> _this_org__zwobble__mammoth__internal__results__InternalResult;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal InternalResult_Anonymous_94(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> this_org__zwobble__mammoth__internal__results__InternalResult, Mammoth.Couscous.java.util.Set<string> warnings) {
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

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.results {
    internal static class InternalResult {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>> flatMap<T, R>(Mammoth.Couscous.java.lang.Iterable<T> iterable, Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> function) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>> results = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>>(iterable, function);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<R>>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, R>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult_Anonymous_92<R>()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<R>, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult_Anonymous_93<R>()));
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult_Anonymous_94<T>(this, warnings);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DefaultStyles {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _DEFAULT_STYLE_MAP;
        static DefaultStyles() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseStyleMappings(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(new string[] {"p.Heading1 => h1:fresh", "p.Heading2 => h2:fresh", "p.Heading3 => h3:fresh", "p.Heading4 => h4:fresh", "p[style-name='Heading 1'] => h1:fresh", "p[style-name='Heading 2'] => h2:fresh", "p[style-name='Heading 3'] => h3:fresh", "p[style-name='Heading 4'] => h4:fresh", "p[style-name='heading 1'] => h1:fresh", "p[style-name='heading 2'] => h2:fresh", "p[style-name='heading 3'] => h3:fresh", "p[style-name='heading 4'] => h4:fresh", "p[style-name='heading 4'] => h4:fresh", "r[style-name='Strong'] => strong", "p[style-name='footnote text'] => p", "r[style-name='footnote reference'] =>", "p[style-name='endnote text'] => p", "r[style-name='endnote reference'] =>", "p[style-name='Footnote'] => p", "r[style-name='Footnote anchor'] =>", "p[style-name='Endnote'] => p", "r[style-name='Endnote anchor'] =>", "p:unordered-list(1) => ul > li:fresh", "p:unordered-list(2) => ul|ol > li > ul > li:fresh", "p:unordered-list(3) => ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:unordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ul > li:fresh", "p:ordered-list(1) => ol > li:fresh", "p:ordered-list(2) => ul|ol > li > ol > li:fresh", "p:ordered-list(3) => ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(4) => ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "p:ordered-list(5) => ul|ol > li > ul|ol > li > ul|ol > li > ul|ol > li > ol > li:fresh", "r[style-name='Hyperlink'] =>", "p[style-name='Normal'] => p:fresh"}));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface DocumentElementMatcher<T> {
        bool matches(T element);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_95 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style arg0) {
            return arg0.getStyleId();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_96 : Mammoth.Couscous.java.util.function.BiPredicate<string, string> {
        public bool test(string arg0, string arg1) {
            return arg0.Equals(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_97 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style, Mammoth.Couscous.java.util.Optional<string>> {
        public Mammoth.Couscous.java.util.Optional<string> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style arg0) {
            return arg0.getName();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_98 : Mammoth.Couscous.java.util.function.BiPredicate<string, string> {
        public bool test(string arg0, string arg1) {
            return arg0.equalsIgnoreCase(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching_Anonymous_100 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_100<T> : Mammoth.Couscous.java.util.function.Function<T, bool> {
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, T> _areEqual;
        internal T _requiredValue;
        internal DocumentElementMatching_Anonymous_100(Mammoth.Couscous.java.util.function.BiPredicate<T, T> areEqual, T requiredValue) {
            this._areEqual = areEqual;
            this._requiredValue = requiredValue;
        }
        public bool apply(T actualValue) {
            return (this._areEqual).test(this._requiredValue, actualValue);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal static class DocumentElementMatching_Anonymous_99 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching_Anonymous_99<T> : Mammoth.Couscous.java.util.function.Function<T, bool> {
        internal Mammoth.Couscous.java.util.Optional<T> _actual;
        internal Mammoth.Couscous.java.util.function.BiPredicate<T, T> _areEqual;
        internal DocumentElementMatching_Anonymous_99(Mammoth.Couscous.java.util.Optional<T> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, T> areEqual) {
            this._actual = actual;
            this._areEqual = areEqual;
        }
        public bool apply(T requiredValue) {
            return ((this._actual).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_100<T>(this._areEqual, requiredValue))).orElse(false);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatching {
        public static bool matchesStyle(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<string> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleId(styleId, style) && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyleName(styleName, style);
        }
        public static bool matchesStyleId(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<string>(styleId, style.map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_95()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_96());
        }
        public static bool matchesStyleName(Mammoth.Couscous.java.util.Optional<string> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<string>(styleName, style.flatMap<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_97()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_98());
        }
        public static bool matches<T>(Mammoth.Couscous.java.util.Optional<T> required, Mammoth.Couscous.java.util.Optional<T> actual, Mammoth.Couscous.java.util.function.BiPredicate<T, T> areEqual) {
            return (required.map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching_Anonymous_99<T>(actual, areEqual))).orElse(true);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPath {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _EMPTY;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _elements;
        static HtmlPath() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>());
        }
        internal HtmlPath(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements) {
            this._elements = elements;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, false)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement(tagNames, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tagNames, attributes, true)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> wrap(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> _couscous_tmp_6 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.reversed<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(this._elements)).iterator();
            while (_couscous_tmp_6.hasNext()) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = _couscous_tmp_6.next();
                nodes = element.wrap(nodes);
            }
            return nodes;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPathElement {
        internal Mammoth.Couscous.java.util.List<string> _tagNames;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal bool _isCollapsible;
        internal HtmlPathElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes, bool isCollapsible) {
            this._tagNames = tagNames;
            this._attributes = attributes;
            this._isCollapsible = isCollapsible;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement fresh(string tagName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>(), false);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement collapsible(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement.collapsible(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement collapsible(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, true);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> wrap(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlElement(this._tagNames, this._attributes, nodes, this._isCollapsible));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher_Anonymous_101 : Mammoth.Couscous.java.util.function.BiPredicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> {
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel first, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel second) {
            return first.isOrdered() == second.isOrdered() && (first.getLevelIndex()).equalsIgnoreCase(second.getLevelIndex());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<string> _styleName;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        static ParagraphMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        internal ParagraphMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<string> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering) {
            this._styleId = styleId;
            this._styleName = styleName;
            this._numbering = numbering;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleName(string styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<string>(styleName), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher orderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.ordered(level)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher unorderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.unordered(level)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return this.matchesStyle(paragraph) && this.matchesNumbering(paragraph);
        }
        public bool matchesStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, paragraph.getStyle());
        }
        public bool matchesNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this._numbering, paragraph.getNumbering(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher_Anonymous_101());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<string> _styleName;
        static RunMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        internal RunMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<string> styleName) {
            this._styleId = styleId;
            this._styleName = styleName;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher styleName(string styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<string>(styleName));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, run.getStyle());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap_Anonymous_102 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap_Anonymous_103 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph _paragraph;
        internal StyleMap_Anonymous_103(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            this._paragraph = paragraph;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> styleMapping) {
            return styleMapping.matches(this._paragraph);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap_Anonymous_104 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> arg0) {
            return arg0.getHtmlPath();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap_Anonymous_105 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run _run;
        internal StyleMap_Anonymous_105(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            this._run = run;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run> styleMapping) {
            return styleMapping.matches(this._run);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _EMPTY;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        static StyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY = (new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder()).build();
        }
        internal StyleMap(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> bold, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> italic, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> underline, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> strikethrough, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> paragraphStyles, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> runStyles) {
            this._bold = bold;
            this._italic = italic;
            this._underline = underline;
            this._strikethrough = strikethrough;
            this._paragraphStyles = paragraphStyles;
            this._runStyles = runStyles;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap update(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(styleMap._bold, this._bold), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(styleMap._italic, this._italic), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(styleMap._underline, this._underline), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(styleMap._strikethrough, this._strikethrough), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(styleMap._paragraphStyles, this._paragraphStyles), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(styleMap._runStyles, this._runStyles));
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
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getParagraphHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>(this._paragraphStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap_Anonymous_103(paragraph))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap_Anonymous_102());
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> getRunHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryFind<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>(this._runStyles, new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap_Anonymous_105(run))).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap_Anonymous_104());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapBuilder {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _underline;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _strikethrough;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _bold;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _italic;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>> _paragraphStyles;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>> _runStyles;
        internal StyleMapBuilder() {
            this._paragraphStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>>();
            this._runStyles = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>>();
            this._bold = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._underline = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._strikethrough = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
            this._italic = Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath>();
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._paragraphStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder mapRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher matcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            (this._runStyles).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapping<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run>(matcher, path));
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap(this._bold, this._italic, this._underline, this._strikethrough, this._paragraphStyles, this._runStyles);
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
    internal class DocumentMatcherParser_Anonymous_106 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _paragraph;
        internal DocumentMatcherParser_Anonymous_106(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph) {
            this._paragraph = paragraph;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapParagraph(this._paragraph, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser_Anonymous_107 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _run;
        internal DocumentMatcherParser_Anonymous_107(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run) {
            this._run = run;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapRun(this._run, path);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser_Anonymous_108 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.bold(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser_Anonymous_109 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.italic(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser_Anonymous_110 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.underline(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser_Anonymous_111 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder arg0, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath arg1) {
            arg0.strikethrough(arg1);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser {
        public static Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token identifier = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            string _couscous_tmp_7 = identifier.getValue();
            if (_couscous_tmp_7.Equals("p")) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher paragraph = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseParagraphMatcher(tokens);
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_106(paragraph);
            } else if (_couscous_tmp_7.Equals("r")) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseRunMatcher(tokens);
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_107(run);
            } else if (_couscous_tmp_7.Equals("b")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_108();
            } else if (_couscous_tmp_7.Equals("i")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_109();
            } else if (_couscous_tmp_7.Equals("u")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_110();
            } else if (_couscous_tmp_7.Equals("strike")) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser_Anonymous_111();
            } else {
                throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException(identifier, "Unrecognised document element: " + identifier);
            }
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher parseParagraphMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<string> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseNumbering(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(styleId, styleName, numbering);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher parseRunMatcher(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.Optional<string> styleId = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleId(tokens);
            Mammoth.Couscous.java.util.Optional<string> styleName = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseStyleName(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher(styleId, styleName);
        }
        public static Mammoth.Couscous.java.util.Optional<string> parseStyleId(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._DOT) {
                tokens.skip();
                return Mammoth.Couscous.java.util.Optional.of<string>(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<string> parseStyleName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._OPEN_SQUARE_BRACKET) {
                tokens.skip();
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "style-name");
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EQUALS);
                string value = tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CLOSE_SQUARE_BRACKET);
                return Mammoth.Couscous.java.util.Optional.of<string>(value.Substring(1, (value.Length - 1) - 1));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> parseNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._COLON) {
                tokens.skip();
                bool isOrdered = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parseListType(tokens);
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._OPEN_PAREN);
                string level = ((new Mammoth.Couscous.java.math.BigInteger(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER))).subtract(Mammoth.Couscous.java.math.BigInteger._ONE)).toString();
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CLOSE_PAREN);
                return Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(level, isOrdered));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>();
            }
        }
        public static bool parseListType(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token listType = tokens.next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER);
            string _couscous_tmp_8 = listType.getValue();
            if (_couscous_tmp_8.Equals("ordered-list")) {
                return true;
            } else if (_couscous_tmp_8.Equals("unordered-list")) {
                return false;
            } else {
                throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException(listType, "Unrecognised list type: " + listType);
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement> elements = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>();
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement element = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens);
                elements.add(element);
                while (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE && tokens.peekTokenType(1) == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._GREATER_THAN) {
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._GREATER_THAN);
                    tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                    elements.add(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseElement(tokens));
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath(elements);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement parseElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseTagNames(tokens);
            Mammoth.Couscous.java.util.List<string> classNames = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseClassNames(tokens);
            Mammoth.Couscous.java.util.Map<string, string> attributes = classNames.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("class", java.lang.String.join(" ", classNames));
            bool isFresh = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parseIsFresh(tokens);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tagNames, attributes, !isFresh);
        }
        public static Mammoth.Couscous.java.util.List<string> parseTagNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.List<string> tagNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            tagNames.add(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
            while (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CHOICE) {
                tokens.skip();
                tagNames.add(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
            }
            return tagNames;
        }
        public static Mammoth.Couscous.java.util.List<string> parseClassNames(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            Mammoth.Couscous.java.util.List<string> classNames = new Mammoth.Couscous.java.util.ArrayList<string>();
            while (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._DOT) {
                tokens.skip();
                classNames.add(tokens.nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER));
            }
            return classNames;
        }
        public static bool parseIsFresh(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._COLON) {
                tokens.skip();
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "fresh");
                return true;
            } else {
                return false;
            }
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMapParser_Anonymous_112 : Mammoth.Couscous.java.util.function.Consumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder> {
        internal Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> _documentMatcher;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _htmlPath;
        internal StyleMapParser_Anonymous_112(Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath) {
            this._documentMatcher = documentMatcher;
            this._htmlPath = htmlPath;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder styleMap) {
            (this._documentMatcher).accept(styleMap, this._htmlPath);
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
            int lineIndex = 0;
            while (lineIndex < lines.size()) {
                string line = lines.get(lineIndex);
                try {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.handleLine(styleMap, line);
                } catch (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException exception) {
                    throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.ParseException(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.generateErrorMessage(line, lineIndex + 1, exception.getToken(), exception.getMessage()));
                }
                lineIndex = lineIndex + 1;
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
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokenise(line));
            Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> documentMatcher = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.DocumentMatcherParser.parse(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._ARROW);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath htmlPath = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parseHtmlPath(tokens);
            tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser_Anonymous_112(documentMatcher, htmlPath);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath parseHtmlPath(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator tokens) {
            if (tokens.peekTokenType() == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath._EMPTY;
            } else {
                tokens.skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE);
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.HtmlPathParser.parse(tokens);
            }
        }
        public static string generateErrorMessage(string line, int lineNumber, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token token, string message) {
            return ((((((((("error reading style map at line " + lineNumber) + ", character ") + (token.getCharacterIndex() + 1)) + ": ") + message) + "\n\n") + line) + "\n") + Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.repeatString(" ", token.getCharacterIndex())) + "^";
        }
        public static string repeatString(string value, int times) {
            Mammoth.Couscous.java.lang.StringBuilder builder = new Mammoth.Couscous.java.lang.StringBuilder();
            int i = 0;
            while (i < times) {
                builder.append(value);
                i = i + 1;
            }
            return builder.toString();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class StyleMappingTokeniser {
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token> tokenise(string line) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token> tokens = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token>();
            int index = 0;
            while (index < line.Length) {
                Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token token = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.nextToken(line, index);
                tokens.add(token);
                index = index + (token.getValue()).Length;
            }
            tokens.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token(index, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EOF, ""));
            return tokens;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token nextToken(string line, int startIndex) {
            char nextChar = line.charAt(startIndex);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.tokenType(nextChar);
            int index = 0;
            if ((nextChar == 61 && startIndex + 1 < line.Length) && line.charAt(startIndex + 1) == 62) {
                tokenType = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._ARROW;
                index = startIndex + 2;
            } else {
                index = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.seekEndOfToken(line, startIndex + 1, tokenType);
                if (tokenType == Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING && index == line.Length + 1) {
                    tokenType = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNTERMINATED_STRING;
                    index = index - 1;
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token(startIndex, tokenType, line.Substring(startIndex, index - startIndex));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType(char nextChar) {
            if (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isAlphabetic(nextChar)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER;
            } else if (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isWhitespace(nextChar)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE;
            } else if (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isNumeric(nextChar)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER;
            } else {
                char _couscous_tmp_9 = nextChar;
                if (_couscous_tmp_9.equals(39)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING;
                } else if (_couscous_tmp_9.equals(46)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._DOT;
                } else if (_couscous_tmp_9.equals(58)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._COLON;
                } else if (_couscous_tmp_9.equals(62)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._GREATER_THAN;
                } else if (_couscous_tmp_9.equals(61)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._EQUALS;
                } else if (_couscous_tmp_9.equals(40)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._OPEN_PAREN;
                } else if (_couscous_tmp_9.equals(41)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CLOSE_PAREN;
                } else if (_couscous_tmp_9.equals(91)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._OPEN_SQUARE_BRACKET;
                } else if (_couscous_tmp_9.equals(93)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CLOSE_SQUARE_BRACKET;
                } else if (_couscous_tmp_9.equals(124)) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._CHOICE;
                } else {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._UNKNOWN;
                }
            }
        }
        public static int seekEndOfToken(string line, int index, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType _couscous_tmp_10 = tokenType;
            if (_couscous_tmp_10.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._WHITESPACE)) {
                while (index < line.Length && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isWhitespace(line.charAt(index))) {
                    index = index + 1;
                }
                return index;
            } else if (_couscous_tmp_10.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER)) {
                while (index < line.Length && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isIdentifierCharacter(line.charAt(index))) {
                    index = index + 1;
                }
                return index;
            } else if (_couscous_tmp_10.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._INTEGER)) {
                while (index < line.Length && Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isNumeric(line.charAt(index))) {
                    index = index + 1;
                }
                return index;
            } else if (_couscous_tmp_10.equals(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._STRING)) {
                while (index < line.Length && !(line.charAt(index) == 39)) {
                    index = index + 1;
                }
                index = index + 1;
                return index;
            } else {
                return index;
            }
        }
        public static bool isWhitespace(char c) {
            return c == 32 || c == 9;
        }
        public static bool isIdentifierCharacter(char c) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isAlphabetic(c) || Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMappingTokeniser.isNumeric(c)) || c == 45) || c == 95;
        }
        public static bool isAlphabetic(char nextChar) {
            return nextChar >= 97 && nextChar <= 122 || nextChar >= 65 && nextChar <= 90;
        }
        public static bool isNumeric(char c) {
            return c >= 48 && c <= 57;
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class Token {
        internal int _characterIndex;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType _tokenType;
        internal string _value;
        internal Token(int characterIndex, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType, string value) {
            this._characterIndex = characterIndex;
            this._tokenType = tokenType;
            this._value = value;
        }
        public int getCharacterIndex() {
            return this._characterIndex;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType getTokenType() {
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
    internal class TokenIterator {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token> _tokens;
        internal int _index;
        internal TokenIterator(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token> tokens) {
            this._tokens = tokens;
            this._index = 0;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType peekTokenType() {
            return ((this._tokens).get(this._index)).getTokenType();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType peekTokenType(int count) {
            return ((this._tokens).get(this._index + count)).getTokenType();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token next(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType type) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token token = (this._tokens).get(this._index);
            if (token.getTokenType() == type) {
                this._index = this._index + 1;
                return token;
            } else {
                throw this.unexpectedTokenType(type, token);
            }
        }
        public string nextValue(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType type) {
            return (this.next(type)).getValue();
        }
        public void skip() {
            this._index = this._index + 1;
        }
        public void skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token token = (this._tokens).get(this._index);
            if (!(token.getTokenType() == tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            this._index = this._index + 1;
        }
        public void skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType tokenType, string tokenValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token token = (this._tokens).get(this._index);
            if (!(token.getTokenType() == tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            string actualValue = token.getValue();
            if (!actualValue.Equals(tokenValue)) {
                throw new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException(token, (((("expected " + tokenType) + " token with value ") + tokenValue) + " but value was ") + actualValue);
            }
            this._index = this._index + 1;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException unexpectedTokenType(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType expected, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token actual) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException(actual, (("expected token of type " + expected) + " but was of type ") + actual.getTokenType());
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal enum TokenType {
        _WHITESPACE, _IDENTIFIER, _DOT, _COLON, _GREATER_THAN, _ARROW, _EQUALS, _OPEN_PAREN, _CLOSE_PAREN, _OPEN_SQUARE_BRACKET, _CLOSE_SQUARE_BRACKET, _STRING, _UNTERMINATED_STRING, _INTEGER, _CHOICE, _EOF, _UNKNOWN
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
    internal class NamespacePrefixes__Builder {
        internal Mammoth.Couscous.java.util.Map<string, string> _uriToPrefix;
        internal NamespacePrefixes__Builder() {
            this._uriToPrefix = new Mammoth.Couscous.java.util.HashMap<string, string>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder put(string prefix, string uri) {
            (this._uriToPrefix).put(uri, prefix);
            return this;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes build() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes(this._uriToPrefix);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class NamespacePrefixes {
        internal Mammoth.Couscous.java.util.Map<string, string> _uriToPrefix;
        internal NamespacePrefixes(Mammoth.Couscous.java.util.Map<string, string> uriToPrefix) {
            this._uriToPrefix = uriToPrefix;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder builder() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes__Builder();
        }
        public Mammoth.Couscous.java.util.Optional<string> prefixForUri(string uri) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._uriToPrefix, uri);
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
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return this;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.java.util.Optional.empty<string>();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement_Anonymous_113 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _name;
        internal XmlElement_Anonymous_113(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException(("Element has no '" + this._name) + "' attribute");
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement_Anonymous_114 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, string> {
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode arg0) {
            return arg0.innerText();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement_Anonymous_115 : Mammoth.Couscous.java.util.function.Predicate<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> {
        internal string _name;
        internal XmlElement_Anonymous_115(string name) {
            this._name = name;
        }
        public bool test(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return (child.getName()).Equals(this._name);
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
            return (this.getAttributeOrNone(name)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement_Anonymous_113(name));
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._attributes, name);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren() {
            return this._children;
        }
        public string innerText() {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, string>(this._children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement_Anonymous_114()));
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor) {
            return visitor.visit(this);
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children() {
            return this._children;
        }
        public string toString() {
            return ((((("XmlElement(name=" + this._name) + ", attributes=") + this._attributes) + ", children=") + this._children) + ")";
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList findChildren(string name) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.toList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this.findChildrenIterable(name)));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement findChild(string name) {
            return ((this.findChildrenIterable(name)).iterator()).next();
        }
        public bool hasChild(string name) {
            return ((this.findChildrenIterable(name)).iterator()).hasNext();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.getFirst<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike>(this.findChildrenIterable(name), Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement._INSTANCE);
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChildrenIterable(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._children, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement_Anonymous_115(name));
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal interface XmlElementLike {
        bool hasChild(string name);
        Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name);
        Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name);
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList_Anonymous_116 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>> {
        internal string _name;
        internal XmlElementList_Anonymous_116(string name) {
            this._name = name;
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return element.findChildren(this._name);
        }
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
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList_Anonymous_116(name)));
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
    internal class XmlParser__NodeGenerator_Anonymous_117 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator _this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        internal XmlParser__NodeGenerator_Anonymous_117(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator) {
            this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator = this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator;
        }
        public string apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName arg0) {
            return (this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser__NodeGenerator).readName(arg0);
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__NodeGenerator_Anonymous_118 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__NodeGenerator_Anonymous_118(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string get() {
            return (("{" + (this._name).getUri()) + "}") + (this._name).getLocalName();
        }
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal class XmlParser__NodeGenerator_Anonymous_119 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName _name;
        internal XmlParser__NodeGenerator_Anonymous_119(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            this._name = name;
        }
        public string apply(string prefix) {
            return (prefix + ":") + (this._name).getLocalName();
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
            Mammoth.Couscous.java.util.Map<string, string> simpleAttributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.eagerMapKeys<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName, string, string>(attributes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator_Anonymous_117(this));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder element = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlElementBuilder(this.readName(name), simpleAttributes);
            (this._elementStack).add(element);
        }
        public string readName(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.ElementName name) {
            if (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Strings.isNullOrEmpty(name.getUri())) {
                return name.getLocalName();
            } else {
                return ((((this._this_org__zwobble__mammoth__internal__xml__parsing__XmlParser)._namespaces).prefixForUri(name.getUri())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator_Anonymous_119(name))).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser__NodeGenerator_Anonymous_118(name));
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

