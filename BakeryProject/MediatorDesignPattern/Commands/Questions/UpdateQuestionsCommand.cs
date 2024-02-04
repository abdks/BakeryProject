using MediatR;

namespace BakeryProject.MediatorDesignPattern.Commands.Questions
{
    public class UpdateQuestionsCommand : IRequest
    {
        public int QuestionsID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}
