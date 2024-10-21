namespace CollectionTracker.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public int CollectionId { get; set; }
    }
}