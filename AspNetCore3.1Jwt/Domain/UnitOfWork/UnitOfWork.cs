using AspNetCore3._1Jwt.Domain.Contexts;
using System.Threading.Tasks;

namespace AspNetCore3._1Jwt.Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UdemyApiWithTokenDBContext _context;
        public UnitOfWork(UdemyApiWithTokenDBContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await this._context.SaveChangesAsync();
        } 
    }
}
