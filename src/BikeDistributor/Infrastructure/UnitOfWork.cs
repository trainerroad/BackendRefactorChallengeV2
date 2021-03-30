using System.Linq;

namespace BikeDistributor.Infrastructure
{
    public interface IUnitOfWork
    {
        IQueryable<T> Query<T>();
    }

    public class UnitOfWork : IUnitOfWork
    {
        public IQueryable<T> Query<T>()
        {
            //You do not need to implement this method for the coding exercise
            throw new System.NotImplementedException();
        }
    }
}
