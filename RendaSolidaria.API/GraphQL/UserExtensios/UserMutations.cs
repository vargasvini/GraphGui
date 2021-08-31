using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using RendaSolidaria.Core.Domain.Schemas;
using RendaSolidaria.Infra.Data.Context;

namespace RendaSolidaria.API.GraphQL.UserExtensios
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class UserMutations
    {
        [UseDbContext(typeof(MainContext))]
        public AddUserPayload AddUser([ScopedService] MainContext context, AddUserInput input)
        {
            try
            {
                var user = new User(input.name);

                context.Add(user);
                context.SaveChanges();

                return new AddUserPayload(user);
            }
            catch (System.Exception ex)
            {
                var userPayload = new AddUserPayload(null);
                userPayload.IsSuccess = false;
                userPayload.ErrorMessage = ex.Message;
                return userPayload;
            }

        }
    }
}
