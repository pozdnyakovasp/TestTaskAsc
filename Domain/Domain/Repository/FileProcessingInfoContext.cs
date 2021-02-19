using Domain.BackgroundWorkers;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository
{
    public class FileProcessingInfoContext : DbContext
    {
        public FileProcessingInfoContext(DbContextOptions<FileProcessingInfoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FileProcessingInfoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FileProcessingInfo> Files { get; set; }
    }
}
