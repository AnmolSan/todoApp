using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoApp.Models;

namespace todoApp.DataAccess.Repository.IRepository
{
    public interface IToDoListRepository:IRepository<ToDo>
    {
        void Update (ToDo obj);
    }
}
