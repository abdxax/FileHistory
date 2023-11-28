using FileHistory.Data;
using FileHistory.Dots;
using FileHistory.Models;
using FileHistory.Repstory;

namespace FileHistory.Service
{
    public class DepartmentService : IDepartmentRepstory
    {
        private readonly FileDBContext _db;
        public DepartmentService(FileDBContext db)
        {
            _db = db;
        }
        public void addDepartment(Depart department)
        {
           var dep=new Department();
            dep.departNmae = department.departNmae;
            _db.departments.Add(dep);
            _db.SaveChanges();
        }

        public List<Department> departments()
        {
           return _db.departments.ToList();
        }
    }
}
