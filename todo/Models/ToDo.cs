using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todo.Models
{
    public class ToDo
    {   //Defines a primary key for sql using entity Framework and it is called DataAnnotation
        [Key]
        int ToDoId { get; set; }
        [Required]
        string Title { get; set; }
        DateTime DueDate { get; set; }

        //foreign key 
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        
    }
}
