namespace BakeryProject.CQRSPattern.Results.NewProduct
{
    public class GetNewProductQueryResult
    {
        public int NewProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string DescriptionBold { get; set; }
        public string Image { get; set; }
    }
}
