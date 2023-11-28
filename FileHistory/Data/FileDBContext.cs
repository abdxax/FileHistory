using FileHistory.Models;
using Microsoft.EntityFrameworkCore;

namespace FileHistory.Data
{
    public class FileDBContext:DbContext
    {

        public FileDBContext(DbContextOptions options) : base(options) {
        
        }
        public FileDBContext()
        {

        }

        public DbSet<Department> departments { get; set; }
    }
}
