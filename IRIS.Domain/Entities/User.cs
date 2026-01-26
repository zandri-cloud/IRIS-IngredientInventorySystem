using System.ComponentModel.DataAnnotations;

namespace IRIS.Domain.Entities
{
    public class User
    {
        [Key] public int UserId { get; set; }
        [Required, MaxLength(50)] public string? Username { get; set; }
        [Required, MaxLength(225)] public string? PasswordHash { get; set; }
        [Required, MaxLength(30)] public string? Role { get; set; }
        public bool IsActive { get; set; }
    }
}
