namespace gRPC_Service.Domain.Entities
{
    public class UserInformation : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
