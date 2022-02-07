using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoApp.DataAccess.Repository.IRepository;
using todoApp.Models;

namespace todoApp.DataAccess.Repository
{
    public class ToDoListRepository : Repository<ToDo>, IToDoListRepository
    {
        private ApplicationDbContext _db;
        public ToDoListRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ToDo obj)
        {
            _db.ToDo.Update(obj);
        }
    }
}
