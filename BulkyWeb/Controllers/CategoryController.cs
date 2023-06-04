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
        return View(_dbContext.Categories);
    }

    public IActionResult Create()
    {
        return View();
    }
}