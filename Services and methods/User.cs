public class User{
    public bool CreateUser(User user);

    public User EditUserDetails(int user_Id);

    public bool DisableUser(int user_Id);

    public List<User> GetListOfUsers();
        
}