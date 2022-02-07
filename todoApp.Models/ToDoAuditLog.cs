using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todoApp.Models
{
    public class ToDoAuditLog
    {
        
        [Key] 
        [Column(Order = 1)]
        public int Id { get; set; }
        

        [StringLength(50)] 
        [Column(Order = 2)] 
        public  string Field { get; set; }

        [StringLength(50)] 
        [Column(Order = 3)]
        [Display(Name = "New value")]
        public string OldValue { get; set; }

        [StringLength(50)] 
        [Column(Order = 4)]
        [Display(Name = "New Value")]
        public string NewValue { get; set; }

       
        public  DateTime Date { get; set; } = DateTime.Now;

         [Column(Order = 5)]
         //foreign key for todo class
        public int ToDoId { get; set; }

        public  ToDo ToDo { get; set; }
        
        //foreign key for user class
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
