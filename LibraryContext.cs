using Library.DataTbl;
using Microsoft.EntityFrameworkCore;

namespace Library
    {
    public class LibraryContext:DbContext
        {
        public LibraryContext(DbContextOptions options) : base(options)
            { }

        public DbSet<Publications> publications { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Students> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<IssueBook> issueBooks { get; set; }
        public DbSet<Permission> permissions { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<RoleAssignment> roleAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Students>()
                .HasIndex(e => e.RollNumber)
                .IsUnique();
            }
        }
    }
