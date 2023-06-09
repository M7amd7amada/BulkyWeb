namespace BulkyWeb.Areas.Customer.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.ProductRepository.GetAll();
        
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (product is null)
            return NotFound();

        _unitOfWork.ProductRepository.Create(product);
        _unitOfWork.Save();
        return RedirectToAction("Index");
    }

    public IActionResult Update(int? id)
    {
        if (id is null || _unitOfWork.ProductRepository is null)
            return NotFound();
        

        return View(_unitOfWork.ProductRepository.Get(p => p.ProductId == id));
    }
    [HttpPost]
    public IActionResult Update(Product product)
    {
        if (product is null)
            return NotFound();

        _unitOfWork.ProductRepository.Update(product);
        _unitOfWork.Save();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
    {
        if (id is null || _unitOfWork.ProductRepository is null)
            return NotFound();

        return View(_unitOfWork.ProductRepository.Get(p => p.ProductId == id));
    }
    [HttpPost]
    public IActionResult Delete(Product product)
    {
        if (product is null || _unitOfWork.ProductRepository is null)
            return NotFound();

        _unitOfWork.ProductRepository.Delete(product);
        _unitOfWork.Save();
        return RedirectToAction("Index");
    }
}