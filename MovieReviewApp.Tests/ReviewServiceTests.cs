using MovieReviewApp.Models;
using MovieReviewApp.Services;
using Xunit;

namespace MovieReviewApp.Tests
{
    public class ReviewServiceTests
    {
        [Fact]
        public void AddReview_IncreasesCount_And_CalculatesAverage()
        {
            var svc = new ReviewService();

            svc.AddReview(new Review { MovieTitle = "A", Rating = 4, Comment = "Good" });
            svc.AddReview(new Review { MovieTitle = "B", Rating = 2, Comment = "Ok" });

            var all = svc.GetAll();
            Assert.Equal(2, all.Count);
            Assert.Equal(3.0, svc.GetAverageRating(), 3);
        }

        [Fact]
        public void AddReview_InvalidRating_Throws()
        {
            var svc = new ReviewService();
            Assert.Throws<ArgumentOutOfRangeException>(() => svc.AddReview(new Review { MovieTitle = "X", Rating = 10 }));
        }
    }
}
