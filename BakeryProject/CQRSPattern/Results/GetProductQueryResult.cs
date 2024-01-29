namespace BakeryProject.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
}
