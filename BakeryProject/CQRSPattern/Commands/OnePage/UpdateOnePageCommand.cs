namespace BakeryProject.CQRSPattern.Commands.OnePage
{
    public class UpdateOnePageCommand
    {
        public int OnePageID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
