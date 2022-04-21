public class Department{
    public Department CreateNewDepartment();

    public Department EditDepartment(int dept_Id);

    public bool DeleteDepartment(int dept_Id);

    public List<Department> GetListOfDepartment();

    public List<User> GetUserByDepartment(int dept_Id);
}