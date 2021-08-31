using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using RendaSolidaria.Core.Domain.Schemas;
using RendaSolidaria.Infra.Data.Context;
using RendaSolidaria.Infra.Data.Repositories.Interfaces;
using System.Linq;

namespace RendaSolidaria.API.GraphQL.UserExtensios
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class UserQueries
    {
        [UseDbContext(typeof(MainContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUser([ScopedService] MainContext context, [Service] IUserRepository userRepository)
        {
            return userRepository.Get(context);
        }
    }
}
