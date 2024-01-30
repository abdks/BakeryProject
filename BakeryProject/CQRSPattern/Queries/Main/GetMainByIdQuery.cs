namespace BakeryProject.CQRSPattern.Queries.Main
{
    public class GetMainByIdQuery
    {
        public int Id { get; set; }

        public GetMainByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
