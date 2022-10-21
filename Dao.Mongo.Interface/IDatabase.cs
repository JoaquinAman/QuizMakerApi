namespace Dao.Mongo.Interface
{
    public interface IDatabase<TEntity>
    {
        Task<List<TEntity>> GetList();
    }
}
