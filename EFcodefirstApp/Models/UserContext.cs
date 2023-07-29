using Microsoft.EntityFrameworkCore;

namespace EFcodefirstApp.Models
{
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<users> users { get; set; }
    }
}
