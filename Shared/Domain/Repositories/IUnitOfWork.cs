namespace si730pc2u202119447.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}