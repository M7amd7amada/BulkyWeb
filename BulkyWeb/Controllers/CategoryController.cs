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
        if (_dbContext.Categories is not null && ModelState.IsValid)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        return RedirectToAction("Index");
    }
}