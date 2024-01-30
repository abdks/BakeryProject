namespace BakeryProject.CQRSPattern.Queries.Slider
{
    public class GetSliderByIdQuery
    {
        public int Id { get; set; }

        public GetSliderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
