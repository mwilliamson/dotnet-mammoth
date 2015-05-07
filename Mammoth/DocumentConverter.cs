using EdgeJs;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Mammoth
{
    public class DocumentConverter
    {
        public Result<string> ConvertToHtml(string path)
        {
            var mammothJs = ReadResource("Mammoth.mammoth.browser.js") + ReadResource("Mammoth.mammoth.edge.js");
            
            var f = Edge.Func(mammothJs);
            var result = f(File.ReadAllBytes(path));
            Task.WaitAll(result);

            return new Result<string>((string)result.Result, new List<Message>());
        }

        private static string ReadResource(string resourceName)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            using (var stream = currentAssembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
