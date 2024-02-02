namespace BakeryProject.CQRSPattern.Queries.NewProduct
{
    public class GetNewProductByIdQuery
    {
        public int Id { get; set; }

        public GetNewProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
