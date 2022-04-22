using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Department.Model;

namespace Department.Context
{
    public class DeptDbContext : DbContext
    {
        public DeptDbContext(DbContextOptions<DeptDbContext> options)
            : base(options)
        {
        }

        public DbSet<Deptattribute> deptattributes { get; set; } =null! ;
    }
}