using RendaSolidaria.Core.Domain.Validations;

namespace RendaSolidaria.Core.Domain.Schemas
{
    public class User : SchemaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            if (IsValidDomain(name))
            {
                Name = name;
            }
        }

        private bool IsValidDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name: Property cannot be null or empty.");
            return true;
        }
    }
}
