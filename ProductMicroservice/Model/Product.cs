namespace ProductMicroservice.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set;}
        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public string ISBN { get; internal set; }
        public int ListPrice { get; internal set; }
        public int Price50 { get; internal set; }
        public int Price100 { get; internal set; }
        public string ImageUrl { get; internal set; }

    }

}
