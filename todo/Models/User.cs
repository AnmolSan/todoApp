using System.ComponentModel.DataAnnotations;

namespace todo.Models
{
    public class User
    {
        [Key]
        int UserId { get; set; }
        [Required]
        string UserName { get; set; }
        [Required]
        string Password { get; set; }
        string FullName  { get; set; }

    }

}   
