public class Role{
    public Role CreateNewRole();

    public Role EditRole(int role_Id);

    public Role DeleteRole(int role_Id);

    public List<Role> ViewListOfRoles();

    public List<User> GetUserByRole(int role_Id);
}
