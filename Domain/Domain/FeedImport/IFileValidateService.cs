using System.Collections.Generic;
using System.IO;

namespace Domain.FeedImport
{
    public interface IFileValidateService
    {
        IEnumerable<string> Validate(Stream file);
    }
}
