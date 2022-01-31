using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todo.Models
{
    public class ToDoAuditLog
    {
        //foreign key for todo class
        [Display(Name = "ToDo")]
        public virtual int ToDoId { get; set; }
        [ForeignKey("ToDoId")]
        public virtual ToDo ToDo { get; set; }

        private string Field { get; set; }

        string OldValue { get; set; }
        string NewValue { get; set; }

        //foreign key for user class

        [Display(Name = "User")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        private DateTime Date { get; set; } = DateTime.Now;
    }
}
