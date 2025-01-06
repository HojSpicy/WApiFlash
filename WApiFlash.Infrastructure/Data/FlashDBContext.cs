using Microsoft.EntityFrameworkCore;
using WApiFlash.Domain.Models;

namespace WApiFlash.Infrastructure.Data
{
    public class FlashDBContext:DbContext
    {
        public FlashDBContext(DbContextOptions<FlashDBContext>options)
            : base(options) { }
        public DbSet<Flash> Flashs { get; set; }
    }
}
