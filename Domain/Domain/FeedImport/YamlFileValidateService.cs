using System.Collections.Generic;
using System.IO;

namespace Domain.FeedImport
{
    public class YamlFileValidateService : IFileValidateService
    {
        public YamlFileValidateService(/*settings*/)
        {
        }

        public IEnumerable<string> Validate(Stream fileStream)
        {
            if (fileStream.Length == 0)
            {
                yield return "File is empty";
            }
            fileStream.Position = 0;
            if (false)
            {
                yield return "Invalid";
            }
            //todo validate
        }
    }
}
