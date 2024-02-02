using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.CompanyNews
{
    public class CreateCompanyNewsCommand:IRequest
    {
        public string Date { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
}
