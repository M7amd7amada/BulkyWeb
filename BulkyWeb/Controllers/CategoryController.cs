using System.ComponentModel;
namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _dbContext;

    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View(_dbContext.Categories?.OrderBy(c => c.DisplayOrder));
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (category.Name == category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Name", "They Should Not Be The Same");
        }

        if (_dbContext.Categories is not null && ModelState.IsValid)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Update(int? id)
    {
        if (id is not null && _dbContext.Categories is not null)
        {
            var category = _dbContext.Categories.Find(id);
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
        if (_dbContext.Categories is not null && ModelState.IsValid)
        {
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Delete(int? id)
    {
        if (id is not null && _dbContext.Categories is not null)
        {
            var category = _dbContext.Categories.Find(id);
            if (category is null)
            {
                return NotFound();
            }
            _dbContext.Categories.Remove(category);
            return RedirectToAction("Index");
        }
        return NotFound();
    }
}