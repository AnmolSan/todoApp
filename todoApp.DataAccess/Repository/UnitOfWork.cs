using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoApp.DataAccess.Repository.IRepository;

namespace todoApp.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ToDoList = new ToDoListRepository(_db);
        }
        public IToDoListRepository ToDoList { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
