namespace BakeryProject.CQRSPattern.Queries.FiveProduct
{
    public class GetFiveProductByIdQuery
    {
        public int Id { get; set; }

        public GetFiveProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
