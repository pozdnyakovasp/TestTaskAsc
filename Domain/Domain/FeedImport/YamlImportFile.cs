using System;
using System.IO;

namespace Domain.FeedImport
{
    public class YamlImportFile : IImportFile
    {
        private readonly string _filePath;

        public YamlImportFile(string filePath)
        {
            _filePath = filePath;
        }

        // хз почему поток) можно и массив байт
        public Stream GetFileStream()
        {
            if (!File.Exists(_filePath))
            {
                throw new InvalidOperationException("file not found");
            }

            var fileBytes = File.ReadAllBytes(_filePath);
            var fileStream = new MemoryStream(fileBytes);
            return fileStream;
        }
    }
}
