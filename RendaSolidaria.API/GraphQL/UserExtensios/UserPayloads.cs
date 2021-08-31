using RendaSolidaria.Core.Domain.Schemas;

namespace RendaSolidaria.API.GraphQL.UserExtensios
{
    public record AddUserPayload(User User) : PayloadBase();
}
