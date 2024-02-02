namespace BakeryProject.CQRSPattern.Commands.Main
{
    public class RemoveMainCommand
    {
        public int Id { get; set; }

        public RemoveMainCommand(int id)
        {
            Id = id;
        }
    }
}
