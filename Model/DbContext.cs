using Microsoft.EntityFrameworkCore;
using SchoolActivity.Model.Models;

namespace SchoolActivity.Model
{
    public class SchoolActivityContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        // The following configures EF to create a Sqlite database file as `C:\school_activity.db`.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\Bruno\school_activity.db");
    }
}