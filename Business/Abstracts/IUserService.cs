using Core.CrossCuttingConcerns.Security.Entities;

namespace Business.Abstracts
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
