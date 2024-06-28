using si730pc2u202119447.API.Shared.Domain.Repositories;
using si730pc2u202119447.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace si730pc2u202119447.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDBContext _context;
    public UnitOfWork(AppDBContext context) => _context = context;

    public async Task CompleteAsync() => await _context.SaveChangesAsync();
}