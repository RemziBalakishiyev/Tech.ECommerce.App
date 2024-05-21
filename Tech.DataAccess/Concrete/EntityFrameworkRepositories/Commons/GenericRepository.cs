using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using Tech.DataAccess.Abstract;
using Tech.DataAccess.EntityFrameworks.Contexts;
using Tech.Entity.Concrete.Products;

namespace Tech.DataAccess.Concrete.EntityFrameworkRepositories.Commons;

public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    private readonly TechContext _dbContext;

    DbSet<T> Table => _dbContext.Set<T>();
    public GenericRepository(TechContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> AddAsync(T entity)
    {
        var addedState = await Table.AddAsync(entity);
        return addedState.State == EntityState.Added;
    }

    public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
    {
        if (tracking is false)
        {
            return await Table.AsNoTracking().ToListAsync();
        }
        return await Table.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

    public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        => await Table.Where(expression).ToListAsync();

    public bool Remove(T entity)
    {
        var removed = Table.Remove(entity);
        return removed.State == EntityState.Deleted;
    }

    public bool Update(T entity)
    {
        var updated = Table.Update(entity);
        return updated.State == EntityState.Modified;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
