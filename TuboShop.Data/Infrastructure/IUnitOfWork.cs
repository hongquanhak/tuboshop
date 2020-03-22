namespace TuboShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}