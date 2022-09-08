using System.ComponentModel.DataAnnotations;

namespace gRPC_Service.Domain.Entities
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
