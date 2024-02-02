namespace BakeryProject.CQRSPattern.Commands.Service
{
    public class UpdateServiceCommand
    {
        public int ServicesID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
