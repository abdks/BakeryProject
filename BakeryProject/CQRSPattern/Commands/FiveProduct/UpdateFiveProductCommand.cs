namespace BakeryProject.CQRSPattern.Commands.FiveProduct
{
    public class UpdateFiveProductCommand
    {
        public int fiveProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
