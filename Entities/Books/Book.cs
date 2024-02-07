namespace Entities.Books
{
    public class Book
    {
        public string id { get; set; }
        public string type { get; set; }
        public AttributesBook attributes { get; set; }
        public LinkBooks links { get; set; }
        public RelationshipsBook relationships { get; set; }
    }
}
