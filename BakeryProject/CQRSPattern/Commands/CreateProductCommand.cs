namespace BakeryProject.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
}
