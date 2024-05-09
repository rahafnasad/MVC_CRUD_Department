using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_Department.data;
using MVC_CRUD_Department.Models;

namespace MVC_CRUD_Department.Controllers
{
    public class DepartmentsController : Controller
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var department = context.Departments.ToList();
            return View("Index", department);
        }
        public IActionResult Detalis(int id)
        {


            var department = context.Departments.Find(id);
            Console.WriteLine(department);
            return View("Detalis", department);
        }

        public IActionResult create() {
            return View("create");
        }
        
             public IActionResult store(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Delete
        public IActionResult Delete(int  id)
        {
            var department = context.Departments.Find(id);
            context.Departments.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Update
        public IActionResult Update(int id)
        {
            var department = context.Departments.Find(id);

            return View("Update", department);
        }
        //storeUpdata
        public IActionResult storeUpdata(Department updatedDepartment)
        {
            Console.WriteLine(updatedDepartment.Id);
            var oldDepartment = context.Departments.Find(updatedDepartment.Id);

            if (oldDepartment != null)
            {
                oldDepartment.Name = updatedDepartment.Name;
                oldDepartment.Description = updatedDepartment.Description;

                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
