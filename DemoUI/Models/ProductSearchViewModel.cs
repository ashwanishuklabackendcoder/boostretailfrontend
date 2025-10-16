namespace DemoUI.Models
{
    public class ProductSearchViewModel
    {
        // Filters
        public int? Supplier { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? ProductType { get; set; }
        public int? GenderOrAge { get; set; }
        public int? Year { get; set; }

        public string MPN { get; set; }
        public string Barcode { get; set; }
        public string Title { get; set; }

        // Result list
        public List<ProductListItem> Products { get; set; }
    }

    public class ProductListItem
    {
        public string MPN { get; set; }
        public string Barcode { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public decimal? Price { get; set; }
    }

}
