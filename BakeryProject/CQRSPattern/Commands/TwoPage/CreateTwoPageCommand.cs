namespace BakeryProject.CQRSPattern.Commands.TwoPage
{
    public class CreateTwoPageCommand
    {
       
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NameSurname { get; set; }
        public string Unvan { get; set; }
    }
}
