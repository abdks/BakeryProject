namespace BakeryProject.CQRSPattern.Commands.OnePage
{
    public class RemoveOnePageCommand
    {
        public int Id { get; set; }

        public RemoveOnePageCommand(int id)
        {
            Id = id;
        }
    }
}
