using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Department.Model;

namespace Department.Data;
public class DeptContext : DbContext{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer("DeptConnection");
    }
    public DbSet<DepartmentModel> Departmentmodels { get; set; }
}