using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todoApp.Models
{
    public class ToDo
    {   
        [Key] 
        [Column(Order = 1)] 
        public int ToDoId { get; set; } // primary key with defined columns position to 1 

        
        [Required] 
        [StringLength(100)] 
        public string Title { get; set; }
        [Display(Name ="Due Date")] 
        public DateTime DueDate { get; set; }


        //foreign key 
        [Column(Order = 2)] 
        public int UserId { get; set; }
        public User User { get; set; }

        
    }
}
