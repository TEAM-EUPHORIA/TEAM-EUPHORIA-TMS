public class Department{
    public bool CreateDepartment(Department department);

    public Department UpdateDepartment(int dept_Id, Department department);

    public bool DisableDepartment(int dept_Id);

    public List<Department> GetListOfDepartment();
}