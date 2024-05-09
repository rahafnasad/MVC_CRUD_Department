using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD_Department.Models
{
    public class Department
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
