namespace DemoUI.Models
{
    public class SupplierFeed
    {
        public int Id { get; set; }
        public string Supplier { get; set; }
        public string FeedName { get; set; }
        public string FeedAddress { get; set; }
        public string ApiKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
