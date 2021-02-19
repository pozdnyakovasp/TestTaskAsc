using Domain.Infrastructure;
using System;

namespace Domain.BackgroundWorkers
{
    public class FileProcessingInfo : IAggregateRoot
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CompanyId { get; set; }
        public string Link { get; set; }
        public DateTime CreateTime { get; set; }
        public int Priority { get; set; }
        public UpdateTaskStatus Status { get; set; }
        public string FailMessage { get; set; }
        public UploadFiletype FileType { get; set; }
        public DownloadSource DownloadSource { get; set; }

        public int Key => Id;
    }
}
