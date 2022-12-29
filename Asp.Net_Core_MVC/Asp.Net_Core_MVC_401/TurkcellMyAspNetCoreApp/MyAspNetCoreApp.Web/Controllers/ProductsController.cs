using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using MyAspNetCoreApp.Web.Filters;
using MyAspNetCoreApp.Web.Helpers;
using MyAspNetCoreApp.Web.Models;
using MyAspNetCoreApp.Web.ViewModels;

namespace MyAspNetCoreApp.Web.Controllers
{

    [Route("[controller]/[action]")]
    public class ProductsController : Controller
    {
        private AppDbContext _context;
        private readonly IFileProvider _fileProvider;

        private readonly IMapper _mapper;
        private readonly ProductRepository _productRepository;
        public ProductsController(AppDbContext context, IMapper mapper, IFileProvider fileProvider)
        {
            _productRepository = new ProductRepository();
            _context = context;
            _mapper = mapper;
            _fileProvider = fileProvider;
        }

        [CacheResourceFilter]
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            
            return View(_mapper.Map<List<ProductViewModel>>(products));
        }

        //[HttpGet("{page}/{pageSize}")]
        [Route("[controller]/[action]/{page}/{pageSize}", Name = "productpage")]
        public IActionResult Pages(int page, int pageSize)
        {
            // page=1 pagesize=3 => ilk 3 kayıt
            // page=2 pagesize=3 => ikinci 3 kayıt
            // page=3 pagesize=3 => üçüncü 3 kayıt
            var products = _context.Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.page = page;
            ViewBag.pageSize = pageSize;

            return View(_mapper.Map<List<ProductViewModel>>(products));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [Route("urunler/urun/{productid}", Name = "product")]
        public IActionResult GetById(int productid)
        {
            var product = _context.Products.Find(productid);

            return View(_mapper.Map<ProductViewModel>(product));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);

            _context.Products.Remove(product);

            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Expire = new Dictionary<string, int>()
            {
                {"1 Ay", 1},
                {"3 Ay", 3},
                {"6 Ay", 6},
                {"12 Ay", 12}
            };

            ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>() { 
                new() { Data="Mavi", Value="Mavi"},
                new() { Data="Kırmızı", Value="Kırmızı"},
                new() { Data="Sarı", Value="Sarı"}
            }, "Value", "Data");

            return View();
        }

        [HttpPost]
        public async IActionResult Add(ProductViewModel newProduct)
        {
            IActionResult result = null;
            

            if (ModelState.IsValid)
            {
                try
                {
                    var root = _fileProvider.GetDirectoryContents("wwwroot");

                    var images = root.First(x => x.Name == "images");

                    var path = Path.Combine(images.PhysicalPath, newProduct.Image.FileName);

                    using var stream = new FileStream(path, FileMode.Create);

                    newProduct.Image.CopyTo(stream);

                    _context.Products.Add(_mapper.Map<Product>(newProduct));
                    _context.SaveChanges();

                    TempData["status"] = "Ürün başarıyla eklendi.";
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    ModelState.AddModelError(String.Empty,"Ürün kaydedilirken bir hata meydana geldi. Lütfen daha sonra tekrar deneyiniz.");

                    result = View();
                }
                
            }
            else
            {
                result = View();
            }

            ViewBag.Expire = new Dictionary<string, int>()
                {
                    {"1 Ay", 1},
                    {"3 Ay", 3},
                    {"6 Ay", 6},
                    {"12 Ay", 12}
                };

            ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>() {
                    new() { Data="Mavi", Value="Mavi"},
                    new() { Data="Kırmızı", Value="Kırmızı"},
                    new() { Data="Sarı", Value="Sarı"}
                }, "Value", "Data");

            return result;
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _context.Products.Find(id);

            ViewBag.ExpireValue = product.Expire;
            ViewBag.Expire = new Dictionary<string, int>()
            {
                {"1 Ay", 1},
                {"3 Ay", 3},
                {"6 Ay", 6},
                {"12 Ay", 12}
            };

            ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>() {
                new() { Data="Mavi", Value="Mavi"},
                new() { Data="Kırmızı", Value="Kırmızı"},
                new() { Data="Sarı", Value="Sarı"}
            }, "Value", "Data", product.Color);

            return View(_mapper.Map<ProductViewModel>(product));
        }

        [HttpPost]
        public IActionResult Update(ProductViewModel updateProduct)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ExpireValue = updateProduct.Expire;
                ViewBag.Expire = new Dictionary<string, int>()
                {
                    {"1 Ay", 1},
                    {"3 Ay", 3},
                    {"6 Ay", 6},
                    {"12 Ay", 12}
                };

                ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>() {
                    new() { Data="Mavi", Value="Mavi"},
                    new() { Data="Kırmızı", Value="Kırmızı"},
                    new() { Data="Sarı", Value="Sarı"}
                }, "Value", "Data", updateProduct.Color);

                return View();
            }

            _context.Products.Update(_mapper.Map<Product>(updateProduct));
            _context.SaveChanges();
            TempData["status"] = "Ürün başarıyla güncellendi.";
            return RedirectToAction("Index");
        }

        [AcceptVerbs("GET","POST")]
        public IActionResult HasProductName(string Name)
        {
            var anyProduct =_context.Products.Any(x => x.Name.ToLower() == Name.ToLower());

            if(anyProduct)
            {
                return Json("Kaydetmeye çalıştığınız ürün ismi veritabanında bulunmaktadır.");
            }
            else
            {
                return Json(true);
            }

        }
    }
}
