using Microsoft.EntityFrameworkCore;
using WApiFlash.Model;

namespace WApiFlash.Data
{
    public class FlashDBContext:DbContext
    {
        public FlashDBContext(DbContextOptions<FlashDBContext>options)
            : base(options) { }
        public DbSet<Flash> Flashs { get; set; }
    }
}
