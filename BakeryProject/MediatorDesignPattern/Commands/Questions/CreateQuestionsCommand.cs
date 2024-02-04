using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Questions
{
    public class CreateQuestionsCommand : IRequest
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
