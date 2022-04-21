public class Department{
    public bool CreateDepartment(Department department);

    public Department EditDepartment(int dept_Id);

    public bool DisableDepartment(int dept_Id);
    public List<Department> GetListOfDepartment();

    // For Filters

    public List<User> GetUsersByDepartment(int dept_Id);
    public List<Course> GetCoursesByDepartment(int dept_Id);
}