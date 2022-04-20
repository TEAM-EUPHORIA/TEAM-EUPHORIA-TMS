public class Review{
    public void ScheduleReview(int trainee_Id, int reviewer_Id);

    public void UpdateReviewDetails(int review_Id);

    public void CancelScheduledReview(int review_Id);

    public void GetReviewDetail(int review_Id);

    public void SubmitMOM(int review_Id);

    public void EditMOM(int review_Id);

    public void GetMOMListbyTrainee(int trainee_Id);

    public void UpdateReviewStatus(int review_Id);

    public void GetCompletedReview();

    public void GetIncompletedReview();
}