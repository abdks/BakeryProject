namespace BakeryProject.CQRSPattern.Commands.NewProduct
{
    public class CreateNewProductCommand
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string DescriptionBold { get; set; }
        public string Image { get; set; }
    }
}
