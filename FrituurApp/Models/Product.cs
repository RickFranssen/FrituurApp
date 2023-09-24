namespace FrituurApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductCategory { get; set; }
        public decimal? ProductPrice { get; set; }
        public string? ProductPhoto { get; set; }

        public virtual Administrator? Administrator { get; set; }
        public int? AdministratorID { get; set; }

        public virtual OrderLine? OrderLine { get; set; }
        public int? OrderLineID { get; set; }

        public virtual Customer? Customer { get; set; }
        public int? CustomerID { get; set; }
    }
}
