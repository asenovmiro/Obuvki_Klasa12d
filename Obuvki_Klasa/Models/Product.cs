namespace Obuvki_Klasa.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }//fk
        public Category Categories { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public DateTime RegistratiOn { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
