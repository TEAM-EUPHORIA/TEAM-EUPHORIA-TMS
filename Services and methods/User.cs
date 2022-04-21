public class User{
    public bool CreateUser(User user);

    public User ViewUserDetails(int user_Id);

    public User EditUserDetails(int user_Id);

    public bool DisableUser(int user_Id);

    public List<User> GetListOfUsers(int role_Id);
}