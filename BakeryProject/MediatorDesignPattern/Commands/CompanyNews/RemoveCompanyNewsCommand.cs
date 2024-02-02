using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.CompanyNews
{
    public class RemoveCompanyNewsCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveCompanyNewsCommand(int id)
        {
            Id = id;
        }
    }
}
