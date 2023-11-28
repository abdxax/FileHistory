using FileHistory.Dots;
using FileHistory.Models;

namespace FileHistory.Repstory
{
    public interface IDepartmentRepstory
    {
        List<Department> departments();
        void addDepartment(Depart department);
    }
}
