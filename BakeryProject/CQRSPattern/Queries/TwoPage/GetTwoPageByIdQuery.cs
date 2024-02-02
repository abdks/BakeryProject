namespace BakeryProject.CQRSPattern.Queries.TwoPage
{
    public class GetTwoPageByIdQuery
    {
        public int Id { get; set; }

        public GetTwoPageByIdQuery(int id)
        {
            Id = id;
        }
    }
}
