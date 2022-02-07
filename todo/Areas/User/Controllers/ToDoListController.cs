using Microsoft.AspNetCore.Mvc;
using todoApp.Models;
using todoApp.DataAccess;
using todoApp.DataAccess.Repository.IRepository;

namespace todo.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ToDoListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<ToDo> objTodoList = _unitOfWork.ToDoList.GetAll();
            return View(objTodoList);
        }
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDo obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.ToDoList.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Record Saved successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //var toDoFromDb = _db.ToDo.Find(id);
            var toDoFromDbfirst = _unitOfWork.ToDoList.GetFirstOrDefault(c=>c.ToDoId == id); //Change it with mew interface after
            if(toDoFromDbfirst == null)
            {
                return NotFound();
            }
            
            return View(toDoFromDbfirst);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ToDo obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.ToDoList.Update(obj);  // to interface 
                _unitOfWork.Save();  // to interface unit of work 
                TempData["success"] = "Record Saved successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var toDoFromDbfirst = _unitOfWork.ToDoList.GetFirstOrDefault(c => c.ToDoId == id);//Change it with mew interface after
            if (toDoFromDbfirst == null)
            {
                return NotFound();
            }

            return View(toDoFromDbfirst);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var toDoFromDbfirst = _unitOfWork.ToDoList.GetFirstOrDefault(c => c.ToDoId == id);
            if (toDoFromDbfirst == null)
            {
                return NotFound();
            }
            _unitOfWork.ToDoList.Remove(toDoFromDbfirst);// to interface
            _unitOfWork.Save();
            TempData["success"] = "Record Delete successfully";
            return RedirectToAction("Index");
        }
    }
}
