public class Course{

    public Course CreateNewCourse();
    public Course EditCourse(int course_Id);
    public bool DeleteCourse(int course_Id);
    public List<Course> ViewListofCourse();
    public Topic AddTopicToCourse(int course_Id);
    public Topic UpdateContentToTopic(int topic_Id);
    public Topic EditContentOfTopic(int topic_Id);
    public bool DeleteTopicOfCourse(int topic_Id);
    public List<Topic> GetListOfTopicsByCourse(int course_Id);

    //Asssignment
    public Assignment AddAssignmentToTopic(int topic_Id);
    public AssignmentStatus SubmitAnswerToAssignment(int assignment_Id);
    public Assignment EditAnswerToAssignment(int assignment_Id);
    public Assignment DeleteSubmitedAssignment(int assignment_Id);
    public List<Assignment> GetListofAssignment(int topic_Id);

    //Attendance
    public AttendanceStatus SubmitAttendance(int user_Id);
    public List<Attendance> GetTopicAttendance(int topic_Id);
    
    //Feedback
    public CourseFeedback GiveFeedbackAboutCourse(int course_Id);
    public CourseFeedback EditFeedbackAboutCourse(int feedback_Id);
    public List<CourseFeedback> GetListOfFeedbackAboutCourse();

    public TraineeFeedback GiveFeedbackAboutTrainee(int trainee_Id);
    public TraineeFeedback EditFeedbackAboutTrainee(int t_feedback_Id);
    public List<TraineeFeedback> GetListOfFeedbackAboutTrainee();
}