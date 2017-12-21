using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstAngularApp.Data
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        //IN CASE WE NEED THIS
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    new EmployeeMap(modelBuilder.Entity<Employee>());
        //}

        public DbSet<Employee> Employees { get; set; }
    }

    //public class EmployeeMap
    //{
    //    public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
    //    {
    //        entityBuilder.HasKey(t => t.Id);
    //        entityBuilder.Property(t => t.Firstname).IsRequired();
    //        entityBuilder.Property(t => t.Lastname).IsRequired();
    //    }
    //}
}
