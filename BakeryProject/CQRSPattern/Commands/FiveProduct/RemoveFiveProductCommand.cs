namespace BakeryProject.CQRSPattern.Commands.FiveProduct
{
    public class RemoveFiveProductCommand
    {
        public int Id { get; set; }

        public RemoveFiveProductCommand(int id)
        {
            Id = id;
        }
    }
}
