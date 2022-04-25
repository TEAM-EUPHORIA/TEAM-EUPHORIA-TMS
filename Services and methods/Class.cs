<<<<<<< HEAD
namespace TMS{
    public class User{
        public int User_Id;
         public string Name;
         public string Email;
         public int Department_Id;
         public int Role_Id;
         public byte[] Image ;
         public bool IsActive;

    }
    public class Role{
        public int Role_Id;
        public string Role_Name;

    }
    public class Department{
        public int Department_Id;
        public string Department_Name;

    }
    public class Course{
        public int Course_Id;
        public string Course_Name;
        public string Description;
        public string Course_Duration;
        public int Topic_id;
        public string Topic_Name;
        public string Topic_Content;
        public string Topic_Duration;
        public int Attendance_Id;
        public int Attendance_StatusId;
        public string Attendance_StatusName;
        public int Assignment_Id;
        public int Assignment_StatusId;
        public string Assignment_StatusName;
        public int Course_FeedbackId;
        public string Course_FeedbackContent;
        public float Course_Ratings;
        public int Trainee_FeedbackId;
        public string Trainee_FeedbackContent;
        public float Trainee_Ratings;

        public int CourseTrainee_MappingId;

    }

    public class Review{
        public int Review_Id;
        public DateTime Review_Date;
        public DateTime Review_Time;
        public string Mode;
        public int Review_StatusId;
        public string Review_StatusName;
        public int Mom_Id;
        public string Agenda;
        public string Meeting_Notes;
        public string Purpose_OfMeeting;
        public int Mom_StatusId;
        public string Mom_StatusName;
=======
namespace TMS
{
    public class User{

    }
    public class Role{

    }
    public class Department{

    }
    public class Review{
        
>>>>>>> 2bc7e680fb58ad9947c6c0ed7f69ee4fefad07e3
    }
}