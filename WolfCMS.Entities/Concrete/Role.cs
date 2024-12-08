namespace WolfCMS.Entities.Concrete
{
    public class Role : BaseClass
    {
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
