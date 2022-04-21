public class User{
    public User CreateNewUser();

    public User AssignUserToRole(int user_Id,int role_Id);

    public User AssignUserToDepartment(int user_Id,int dept_Id);

    public User EditUserDetails(int user_Id);

    public bool DisableUser(int user_Id);

    public List<User> GetListOfUsers();
        
}