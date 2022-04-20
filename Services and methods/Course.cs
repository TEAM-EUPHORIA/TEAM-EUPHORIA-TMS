public class Course{

    public Course CreateNewCourse();

    public Course EditCourse(int course_Id);

    public bool DeleteCourse(int course_Id);

    public List<Course> ViewListofCourse();

    public Topic AddTopicToCourse(int course_Id);

    public Topic AddContentToTopic(int topic_Id);

    public Assignment AddAssignmentToTopic(int topic_Id);

    public void SubmitAnswerToAssignment(int topic_Id);

    public void EditAnswerToAssignment(int topic_Id);

    public AttendanceStatus SubmitAttendance(int user_Id);

    public Feedback GiveFeedbackAboutCourse(int course_Id);

    public Feedback EditFeedbackAboutCourse(int course_Id);

    public List<Feedback> ListOfFeedbackAboutCourse();
}