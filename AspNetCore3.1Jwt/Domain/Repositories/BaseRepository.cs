using AspNetCore3._1Jwt.Domain.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore3._1Jwt.Domain.Repositories
{
    public class BaseRepository
    {
        protected readonly UdemyApiWithTokenDBContext _context;
        public BaseRepository(UdemyApiWithTokenDBContext context)
        {
            _context = context;
        }
    }
}
