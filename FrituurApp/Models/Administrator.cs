namespace FrituurApp.Models
{
    public class Administrator
    {
        public int AdministratorID { get; set; }
        public string? AdministratorName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
