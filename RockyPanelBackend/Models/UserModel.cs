using System.ComponentModel.DataAnnotations;

namespace RockyPanelBackend.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name_First { get; set; }
        public string Name_Last { get; set; }
        public string Password { get; set; }
        public bool Root_Admin { get; set; }
    }
}
