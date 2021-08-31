using System;

namespace RendaSolidaria.Core.Domain.Schemas
{
    public class SchemaBase
    {
        public SchemaBase()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            CreatedBy = "Gui";
            UpdatedBy = "Vini";
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
