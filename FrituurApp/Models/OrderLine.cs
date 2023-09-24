namespace FrituurApp.Models
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public decimal Amount { get; set; }


        public virtual Order? Order { get; set; }
        public int? OrderID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
