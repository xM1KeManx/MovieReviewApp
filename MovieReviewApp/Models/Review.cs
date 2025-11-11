namespace MovieReviewApp.Models
{
    public class Review
    {
        public string MovieTitle { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; } // 1..5
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
