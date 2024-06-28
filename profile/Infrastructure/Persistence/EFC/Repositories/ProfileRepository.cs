 
 
 

 
 
 
 
 


using Microsoft.EntityFrameworkCore;
using si730pc2u202119447.API.profile.Domain.Model.Aggregates;
using si730pc2u202119447.API.profile.Domain.Repositories;
using si730pc2u202119447.API.Shared.Infrastructure.Persistence.EFC;
 
 

 

namespace si730pc2u202119447.API.profile.Infrastructure.Persistence.EFC.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _context;

        public ProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Profile> AddAsync(Profile profile)
        {
            await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
            return profile;
        }

        public async Task<Profile> FindByEmailAsync(string email)
        {
            return await _context.Profiles.SingleOrDefaultAsync(p => p.Email == email);
        }

        public async Task<Profile> FindByIdAsync(int id)
        {
            return await _context.Profiles.FindAsync(id);
        }
    }
}