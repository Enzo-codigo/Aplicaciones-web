using si730pc2u202119447.API.profile.Domain.Model.Aggregates;

namespace si730pc2u202119447.API.profile.Domain.Repositories;

public interface IProfileRepository
{
    Task<Profile> AddAsync(Profile profile);
    Task<Profile> FindByEmailAsync(string email);
    Task<Profile> FindByIdAsync(int id); // Define el método para buscar por ID
}