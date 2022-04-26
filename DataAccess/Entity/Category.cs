using Core.Entities;

namespace DataAccess.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}