using System.ComponentModel.DataAnnotations;

using RockyPanelBackend.Lang;

namespace RockyPanel.Models.Forms
{
    public class LoginFormModel
    {
        [EmailAddress()]
        [Required]
        public string Email { get; set; }

        [MinLength(8, ErrorMessage = "The password must have a lenght of min. 8 chars")]
        [Required]
        public string Password { get; set; }
    }
}
