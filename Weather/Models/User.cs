using System.ComponentModel.DataAnnotations;

namespace Weather.Models
{
    public class User
    {
        [Required] public string Id { get; set; }
        [Required]public string Username { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
    }
}
