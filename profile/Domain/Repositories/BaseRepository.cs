 

using si730pc2u202119447.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace si730pc2u202119447.API.profile.Domain.Repositories;

public abstract class BaseRepository
{
    protected readonly AppDBContext _context;

    protected BaseRepository(AppDBContext context)
    {
        _context = context;
    }
}