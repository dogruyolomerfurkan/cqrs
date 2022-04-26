using Business.CQRS.Commands.Category.Response;
using MediatR;

namespace Business.CQRS.Commands.Category.Request
{
    public class CreateCategoryRequest : IRequest<CreateCategoryResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CUserId { get; set; }
    }
}