namespace BakeryProject.CQRSPattern.Commands.Slider
{
    public class RemoveSliderCommand
    {
        public int Id { get; set; }

        public RemoveSliderCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
