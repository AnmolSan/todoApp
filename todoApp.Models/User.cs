using System.ComponentModel.DataAnnotations;

namespace todoApp.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; } //Is principle key and a primary key 
        
        [Display(Name = "User Name")] 
        [Required(ErrorMessage = "Required")] 
        [StringLength(50)] 
        public string UserName { get; set; } // is required field with string capacity of 50 

        [Required(ErrorMessage = "Required")] 
        [StringLength(50)] 
        public string Password { get; set; } // is required field with string capacity of 50 

        [Display(Name ="Full Name")]
        [StringLength(70)] 
        public string FullName  { get; set; } // string capacity of 70 

        [Display(Name = "Last Login")] 
        public Nullable<DateTime> LastLoginDateTime { get; set; }

        [Display(Name = "Remember Me")] 
        public bool RememberMe  { get; set; }


    }

}   
