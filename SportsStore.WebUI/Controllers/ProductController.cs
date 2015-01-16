using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
  public class ProductController : Controller
  {
    private readonly IProductRepository _productRepository;
    public int PageSize = 4;

    public ProductController(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public ViewResult List(int page = 1)
    {
      return View(_productRepository.Products
        .OrderBy(p => p.ProductId)
        .Skip((page - 1) * PageSize)
        .Take(PageSize)
        );
    }
  }
}