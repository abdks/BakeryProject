namespace BakeryProject.CQRSPattern.Results.TwoPage
{
    public class GetTwoPageQueryResult
    {
        public int TwoPageID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string Unvan { get; set; }
    }
}
