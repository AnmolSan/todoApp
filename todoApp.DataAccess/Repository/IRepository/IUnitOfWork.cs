using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IToDoListRepository ToDoList { get; }

        void Save();
    }
}
