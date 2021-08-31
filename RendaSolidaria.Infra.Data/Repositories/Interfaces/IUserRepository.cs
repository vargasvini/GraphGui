using RendaSolidaria.Core.Domain.Schemas;
using RendaSolidaria.Infra.Data.Context;
using System.Linq;

namespace RendaSolidaria.Infra.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> Get(MainContext context);
    }
}
