using HotChocolate;
using RendaSolidaria.Core.Domain.Schemas;
using RendaSolidaria.Infra.Data.Context;
using RendaSolidaria.Infra.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RendaSolidaria.Infra.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        //private readonly MainContext _context;

        //public UserRepository(MainContext context)
        //{
        //    _context = context;
        //}

        public IQueryable<User> Get([ScopedService] MainContext context)
        {
            return context.Users;
        }
    }
}
