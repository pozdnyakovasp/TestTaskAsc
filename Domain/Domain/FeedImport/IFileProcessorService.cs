using System.Threading.Tasks;

namespace Domain.FeedImport
{
    public interface IFileProcessorService
    {
        Task Process();
    }
}
