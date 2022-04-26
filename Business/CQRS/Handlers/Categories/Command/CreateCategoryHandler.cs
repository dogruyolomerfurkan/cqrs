using System.Threading;
using System.Threading.Tasks;
using Business.CQRS.Commands.Category.Request;
using Business.CQRS.Commands.Category.Response;
using DataAccess.Context;
using DataAccess.Entity;
using Mapster;
using MediatR;

namespace Business.CQRS.Handlers.Categories.Command
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryRequest, CreateCategoryResponse>
    {
        private readonly MPDbContext _dbContext;
        public CreateCategoryHandler(MPDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateCategoryResponse> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var newCategory = request.Adapt<Category>();
            await _dbContext.AddAsync(newCategory);
            return await _dbContext.SaveChangesAsync() > 0 ?
            new CreateCategoryResponse { ProductId = newCategory.Id, Result = true }
            : new CreateCategoryResponse { Result = false };
        }
    }
}