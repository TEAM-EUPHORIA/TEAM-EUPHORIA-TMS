public class Department{
    public bool CreateDepartment(Department department);

    public Department EditDepartment(int dept_Id);

    public bool DeleteDepartment(int dept_Id);
    public List<Department> GetListOfDepartment();

    // For Filters

    public List<User> GetUserByDepartment(int dept_Id);
    public List<Course> GetCourseByDepartment(int dept_Id);
}