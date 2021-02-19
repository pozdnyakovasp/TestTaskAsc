using Domain.BackgroundWorkers;
using System.Linq;

namespace Domain.Repository
{
    public class FileProcessingInfoRepository : IFileProcessingInfoRepository
    {
        private readonly FileProcessingInfoContext _context;

        public FileProcessingInfoRepository(FileProcessingInfoContext context)
        {
            _context = context;
        }

        public void Add(FileProcessingInfo entity)
        {
            _context.Files.Add(entity);
        }

        public FileProcessingInfo GetBy(int id)
        {
            return _context.Files.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
