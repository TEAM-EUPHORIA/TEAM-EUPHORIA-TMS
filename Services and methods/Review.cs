public class Review{
    public bool CreateReview(Review review);
    public Review ViewReviewDetail(int review_Id);
    public Review EditReviewDetails(int review_Id);
    public ReviewStatus CancelScheduledReview(int review_Id);

    //public ReviewStatus UpdateReviewStatus(int review_Id);
    public List<Review> GetListOfReviews(int reviewstatus_Id);
    public bool SubmitMOM(MOM mom);
    public MOM EditMOM(int mom_Id);

    // public List<Review> GetCompletedReview(int reviewstatus_Id);
    // public List<Review> GetPendingReview(int reviewstatus_Id);
}
