namespace BakeryProject.CQRSPattern.Queries.OnePage
{
    public class GetOnePageByIdQuery
    {
        public int Id { get; set; }

        public GetOnePageByIdQuery(int id)
        {
            Id = id;
        }
    }
}
