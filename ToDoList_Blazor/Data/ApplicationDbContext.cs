using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoList_Blazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
		public DbSet<Todo> Todos { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Todo>(entity =>
			{
				entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
				entity.Property(e => e.Date).IsRequired();
				entity.Property(e => e.Priority).IsRequired();
				entity.Property(e => e.Status).IsRequired();
				entity.Property(e => e.Content).IsRequired();
				entity.Property(e => e.UserId).IsRequired();
			});
		}
	}
}
