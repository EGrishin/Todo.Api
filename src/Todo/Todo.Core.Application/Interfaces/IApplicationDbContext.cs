using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Todo.Core.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.Todo> Todos { get; set; }

        Task<int> SaveChangesAsync();
    }
}
