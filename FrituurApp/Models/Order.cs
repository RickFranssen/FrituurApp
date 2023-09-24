namespace FrituurApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        public virtual Customer? Customer { get; set; }
        public int CustomerID { get; set; }

        public virtual ICollection<OrderLine> Orderlines { get; set; }
    }
}
