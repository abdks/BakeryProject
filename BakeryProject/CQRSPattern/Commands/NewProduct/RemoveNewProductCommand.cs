namespace BakeryProject.CQRSPattern.Commands.NewProduct
{
    public class RemoveNewProductCommand
    {
        public int Id { get; set; }

        public RemoveNewProductCommand(int id)
        {
            Id = id;
        }
    }
}
