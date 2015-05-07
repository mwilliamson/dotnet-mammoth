# dotnet-mammoth: .docx to HTML converter

This project uses [Edge.js](http://tjanczuk.github.io/edge/) to allow [mammoth.js](https://github.com/mwilliamson/mammoth.js) to be used from .NET.

Mammoth is designed to convert .docx documents, such as those created by Microsoft Word, and convert them to HTML. Mammoth aims to produce simple and clean HTML by using semantic information in the document, and ignoring other details. For instance, Mammoth converts any paragraph with the style `Heading 1` to `h1` elements, rather than attempting to exactly copy the styling (font, text size, colour, etc.) of the heading.

There's a large mismatch between the structure used by .docx and the structure of HTML, meaning that the conversion is unlikely to be perfect for more complicated documents. Mammoth works best if you only use styles to semantically mark up your document.

## Installation

Install the package `Mammoth` from NuGet.

## Usage

Only the bare minimum case is currently supported:

```csharp
var documentConverter = new Mammoth.DocumentConverter();
var result = documentConverter.ConvertToHtml(@"path/to/document.docx");
// result.Value contains the HTML output
// result.Messages contains any messages produced during the conversion,
// such as warnings about unrecognised paragraph styles.
```

However, adding support for features that already exist in mammoth.js should be fairly straightforward,
so feel free to file a bug or pull request for any such feature (or any other feature, for that matter).
