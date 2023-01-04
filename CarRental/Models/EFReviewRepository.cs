namespace CarRental.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        private AppDbContext context;

        public EFReviewRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Review> Reviews => context.reviews;

        public Review Delete(int id)
        {
           Review dbEntry = context.reviews.FirstOrDefault(r => r.Id == id);
            if(dbEntry != null)
            {
                context.reviews.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void Save(Review review)
        {
            if(review.Id == 0)
                context.Add(review);
            else
            {
                Review dbEntry = context.reviews.FirstOrDefault(r=>r.Id == review.Id);
                if( dbEntry != null)
                {
                    dbEntry.Description = review.Description;
                    dbEntry.Rating = review.Rating;
                    dbEntry.CarId = review.CarId;
                }
            }
            context.SaveChanges();
        }
    }
}
