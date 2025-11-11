using MovieReviewApp.Models;

namespace MovieReviewApp.Services
{
    public class ReviewService
    {
        private readonly List<Review> _reviews = new();

        public IReadOnlyList<Review> GetAll() => _reviews.AsReadOnly();

        public void AddReview(Review r)
        {
            if (r == null) throw new ArgumentNullException(nameof(r));
            if (r.Rating < 1 || r.Rating > 5) throw new ArgumentOutOfRangeException(nameof(r.Rating));
            _reviews.Add(r);
        }

        public double GetAverageRating()
        {
            if (!_reviews.Any()) return 0.0;
            return _reviews.Average(r => r.Rating);
        }
    }
}
