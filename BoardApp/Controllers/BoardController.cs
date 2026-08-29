// Programmer name : BoardApp Group
// Student nr      : 222049725;223022994;225007032;220024412;225004492
// Assignment nr   : Practical Assessment 1
// Purpose         : Controller responsible for listing, viewing, creating,
//                  editing and deleting Board objects via the Repository

using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public ViewResult Index()
        {
            //
            //Name              : ViewResult Index()
            //Purpose           : Returns the Index view together with the
            //                    full list of Board objects currently stored
            //                    in Repository
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : ViewResult
            //                  - the Index view, populated with the current
            //                    collection of boards from Repository
            //
            return View(Repository.Boards);
        }// end method

        public ViewResult Details(string id)
        {
            //
            //Name              : ViewResult Details(string id)
            //Purpose           : Uses id to locate the matching Board in
            //                    Repository and returns the Details view
            //                    populated with that board
            //Re-use            : None
            //Method Parameters : string id
            //                  - the board code of the board to display
            //Output Type       : ViewResult
            //                  - the Details view, populated with the
            //                    matching Board object
            //

            var board = Repository.Boards.FirstOrDefault(b => b.BoardCode == id);
            return View(board);
        } // end method

        [HttpGet]
        public ViewResult Create()
        {
            //
            //Name              : ViewResult Create()
            //Purpose           : Returns the default Create view so the
            //                    user can capture a new board
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : ViewResult
            //                  - the empty Create view for capturing a
            //                    new board
            //
            return View();
        } // end method


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            //
            //Name              : ViewResult Create(Board board)
            //Purpose           : Validates the captured board; if valid,
            //                    adds it to Repository and sets a success
            //                    message; returns the Create view with the
            //                    captured board either way
            //Re-use            : Repository.AddBoard()
            //Method Parameters : Board board
            //                  - the board object bound from the posted
            //                    form data
            //Output Type       : ViewResult
            //                  - the Create view, populated with the
            //                    captured board and, if successful, a
            //                    success message in ViewBag.SuccessMessage
            //
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added.";
            } // end if
            return View(board);
        } // end method


        [HttpGet]
        public ViewResult Edit(string id)
        {
            //
            //Name              : ViewResult Edit(string id)
            //Purpose           : Uses id to find the matching Board in
            //                    Repository and returns the Edit view
            //                    populated with that board
            //Re-use            : Repository.GetByBoardCode()
            //Method Parameters : string id
            //                  - the board code of the board to edit
            //Output Type       : ViewResult
            //                  - the Edit view, populated with the
            //                    matching Board object
            //

            Board? board = Repository.GetByBoardCode(id);
            return View(board);
        }// end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            //
            //Name              : ViewResult Edit(Board board)
            //Purpose           : Validates the submitted board; if valid,
            //                    updates the matching board in Repository
            //                    and sets a success message; returns the
            //                    Edit view with the submitted board
            //                    either way
            //Re-use            : Repository.UpdateBoard()
            //Method Parameters : Board board
            //                  - the board object bound from the posted
            //                    form data, containing the updated values
            //Output Type       : ViewResult
            //                  - the Edit view, populated with the
            //                    submitted board and, if successful, a
            //                    success message in ViewBag.SuccessMessage
            //

            if (ModelState.IsValid)
            {
                Repository.UpdateBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was updated.";
            } // end if

            return View(board);
        } //end method

        [HttpGet]
        public ViewResult Delete(string id)
        {
            //
            //Name              : ViewResult Delete(string id)
            //Purpose           : Uses id to find the matching Board in
            //                    Repository and returns the Delete view
            //                    populated with that board so the user can
            //                    confirm the deletion
            //Re-use            : Repository.GetByBoardCode()
            //Method Parameters : string id
            //                  - the board code of the board to delete
            //Output Type       : ViewResult
            //                  - the Delete view, populated with the
            //                    matching Board object
            //

            Board? board = Repository.GetByBoardCode(id);
            return View(board);
        } // end method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            //
            //Name              : ViewResult Delete(Board board)
            //Purpose           : Removes the board identified by the
            //                    posted board code from Repository and
            //                    sets a success message; returns the
            //                    Delete view with the submitted board
            //Re-use            : Repository.RemoveBoard()
            //Method Parameters : Board board
            //                  - the board object bound from the posted
            //                    form data; only BoardCode is populated,
            //                    since the Delete form posts a single
            //                    hidden field
            //Output Type       : ViewResult
            //                  - the Delete view, populated with the
            //                    submitted board and a success message in
            //                    ViewBag.SuccessMessage
            //

            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";
            return View(board);
        } // end method
    } // end class BoardController
} // end namespace BoardApp.Controllers