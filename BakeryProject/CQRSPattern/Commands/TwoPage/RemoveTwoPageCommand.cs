namespace BakeryProject.CQRSPattern.Commands.TwoPage
{
    public class RemoveTwoPageCommand
    {
        public int Id { get; set; }

        public RemoveTwoPageCommand(int id)
        {
            Id = id;
        }
    }
}
