public class User{
    public bool CreateUser(User user);

    public User ViewUserDetails(int user_Id);

    public User EditUserDetails(int user_Id, User user);

    public bool DisableUser(int user_Id);

    public List<User> GetListOfUsers(int role_Id);

    public List<User> GetUsersByDepartment(int dept_Id);
}