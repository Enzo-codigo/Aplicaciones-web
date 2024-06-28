using Microsoft.AspNetCore.Mvc;
 
using si730pc2u202119447.API.profile.Domain.Model.Aggregates;
using si730pc2u202119447.API.profile.Domain.Repositories;
 
namespace si730pc2u202119447.API.profile.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
public class ProfilesController : ControllerBase
{
    private readonly IProfileRepository _profileRepository;

    public ProfilesController(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProfile([FromBody] Profile profile)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            var createdProfile = await _profileRepository.AddAsync(profile);
            return CreatedAtAction(nameof(GetProfileById), new { id = createdProfile.Id }, createdProfile);
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Error in CreateProfile: {ex.Message}");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProfileById(int id)
    {
        var profile = await _profileRepository.FindByIdAsync(id); // Cannot resolve symbol 'FindByIdAsync'
        if (profile == null)
            return NotFound();

        return Ok(profile);
    }
}