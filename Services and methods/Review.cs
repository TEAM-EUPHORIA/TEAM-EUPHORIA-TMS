public class Review{
    public Review ScheduleReview(int trainee_Id, int reviewer_Id){}

    public Review UpdateReviewDetails(int review_Id);

    public ReviewStatus CancelScheduledReview(int review_Id);

    public Review GetReviewDetail(int review_Id);

    public MOM SubmitMOM(int review_Id);

    public MOM EditMOM(int mom_Id);

    public List<MOM> GetMOMListbyTrainee(int trainee_Id);

    public ReviewStatus UpdateReviewStatus(int review_Id);

    public List<Review> GetCompletedReview(int reviewstatus_Id);

    public List<Review> GetIncompletedReview(int reviewstatus_Id);
}

public class student{

    public void Setid(){

    }
    public int GetID(){
        int Id;
        return Id;
    }
}