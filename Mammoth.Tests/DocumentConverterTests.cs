using NUnit.Framework;

namespace Mammoth.Tests
{
    public class DocumentConverterTests
    {
        [Test]
        public void SingleWordParagraphIsConvertedToSingleHtmlParagraph()
        {
            var documentConverter = new DocumentConverter();
            var result = documentConverter.ConvertToHtml("TestDocuments/single-paragraph.docx");
            Assert.AreEqual("<p>Walking on imported air</p>", result.Value);
            Assert.IsEmpty(result.Messages);
        }

        [Test]
        public void UnrecognisedStylesAreStatedInMessages()
        {
            var documentConverter = new DocumentConverter();
            var result = documentConverter.ConvertToHtml("TestDocuments/unrecognised-paragraph-styles.docx");
            Assert.AreEqual("Unrecognised paragraph style: 'Funky' (Style ID: style20)", result.Messages[0].Value);
        }
    }
}
