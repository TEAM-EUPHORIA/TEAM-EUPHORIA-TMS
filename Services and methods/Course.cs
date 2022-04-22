public class Course{

    public bool CreateCourse(Course course);
    public Course ViewCourse(int course_Id);
    public Course EditCourse(int course_Id);
    public bool DeleteCourse(int course_Id);
    public List<Course> ViewListofCourse();
    
    // Topics
    public bool AddTopic(Topic topic);
    public Topic ViewTopic(int course_Id,int topic_Id);
    public Topic EditTopic(int course_Id,int topic_Id);
    public bool DeleteTopic(int course_Id,int topic_Id);
    public List<Topic> GetListOfTopicsByCourse(int course_Id);

    //Asssignment
    public bool SubmitAssignment(Assignment assignment);
    public Assignment ViewAssignment(int assignment_Id);
    public Assignment EditAssignment(int assignment_Id, Assignment assignment);
    public bool DeleteAssignment(int assignment_Id);
    public List<Assignment> GetListOfAssignment(int user_Id);
    

    //Attendance
    public bool SubmitAttendance(Attendance attendance);
    public List<Attendance> ViewTopicAttendance(int course_Id,int topic_Id);
    
    //Feedback
    public bool GiveFeedbackAboutCourse(CourseFeedback courseFeedback);
    public CourseFeedback ViewFeedbackByUserId(int c_feedback_Id);
    public CourseFeedback EditFeedbackAboutCourse(int c_feedback_Id);

    public bool GiveFeedbackAboutTrainee(TraineeFeedback traineeFeedback);
    public TraineeFeedback ViewFeedbackAboutTrainee(int t_feedback_Id);
    public TraineeFeedback EditFeedbackAboutTrainee(int t_feedback_Id);
}