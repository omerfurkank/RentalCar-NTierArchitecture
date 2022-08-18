using Business.Abstracts;
using Core.CrossCuttingConcerns.Security.Entities;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _dal;

        public UserManager(IUserDal userDal)
        {
            _dal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _dal.GetClaims(user);
        }

        public void Add(User user)
        {
            _dal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _dal.Get(u => u.Email == email);
        }
    }
}
