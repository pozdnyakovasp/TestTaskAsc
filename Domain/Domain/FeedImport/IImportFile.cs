using System.IO;

namespace Domain.FeedImport
{
    public interface IImportFile
    {
        Stream GetFileStream();
    }
}
