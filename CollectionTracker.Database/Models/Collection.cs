namespace CollectionTracker.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BannerImg { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<Item> Items { get; set; }

    }
}