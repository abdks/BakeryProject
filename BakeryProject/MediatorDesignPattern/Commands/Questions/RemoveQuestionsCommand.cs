using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Questions
{
    public class RemoveQuestionsCommand : IRequest
    {

        public int Id { get; set; }

        public RemoveQuestionsCommand(int id)
        {
            Id = id;
        }
    }
}
