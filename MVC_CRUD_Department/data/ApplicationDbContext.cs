using Microsoft.EntityFrameworkCore;
using MVC_CRUD_Department.Migrations;
using MVC_CRUD_Department.Models;

namespace MVC_CRUD_Department.data
{

    public class ApplicationDbContext: DbContext
    {
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db4806.public.databaseasp.net; Database=db4806; User Id=db4806; Password=hW!79yJ?D8#q; Encrypt=False; MultipleActiveResultSets=True;");
        }
    }
}
