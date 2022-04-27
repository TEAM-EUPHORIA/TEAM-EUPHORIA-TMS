using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department.Data;

namespace Department.Model
{
    public class DepartmentRepository : IDepartmentRepository{
        private readonly DeptContext appdepartment;
        public DepartmentRepository(DeptContext appdeptcontext)
        {
            this.appdepartment=appdeptcontext;
        }
        public Task<IEnumerable<DepartmentModel>> Search(string departmentname){
            throw new NotImplementedException();
        }
        public Task<IEnumerable<DepartmentModel>> GetDepartments(){
            throw new NotImplementedException();

        }
        public Task<DepartmentModel> GetDepartment(int DepartmentId){

            throw new NotImplementedException();
        }
        public Task<DepartmentModel> AddDepartment(DepartmentModel department){

            throw new NotImplementedException();
        }
        public Task<DepartmentModel> UpdateDepartment(string departmentname){

            throw new NotImplementedException();
        }
        public Task DeleteDepartment(int DepartmentId){
            throw new NotImplementedException();

        }

    }
}