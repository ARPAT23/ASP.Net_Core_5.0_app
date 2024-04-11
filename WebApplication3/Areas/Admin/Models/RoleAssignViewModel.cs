namespace WebApplication3.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool Exists { get; set; }
        public string UserName { get; set; }
    }
}
