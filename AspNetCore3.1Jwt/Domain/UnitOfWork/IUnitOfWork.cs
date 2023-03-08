using System.Threading.Tasks;

namespace AspNetCore3._1Jwt.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
