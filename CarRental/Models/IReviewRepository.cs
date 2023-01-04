namespace CarRental.Models
{
    public interface IReviewRepository
    {
        IEnumerable<Review> Reviews { get; }

        void Save (Review review);
        Review Delete (int id);
    }
}
