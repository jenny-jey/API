namespace ProductService.Models
{
    public class Products
    {
        public int ProductID {get;set;}
        public string ProductName {get;set;}
        public string ProductCode {get;set;}
        public string ReleaseDate {get;set;}
        public string Description {get;set;}
        public float Price {get;set;}
        public float StarRating {get;set;}
        public string ImageUrl {get;set;}
    }
}