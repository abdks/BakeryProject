namespace BakeryProject.CQRSPattern.Results.Service
{
    public class GetServiceByIdQueryResult
    {
        public int ServicesID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
