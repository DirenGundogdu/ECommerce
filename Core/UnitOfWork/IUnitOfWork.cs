namespace Core.UnitOfWork;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
    void SaveChanges();
}