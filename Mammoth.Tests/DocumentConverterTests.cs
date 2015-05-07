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
    }
}
