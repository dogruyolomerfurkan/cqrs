namespace Business.CQRS.Commands.Category.Response
{
    public class CreateCategoryResponse
    {
        public bool Result { get; set; }
        public int? ProductId { get; set; }
    }
}