using BankQueueAPI;
using Microsoft.EntityFrameworkCore;

public class QueueDbContext : DbContext
{
    public QueueDbContext(DbContextOptions<QueueDbContext> options) : base(options) { }

    public DbSet<QueueItem> QueueItems { get; set; }
}