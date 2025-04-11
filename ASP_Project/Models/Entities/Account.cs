using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ASP_Project.Models.Entities
{
    public enum Role
    {
        User = 0,
        Admin = 1
    }
    public class Account
    { 
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string? Password { get; set; }

        [DefaultValue(Role.User)]
        public Role Role { get; set; }

        [DefaultValue(false)]
        public bool Verified { get; set; }
    }
}
