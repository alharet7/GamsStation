using App.DataAccess.Data;
using App.DataAccess.Repository.IRepository;
using App.Models;
using App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Collections.Generic;

namespace GamsStation.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class GameController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public GameController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Game> objGameList = _unitOfWork.Game.GetAll(includeProperties: "Category").ToList();
            return View(objGameList);
        }

        public IActionResult Upsert(int? id)
        {
            GameVM gameVM = new()
            {
                CategoryList = _unitOfWork.Category
              .GetAll().Select(u => new SelectListItem
              {
                  Text = u.Name,
                  Value = u.Id.ToString(),
              }),
                Game = new Game()
            };
            if (id == null || id == 0)
            {
                return View(gameVM);
            }
            else
            {
                //Update
                gameVM.Game = _unitOfWork.Game.Get(u => u.Id == id);
                return View(gameVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(GameVM gameVM, IFormFile? file)
        {
            gameVM.Game.ImageURL = _unitOfWork.UploadImage(file);

            if (ModelState.IsValid)
            {
                _unitOfWork.Game.Add(gameVM.Game);
                _unitOfWork.Save();
                TempData["success"] = "Game created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                gameVM.CategoryList = _unitOfWork.Category
                    .GetAll().Select(u => new SelectListItem
                    {
                        Text = u.Name,
                        Value = u.Id.ToString(),
                    });
                return View(gameVM);
            }
        }

        public IActionResult Details(int id)
        {
            Game game = _unitOfWork.Game.Get(u => u.Id == id, includeProperties: "Category");
            return View(game);
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Game> objGameList = _unitOfWork.Game.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objGameList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var gameToBeDeleted = _unitOfWork.Game.Get(u => u.Id == id);
            if (gameToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error While deleting!" });
            }

            _unitOfWork.Game.Remove(gameToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful!" });
        }
        #endregion
    }
}
