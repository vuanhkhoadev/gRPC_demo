using System.ComponentModel.DataAnnotations;

namespace gRPC_Service.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
