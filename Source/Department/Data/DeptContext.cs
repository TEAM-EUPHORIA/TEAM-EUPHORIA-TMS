using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace COREMVC.Model;
public class DeptContext : DbContext{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ASPIREREN019;Initial Catalog=TrainingMS;Integrated Security=true;");
    }
    public DbSet<Department> Departments { get; set; }
}