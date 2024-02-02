namespace BakeryProject.CQRSPattern.Commands.Service
{
    public class RemoveServiceCommand
    {
        public int Id { get; set; }

        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}
