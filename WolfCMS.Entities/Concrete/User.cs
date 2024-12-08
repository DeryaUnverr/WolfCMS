namespace WolfCMS.Entities.Concrete
{
    public class User : BaseClass
    {
        public int AvatarId { get; set; }
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}