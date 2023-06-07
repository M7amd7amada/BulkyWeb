namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryRepository _repository;

    public CategoryController(ICategoryRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_repository.GetAll().OrderBy(c => c.DisplayOrder));
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
            _repository.Create(category);
            _repository.Save();
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
            var category = _repository.Get(c => c.CategoryId == id);
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
            _repository.Update(category);
            _repository.Save();
            TempData["success"] = "Updated Done";
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
            var category = _repository.Get(c => c.CategoryId == id);
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
            var category = _repository.Get(c => c.CategoryId == id);
            if (category is null)
                return NotFound();
            _repository.Delete(category);
            _repository.Save();
            TempData["success"] = "Deleted Done";
            return RedirectToAction("Index");
        }
        return View();
    }
}