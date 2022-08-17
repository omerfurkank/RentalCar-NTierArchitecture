using Core.CrossCuttingConcerns.Security.Entities;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (RentalContext context = new())
            {
                //var result = from operationClaim in context.OperationClaims
                //             join userOperationClaim in context.UserOperationClaims
                //                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                //             where userOperationClaim.UserId == user.Id
                //             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                //return result.ToList();
                var result= context.Users.Include(u => u.OperationClaims).Single(u => u.Id == user.Id);
                return result.OperationClaims;
            }
        }
    }
}
