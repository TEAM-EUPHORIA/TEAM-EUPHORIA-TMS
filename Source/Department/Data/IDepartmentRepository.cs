using Department.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department.Data
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<DepartmentModel>> Search(string departmentname);
        Task<IEnumerable<DepartmentModel>> GetDepartments();
        Task<DepartmentModel> GetDepartment(int DepartmentId);
        Task<DepartmentModel> AddDepartment(DepartmentModel department);
        Task<DepartmentModel> UpdateDepartment(string departmentname);
        Task DeleteDepartment(int DepartmentId);
    }
    
}