namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_unitOfWork.CategoryRepository.GetAll().OrderBy(c => c.DisplayOrder));
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.CategoryRepository.Create(category);
            _unitOfWork.Save();
            TempData["success"] = "Created Done";
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Update(int? id)
    {
        if (id is not null)
        {
            var category = _unitOfWork.CategoryRepository.Get(c => c.CategoryId == id);
            if (category is null)
            {
                return NotFound();
            }
            return View(category);
        }
        return NotFound();
    }
    [HttpPost]
    public IActionResult Update(Category category)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.Save();
            TempData["success"] = "Updated Done";
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
            var category = _unitOfWork.CategoryRepository.Get(c => c.CategoryId == id);
            if (category is null)
            {
                return NotFound();
            }
            return View(category);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePost(int? id)
    {
        if (ModelState.IsValid)
        {
            var category = _unitOfWork.CategoryRepository.Get(c => c.CategoryId == id);
            if (category is null)
                return NotFound();
            _unitOfWork.CategoryRepository.Delete(category);
            _unitOfWork.Save();
            TempData["success"] = "Deleted Done";
            return RedirectToAction("Index");
        }
        return View();
    }
}