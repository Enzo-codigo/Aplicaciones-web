using si730pc2u202119447.API.profile.Domain.Model.Aggregates;
using si730pc2u202119447.API.profile.Domain.Repositories;

namespace si730pc2u202119447.API.profile.Aplication.Internal.CommandServices;

public class ProfileCommandService
{
    private readonly IProfileRepository _profileRepository;

    public ProfileCommandService(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public async Task<Profile> AddProfileAsync(string name, string email, string password, string role)
    {
        var existingProfile = await _profileRepository.FindByEmailAsync(email);
        if (existingProfile != null)
        {
            throw new ArgumentException("Email already in use.");
        }

        var profile = new Profile
        {
            Name = name,
            Email = email,
            Password = password,
            Role = role,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        return await _profileRepository.AddAsync(profile);
    }
}