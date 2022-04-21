public class Role{
    public Role CreateNewRole();

    public Role EditRole(int role_Id);

    public bool DeleteRole(int role_Id);

    public List<Role> GetListOfRoles();

    public List<User> GetUserByRole(int role_Id);
}
