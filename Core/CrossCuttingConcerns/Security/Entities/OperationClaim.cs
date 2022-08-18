using Core.Entities;

namespace Core.CrossCuttingConcerns.Security.Entities
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> Users { get; set; } = new();
    }
}
