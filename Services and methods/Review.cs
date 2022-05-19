public class Review{
    public bool CreateReview(Review review);
    public Review ViewReviewDetail(int review_Id);
    public Review EditReviewDetails(int review_Id, Review review);
    public bool CancelScheduledReview(int review_Id);
    public List<Review> GetListOfReviews(int reviewstatus_Id);
    public bool SubmitMOM(MOM mom);
    public MOM ViewMOM(int mom_Id);
    public MOM EditMOM(int mom_Id, MOM mom);
}
